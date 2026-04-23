using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;

namespace CIPHER.Services
{
    public class AdminService
    {
        private readonly AuditService _audit = new();

        public List<User> GetAllAgents()
        {
            var list = new List<User>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT UserID,Codename,XP,Rank,AccountStatus,Role FROM Users WHERE Role = 'Agent'", conn);
            var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(new User
            {
                UserID = (int)r["UserID"],
                Codename = r["Codename"].ToString(),
                XP = (int)r["XP"],
                Rank = r["Rank"].ToString(),
                AccountStatus = r["AccountStatus"].ToString(),
                Role = r["Role"].ToString()

            });
            return list;
        }

        public void ResetAgentProgress(int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            DELETE FROM Progress WHERE UserID=@uid", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.ExecuteNonQuery();
            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Reset progress for UserID {userID}");

        }

        public void UnlockAgent(int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            UPDATE Users SET AccountStatus='Active' WHERE UserID = @uid", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.ExecuteNonQuery();
            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Unlocked Account for UserID {userID}");
        }

        public void LockAgent(int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            UPDATE Users SET AccountStatus='Locked' WHERE UserID = @uid", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.ExecuteNonQuery();
            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Locked Account for UserID {userID}");
        }

        public void DeleteBounty(int bountyID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            DELETE FROM Bounties WHERE BountyID = @bid", conn);
            cmd.Parameters.AddWithValue("@bid", bountyID);
            cmd.ExecuteNonQuery();
            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Deleted BountyID {bountyID}");
        }

        public void CreateMission(Mission m)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
           INSERT INTO Missions (Title, Category, Difficulty, Briefing, Answer, Hint, XPReward, CoinReward, OrderIndex)
           SELECT @t, @c, @d, @b, @a, @h, @x, @cr, ISNULL(MAX(OrderIndex), 0) + 1 
           FROM Missions
           SELECT SCOPE_IDENTITY();", conn);
            cmd.Parameters.AddWithValue("@t", m.Title);
            cmd.Parameters.AddWithValue("@c", m.Category);
            cmd.Parameters.AddWithValue("@d", m.Difficulty);
            cmd.Parameters.AddWithValue("@b", m.Briefing);
            cmd.Parameters.AddWithValue("@a", m.Answer);
            cmd.Parameters.AddWithValue("@h", m.Hint);
            cmd.Parameters.AddWithValue("@x", m.XPReward);
            cmd.Parameters.AddWithValue("@cr", m.CoinReward);
            object result = cmd.ExecuteScalar();
            int newID = Convert.ToInt32(result);

            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Admin added Mission #{newID}");
        }

        public void UpdateMission(Mission m)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            UPDATE Missions SET Title = @t, Category = @c, Difficulty = @d, 
            Briefing = @b , Answer = @a , Hint = @h, XPreward = @x, CoinReward = @cr 
            WHERE MissionID = @mid", conn);
            cmd.Parameters.AddWithValue("@t", m.Title);
            cmd.Parameters.AddWithValue("@c", m.Category);
            cmd.Parameters.AddWithValue("@d", m.Difficulty);
            cmd.Parameters.AddWithValue("@b", m.Briefing);
            cmd.Parameters.AddWithValue("@a", m.Answer);
            cmd.Parameters.AddWithValue("@h", m.Hint);
            cmd.Parameters.AddWithValue("@x", m.XPReward);
            cmd.Parameters.AddWithValue("@cr", m.CoinReward);
            cmd.Parameters.AddWithValue("@mid", m.MissionID);

            cmd.ExecuteNonQuery();


            _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Admin added Mission #{m.MissionID}");
        }

        public void DeleteMission(int missionID)
        {
            using var conn = DBHelper.Getconnection();
            conn.Open();

            // Start a transaction so both deletes happen, or neither happens
            using var tx = conn.BeginTransaction();

            try
            {
                // 1. Delete dependent records first (Foreign Key protection)
                new SqlCommand("DELETE FROM Progress WHERE MissionID = @mid", conn, tx)
                {
                    Parameters = { new("@mid", missionID) }
                }.ExecuteNonQuery();

                // 2. Delete the actual mission
                var cmd = new SqlCommand("DELETE FROM Missions WHERE MissionID = @mid", conn, tx);
                cmd.Parameters.AddWithValue("@mid", missionID);
                cmd.ExecuteNonQuery();

                // If we got here with no errors, save the changes permanently
                tx.Commit();

                // 3. Log the action
                _audit.Log(SessionManager.CurrentUser.UserID, "AdminAction", $"Admin Deleted mission #{missionID}");
            }
            catch (Exception ex)
            {
                // If anything fails (DB connection, SQL error, etc.), undo everything
                tx.Rollback();
                // Rethrow the error so your UI can show a Messagebox to the admin
                throw new Exception("Failed to delete mission. See inner exception for details.", ex);
            }


        }
        public AdminStats GetStats()
        {
            var stat = new AdminStats();

            using var conn = DBHelper.Getconnection();
            conn.Open();
            var cmd = new SqlCommand(@"SELECT COUNT(*) FROM Users WHERE Role = 'Agent'", conn);
            stat.TotalAgents = Convert.ToInt32(cmd.ExecuteScalar());

            var cmd2 = new SqlCommand(@"SELECT COUNT(*) 
            FROM Progress WHERE Solved = 1 AND CAST(SolvedAt as DATE) = CAST(GETDATE() as DATE) ", conn);
            stat.MissionsSolvedToday = Convert.ToInt32(cmd2.ExecuteScalar());

            var cmd3 = new SqlCommand(@"SELECT TOP 1 CodeName FROM Users
            ORDER BY XP Desc",conn);
            stat.TopAgentCodename = cmd3.ExecuteScalar().ToString() ?? "None";

            var cmd4 = new SqlCommand(@"
            SELECT TOP 1 m.Title
            FROM Missions m
            JOIN Progress p ON m.MissionID = p.MissionID
            GROUP BY m.MissionID, m.Title
            HAVING SUM(p.Attempts) > 0  -- Avoid division by zero
            ORDER BY 
                (CAST(SUM(CAST(p.Solved AS INT)) AS FLOAT) / SUM(p.Attempts)) ASC", conn);
            stat.MostFailedMission = cmd4.ExecuteScalar().ToString() ?? "None";


            var cmd5 = new SqlCommand(@"
            SELECT COUNT(*) FROM Bounties
            WHERE Status = 'Open'
            ", conn);
            stat.ActiveBounties = Convert.ToInt32(cmd5.ExecuteScalar());

            return stat;
        }
    }

    
}
