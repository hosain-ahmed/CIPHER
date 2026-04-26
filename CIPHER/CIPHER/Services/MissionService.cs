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
            while (!r.Read()) list.Add(MapMission(r));
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
            var cmd = new SqlCommand("SELECT * FROM Missions WHERE MissioID=@mid", conn);
            cmd.Parameters.AddWithValue("@mid", missionID);
            using var r = cmd.ExecuteReader();
            return r.Read() ? MapMission(r) : null;
        }

        private Mission MapMission(SqlDataReader r) => new Mission
        {
            MissionID = (int)r["MissionID"],
            Title= r["Title"].ToString(),
            Category = r["Category"].ToString(),
            Difficulty = r["Difficulty"].ToString(),
            Briefing = r["Briefing"].ToString(),
            Answer = r["Answer"].ToString(),
            Hint = r["Hint"].ToString(),
            XPReward = (int)r["XPReward"],
            CoinReward = (int)r["CoinReward"],
            OrderIndex = (int)r["OrderIndex"]  
        };

        public(bool correct, int xp, int coin) SubmitAnswer(int userID, int missionID, string answer)
        {
            var mission = GetByID(missionID);
            if (!PuzzleValidator.Check(mission, answer)) return (false, 0, 0);

            using var conn = DBHelper.Getconnection();
            var tx = conn.BeginTransaction();
            try
            {
                //Upsert Progress
                var cmd = new SqlCommand(@"
                IF EXISTS(SELECT 1 FROM Progress WHERE UserID= @uid AND MissionID= @mid)
                UPDATE Progress SET Solved 1,SolvedAt=GETDATE()
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

                var cmd1 = new SqlCommand(@"
                UPDATE Users SET XP = XP +@xp , CryptCoin = CryptCoin +@c
                WHERE UserID = @uid
                ", conn, tx);
                cmd1.Parameters.AddWithValue("@xp", mission.XPReward);
                cmd1.Parameters.AddWithValue("@c", mission.CoinReward);
                cmd1.Parameters.AddWithValue("uid", userID);
                cmd1.ExecuteNonQuery();
                tx.Commit();
                RankService.UpdateRank(userID, SessionManager.CurrentUser.XP + mission.XPReward);
                SessionManager.RefreshUser();
                return (true, mission.XPReward, mission.CoinReward);
            }
            catch
            {
                tx.Rollback();
                return (false, 0, 0);
            }
        }
    }
}
