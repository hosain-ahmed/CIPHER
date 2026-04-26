using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public class AuditService
    {
        public void Log(int userID, string eventType, string details)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            INSERT INTO AuditLog (UserID,EventType,Details)
            VALUES (@uid,@et,@d)", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.Parameters.AddWithValue("@et", eventType);
            cmd.Parameters.AddWithValue("@d", details);
            cmd.ExecuteNonQuery();
        }

        public List<LogEntry> GetMasterLogs(int userID)
        {
            try
            {
                int activeID = (userID <= 0) ? 1 : userID; //for now, we just return the first user's logs if an invalid ID is given. In a real app, you'd want to handle this more gracefully.

                var list = new List<LogEntry>();
                using var conn = DBHelper.Getconnection();

                // We 'normalize' the columns so they all have the same names (Category, Action, Details, Time)
                string query = @"
        SELECT '[SYS]' as Category, EventType as Action, Details, Timestamp 
        FROM AuditLog WHERE UserID = @uid
        UNION ALL
        SELECT '[ECO]' as Category, Type as Action, Description as Details, Timestamp 
        FROM Transactions WHERE UserID = @uid
        UNION ALL
        SELECT '[SEC]' as Category, 'FAILED_ATTEMPT' as Action, AttemptedAnswer as Details, AttemptedAt as Timestamp 
        FROM FailedAttempts WHERE UserID = @uid
        ORDER BY Timestamp DESC";

                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userID);

                using var r = cmd.ExecuteReader();
                while (r.Read()) // Remember: No '!' here!
                {
                    list.Add(new LogEntry
                    {
                        Category = r["Category"].ToString(),
                        Action = r["Action"].ToString(),
                        Details = r["Details"].ToString(),
                        Timestamp = (DateTime)r["Timestamp"]
                    });
                }
                return list;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"DATABASE ERROR: {ex.Message}\n\nStack: {ex.StackTrace}");
                return new List<LogEntry>(); // Return empty so the app doesn't close
            }
        }

        public List<AuditEntry> GetLog(string filter = null)
        {
            var list = new List<AuditEntry>();
            using var conn = DBHelper.Getconnection();
            string sql = @"
            SELECT a.*, u.Codename FROM AuditLog a
            JOIN Users u ON a.UserID = u.UserID
            ";
            if(filter!=null) sql += "WHERE a.EventType=@f";
            sql += " ORDER BY a.Timestamp DESC";
            var cmd = new SqlCommand(sql, conn);
            if (filter !=null) 
            {
                cmd.Parameters.AddWithValue("@f", filter);
            }
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(new AuditEntry
            {
                LogID = (int)r["LogID"],
                EventType = (string)r["EventType"],
                Details = r["Details"].ToString(),
                Timestamp = (DateTime)r["Timestamp"],
            });
            return list;
        }
    }

    public class IntrusionDetector
    {
        private readonly AuditService _audit = new();
        public void logAttempt(int userID, int? missionID, string answer)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            INSERT INTO FailedAttempts (UserID, MissionID, AttemptedAnswer)
            VALUES (@uid, @mid, @ans)", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.Parameters.AddWithValue("mid", (object)missionID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ans", answer);
            cmd.ExecuteNonQuery();
            _audit.Log(userID, "FailedAttempt", $"Answer tried: {answer}");

        }

        public bool isRateLimited (int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"SELECT COUNT(*) FROM FailedAttempts WHERE UserID =@uid
                                       AND AttemptedAt > DATEADD(SECOND,-10,GETDATE()) ", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            return (int)cmd.ExecuteScalar() >= 5;
        }

        public void LockAccount(int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("UPDATE Users SET AccountStatus='Locked' WHERE UserID = @uid", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.ExecuteNonQuery();
            if (SessionManager.CurrentUser?.UserID == userID)
                SessionManager.CurrentUser.AccountStatus = "Locked";
            _audit.Log(userID, "AccountLocked", "Rate Limit Exceeded");
        }

        public void ScheduleUnlock(int userID, Action onUnlocked)
        {
            new System.Threading.Timer(_ =>
            {
                using var conn = DBHelper.Getconnection();
                var cmd = new SqlCommand("UPDATE Users SET AccountStatus ='Active' WHERE UserID = @uid", conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.ExecuteNonQuery();
                _audit.Log(userID, "AccountUnlocked", "Scheduled Unlock");
                onUnlocked?.Invoke();
            }, null, 30000, Timeout.Infinite);
        }
    }
}
