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
    }
}
