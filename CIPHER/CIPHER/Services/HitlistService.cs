using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public class HitlistService
    {
        private readonly EconomyService _econ = new();
        private readonly AuditService _audit = new();

        // Place a hit on a target
        public (bool success, string error) PlaceHit(
            int attackerID, int targetID, int durationMinutes)
        {

            // Can't hit yourself
            if (attackerID == targetID)
                return (false, "Cannot place a hit on yourself.");

            // Check no active hit already exists on this target
            using var conn = DBHelper.Getconnection();
            var existCheck = new SqlCommand(@"
            SELECT COUNT(*) FROM Hitlist 
            WHERE TargetID=@tid AND Status='Active'", conn);
            existCheck.Parameters.AddWithValue("@tid", targetID);
            if ((int)existCheck.ExecuteScalar() > 0)
                return (false, "Target already has an active contract.");

            // Get target XP to calculate cost and difficulty
            var targetCmd = new SqlCommand(
                "SELECT XP FROM Users WHERE UserID=@id", conn);
            targetCmd.Parameters.AddWithValue("@id", targetID);
            int targetXP = (int)targetCmd.ExecuteScalar();

            // Cost scales with target XP
            int hitCost = 50 + (targetXP / 10);

            // Deduct coins from attacker
            var (ok, err) = _econ.DeductCoin(
                attackerID, hitCost, $"Hit contract on UserID {targetID}");
            if (!ok) return (false, err);

            // Create the hit
            var tx2 = conn.BeginTransaction();
            try
            {
                var insertHit = new SqlCommand(@"
                INSERT INTO Hitlist 
                (AttackerID, TargetID, CoinsStaked, ExpiresAt)
                OUTPUT INSERTED.HitID
                VALUES (@aid, @tid, @cost, 
                        DATEADD(MINUTE, @dur, GETDATE()))",
                    conn, tx2);
                insertHit.Parameters.AddWithValue("@aid", attackerID);
                insertHit.Parameters.AddWithValue("@tid", targetID);
                insertHit.Parameters.AddWithValue("@cost", hitCost);
                insertHit.Parameters.AddWithValue("@dur", durationMinutes);
                int hitID = (int)insertHit.ExecuteScalar();

                // Generate 3 random contract challenges based on target XP
                string difficulty = targetXP switch
                {
                    < 200 => "Easy",
                    < 1000 => "Medium",
                    _ => "Hard"
                };

                var missionsCmd = new SqlCommand(@"
                SELECT TOP 3 MissionID FROM Missions 
                WHERE Difficulty=@d 
                ORDER BY NEWID()", conn, tx2);
                missionsCmd.Parameters.AddWithValue("@d", difficulty);
                using var r = missionsCmd.ExecuteReader();
                var missionIDs = new List<int>();
                while (r.Read())
                    missionIDs.Add((int)r["MissionID"]);
                r.Close();

                foreach (var mid in missionIDs)
                {
                    new SqlCommand(@"
                    INSERT INTO HitChallenges (HitID, MissionID)
                    VALUES (@hid, @mid)", conn, tx2)
                    {
                        Parameters = {
                        new("@hid", hitID),
                        new("@mid", mid)
                    }
                    }.ExecuteNonQuery();
                }

                tx2.Commit();
                _audit.Log(attackerID, "HitPlaced",
                    $"Hit on UserID {targetID}, Cost: {hitCost}");
                return (true, null);

            }
            catch
            {
                tx2.Rollback();
                return (false, "Failed to create contract.");
            }
        }

        // Get active hit for current attacker
        public HitList GetMyActiveHit(int attackerID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT h.*, u.Codename as TargetCodename
            FROM Hitlist h
            JOIN Users u ON h.TargetID = u.UserID
            WHERE h.AttackerID=@aid 
            AND h.Status='Active'
            AND h.ExpiresAt > GETDATE()", conn);
            cmd.Parameters.AddWithValue("@aid", attackerID);
            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;
            return new HitList
            {
                HitID = (int)r["HitID"],
                AttackerID = (int)r["AttackerID"],
                TargetID = (int)r["TargetID"],
                TargetCodename = r["TargetCodename"].ToString(),
                CoinsStaked = (int)r["CoinsStaked"],
                Status = r["Status"].ToString(),
                ExpiresAt = (DateTime)r["ExpiresAt"],
                ExecutedAt = r["ExecutedAt"] as DateTime?
            };
        }

        // Get challenges for a hit
        public List<HitChallenge> GetChallenges(int hitID)
        {
            var list = new List<HitChallenge>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT hc.*, m.Title, m.Briefing, 
                   m.Answer, m.Category
            FROM HitChallenges hc
            JOIN Missions m ON hc.MissionID = m.MissionID
            WHERE hc.HitID=@hid", conn);
            cmd.Parameters.AddWithValue("@hid", hitID);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(new HitChallenge
            {
                ChallengeID = (int)r["ChallengeID"],
                HitID = (int)r["HitID"],
                MissionID = (int)r["MissionID"],
                Title = r["Title"].ToString(),
                Briefing = r["Briefing"].ToString(),
                Answer = r["Answer"].ToString(),
                Category = r["Category"].ToString(),
                Solved = (bool)r["Solved"]
            });
            return list;
        }

        // Submit answer for a hit challenge
        public (bool correct, bool allSolved) SubmitChallengeAnswer(
            int challengeID, int hitID, string answer)
        {

            using var conn = DBHelper.Getconnection();

            // Get the answer
            var getCmd = new SqlCommand(
                "SELECT Answer FROM Missions m " +
                "JOIN HitChallenges hc ON m.MissionID=hc.MissionID " +
                "WHERE hc.ChallengeID=@cid", conn);
            getCmd.Parameters.AddWithValue("@cid", challengeID);
            string correctAnswer = getCmd.ExecuteScalar()?.ToString();

            if (!string.Equals(correctAnswer, answer,
                StringComparison.OrdinalIgnoreCase))
                return (false, false);

            // Mark challenge solved
            new SqlCommand(
                "UPDATE HitChallenges SET Solved=1 WHERE ChallengeID=@cid",
                conn)
            {
                Parameters = { new("@cid", challengeID) }
            }.ExecuteNonQuery();

            // Check if ALL challenges solved
            var allCmd = new SqlCommand(@"
            SELECT COUNT(*) FROM HitChallenges 
            WHERE HitID=@hid AND Solved=0", conn);
            allCmd.Parameters.AddWithValue("@hid", hitID);
            bool allSolved = (int)allCmd.ExecuteScalar() == 0;

            return (true, allSolved);
        }

        // Execute the hit — lock target
        public (bool success, string msg) ExecuteHit(int hitID)
        {
            using var conn = DBHelper.Getconnection();

            // Get hit details
            var getCmd = new SqlCommand(
                "SELECT * FROM Hitlist WHERE HitID=@id", conn);
            getCmd.Parameters.AddWithValue("@id", hitID);
            HitList hit;
            using (var r = getCmd.ExecuteReader())
            {
                if (!r.Read()) return (false, "Hit not found.");
                hit = new HitList
                {
                    HitID = (int)r["HitID"],
                    AttackerID = (int)r["AttackerID"],
                    TargetID = (int)r["TargetID"],
                    CoinsStaked = (int)r["CoinsStaked"],
                    ExpiresAt = (DateTime)r["ExpiresAt"]
                };
            }

            // Check not expired
            if (DateTime.Now > hit.ExpiresAt)
                return (false, "Contract expired.");

            var tx = conn.BeginTransaction();
            try
            {
                // Lock target
                new SqlCommand(
                    "UPDATE Users SET AccountStatus='Locked' " +
                    "WHERE UserID=@tid", conn, tx)
                {
                    Parameters = { new("@tid", hit.TargetID) }
                }.ExecuteNonQuery();

                // Update hit status
                new SqlCommand(
                    "UPDATE Hitlist SET Status='Executed', " +
                    "ExecutedAt=GETDATE() WHERE HitID=@hid", conn, tx)
                {
                    Parameters = { new("@hid", hitID) }
                }.ExecuteNonQuery();

                // Reward attacker +50 XP
                new SqlCommand(
                    "UPDATE Users SET XP=XP+50 WHERE UserID=@aid",
                    conn, tx)
                {
                    Parameters = { new("@aid", hit.AttackerID) }
                }.ExecuteNonQuery();

                tx.Commit();

                // Schedule unlock after 5 minutes
                ScheduleTargetUnlock(hit.TargetID, hit.HitID);

                _audit.Log(hit.AttackerID, "HitExecuted",
                    $"Target UserID {hit.TargetID} locked");
                _audit.Log(hit.TargetID, "AccountLocked",
                    "Locked by Hitlist execution");

                return (true, "TARGET NEUTRALIZED. +50 XP AWARDED.");

            }
            catch
            {
                tx.Rollback();
                return (false, "Execution failed.");
            }
        }

        // Auto unlock target after 5 minutes
        private void ScheduleTargetUnlock(int targetID, int hitID)
        {
            new System.Threading.Timer(_ => {
                using var conn = DBHelper.Getconnection();
                new SqlCommand(
                    "UPDATE Users SET AccountStatus='Active' " +
                    "WHERE UserID=@id", conn)
                {
                    Parameters = { new("@id", targetID) }
                }.ExecuteNonQuery();
                _audit.Log(targetID, "AccountUnlocked",
                    "Hit lockout expired — auto unlocked");
            }, null, 300000, Timeout.Infinite); // 5 minutes
        }

        // Get all agents to browse for hitting
        public List<User> GetTargetableAgents(int attackerID)
        {
            var list = new List<User>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT UserID, Codename, XP, Rank, FactionID
            FROM Users 
            WHERE Role='Agent' 
            AND UserID != @aid
            AND AccountStatus = 'Active'
            ORDER BY XP DESC", conn);
            cmd.Parameters.AddWithValue("@aid", attackerID);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(new User
            {
                UserID = (int)r["UserID"],
                Codename = r["Codename"].ToString(),
                XP = (int)r["XP"],
                Rank = r["Rank"].ToString()
            });
            return list;
        }
    }
}
