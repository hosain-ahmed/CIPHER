using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public class EconomyService
    {
        public int GetBalance(int userID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT CryptCoin FROM Users WHERE UserID=@id", conn);
            cmd.Parameters.AddWithValue("@id", userID);
            return (int)cmd.ExecuteScalar();
        }

        public (bool success, string error) DeductCoin(int userID, int amount, string description, int? relatedID = null)
        {
            using var conn = DBHelper.Getconnection();
            var tx = conn.BeginTransaction();
            try
            {
                var balcmd = new SqlCommand("SELECT CryptCoin FROM Users WHERE UserID= @id", conn, tx);
                balcmd.Parameters.AddWithValue("@id", userID);
                int bal = (int)balcmd.ExecuteScalar();
                if ((bal < amount))
                {
                    throw new Exception("Insufficient Funds.");
                }
                var deduct = new SqlCommand("UPDATE Users SET CryptCoin = CryptCoin-@a WHERE UserID = @id", conn, tx);
                deduct.Parameters.AddWithValue("@a", amount);
                deduct.Parameters.AddWithValue("@id", userID);
                deduct.ExecuteNonQuery();

                WriteTransaction(userID, "Debit", amount, description, relatedID, conn, tx);

                tx.Commit();
                SessionManager.RefreshUser();
                return (true, null);
            }
            catch (Exception ex)
            {
                tx.Rollback();
                return (false, ex.Message);
            }
        }

        public void AddCoin(int userID, int amount, string description, SqlConnection conn, SqlTransaction tx)
        {
            var cmd = new SqlCommand("UPDATE Users SET CryptCoin=CryptCoin+@a WHERE UserID=@id", conn, tx);
            cmd.Parameters.AddWithValue("@a", amount);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.ExecuteNonQuery();
            WriteTransaction(userID, "Credit", amount, description, null, conn, tx);
        }

        public List<Transaction> GetTransactions(int userID)
        {
            var list = new List<Transaction>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT * FROM Transactions WHERE UserID=@uid
            ORDER BY Timestamp DESC", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(new Transaction
            {
                TransactionID = (int)r["TxID"],
                Type = r["Type"].ToString(),
                Amount = (int)r["Amount"],
                Description = r["Description"].ToString(),
                Timestamp = (DateTime)r["Timestamp"]
            });
            return list;
        }

        private void WriteTransaction(int userID, string type, int amount,
        string desc, int? relatedID,
        SqlConnection conn, SqlTransaction tx)
        {
            var cmd = new SqlCommand(@"
            INSERT INTO Transactions (UserID,Type,Amount,Description,RelatedID)
            VALUES (@uid,@t,@a,@d,@rid)", conn, tx);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.Parameters.AddWithValue("@t", type);
            cmd.Parameters.AddWithValue("@a", amount);
            cmd.Parameters.AddWithValue("@d", desc);
            cmd.Parameters.AddWithValue("@rid", (object)relatedID ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }
    }
}
