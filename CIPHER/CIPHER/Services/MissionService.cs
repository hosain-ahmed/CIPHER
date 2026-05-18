using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public static class PuzzleValidator
    {
        public static bool Check(Mission m, string answer) =>
            string.Equals(m.Answer.Trim(), answer.Trim(), StringComparison.OrdinalIgnoreCase);
    }
    public class MissionService
    {
        public List<Mission> GetMissionForAgent(int userID)
        {
            var list = new List<Mission>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
    SELECT m.*,
        ISNULL(p.Solved, 0) as IsSolved,
        ISNULL(p.Attempts,0) as AttemptsMade
    FROM Missions m
    LEFT JOIN Progress p ON m.MissionID=p.MissionID AND p.UserID=@uid 
    ORDER BY m.OrderIndex", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                var mission = MapMission(r);
                mission.IsSolved = r["IsSolved"].ToString(); // set here only
                list.Add(mission);
            }
            return list;
        }

        public List<Mission> GetAllMissions() 
        {
            var list = new List<Mission>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT * FROM Missions ORDER BY OrderIndex", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(MapMission(r));
            return list;
        }

        public Mission GetByID(int missionID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT * FROM Missions WHERE MissionID=@mid", conn);
            cmd.Parameters.AddWithValue("@mid", missionID);
            using var r = cmd.ExecuteReader();
            return r.Read() ? MapMission(r) : null;
        }

        private Mission MapMission(SqlDataReader r) => new Mission
        {
            MissionID = (int)r["MissionID"],
            Title = r["Title"].ToString(),
            Category = r["Category"].ToString(),
            Difficulty = r["Difficulty"].ToString(),
            Briefing = r["Briefing"].ToString(),
            Answer = r["Answer"].ToString(),
            Hint = r["Hint"].ToString(),
            XPReward = (int)r["XPReward"],
            CoinReward = (int)r["CoinReward"],
            OrderIndex = (int)r["OrderIndex"],
            
        };

        public (bool correct, int xp, int coin) SubmitAnswer(int userID, int missionID, string answer)
        {
            var mission = GetByID(missionID);

            using var checkConn = DBHelper.Getconnection();
            var checkCmd = new SqlCommand(@"
    SELECT ISNULL(p.Solved, 0) FROM Progress p
    WHERE p.UserID = @uid AND p.MissionID = @mid", checkConn);
            checkCmd.Parameters.AddWithValue("@uid", userID);
            checkCmd.Parameters.AddWithValue("@mid", missionID);
            var solvedResult = checkCmd.ExecuteScalar();
            if (solvedResult != null && solvedResult != DBNull.Value && Convert.ToInt32(solvedResult) == 1)
                return (false, 0, 0);
            

            if (mission == null)
            {
                MessageBox.Show($"Mission not found! ID: {missionID}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, 0, 0);
            }
            if (mission == null || !PuzzleValidator.Check(mission, answer))
            {
                // 🔒 Log the failed attempt and check rate limit
                var detector = new IntrusionDetector();
                detector.logAttempt(userID, missionID, answer);
                if (detector.isRateLimited(userID))
                {
                    detector.LockAccount(userID);
                    detector.ScheduleUnlock(userID, () => { });
                    return (false, 0, 0); // account now locked
                }
                return (false, 0, 0);
            }

            using var conn = DBHelper.Getconnection();
            var tx = conn.BeginTransaction();
            try
            {
                //Upsert Progress
                var cmd = new SqlCommand(@"
                IF EXISTS(SELECT 1 FROM Progress WHERE UserID= @uid AND MissionID= @mid)
                UPDATE Progress SET Solved = 1,SolvedAt=GETDATE()
                WHERE UserID=@uid AND MissionID =@mid
                ELSE
                    INSERT INTO Progress(UserID,MissionID,Solved,SolvedAt)
                    VALUES(@uid,@mid,1,GETDATE())", conn, tx);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@mid", missionID);
                cmd.ExecuteNonQuery();

                /*     Parameters = {
                         new ("@uid",userID),
                         new ("@mid",missionID)
                     }
                 }.ExecuteNonQuery();*/

                int xpToaward = mission.XPReward;
                int coinToAward = mission.CoinReward;

                var cmdBoost = new SqlCommand(@"SELECT XPBoostMissions FROM Users WHERE UserID = @uid", conn, tx);
                cmdBoost.Parameters.AddWithValue("@uid", userID);
                var boostResult = cmdBoost.ExecuteScalar();
                int boostMissions = boostResult == DBNull.Value ? 0 : (int)boostResult;
                if (boostMissions > 0)
                {
                    xpToaward *= 2;
                    new SqlCommand(
                "UPDATE Users SET XPBoostMissions = XPBoostMissions - 1 WHERE UserID = @uid",
                conn, tx)
                    { Parameters = { new SqlParameter("@uid", userID) } }
            .ExecuteNonQuery();
                }



                var cmd1 = new SqlCommand(@"
                UPDATE Users SET XP = XP +@xp , CryptCoin = CryptCoin +@c
                WHERE UserID = @uid
                ", conn, tx);
                cmd1.Parameters.AddWithValue("@xp", xpToaward);
                cmd1.Parameters.AddWithValue("@c", coinToAward);
                cmd1.Parameters.AddWithValue("@uid", userID);
                cmd1.ExecuteNonQuery();
                tx.Commit();
                RankService.UpdateRank(userID, SessionManager.CurrentUser.XP + mission.XPReward);
                SessionManager.RefreshUser();
                return (true, mission.XPReward, mission.CoinReward);
            }
            catch (Exception ex)
            {
                try { tx.Rollback(); } catch { }
                MessageBox.Show($"SubmitAnswer failed: {ex.Message}");
                return (false, 0, 0);
            }
        }
    }
}
