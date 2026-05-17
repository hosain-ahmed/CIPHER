using System;
using System.Collections.Generic;
using System.Text;
using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;

namespace CIPHER.Services
{
    public class BountyService
    {
        public List<Bounty> GetOpenBounties(int currentUserID)
        {
            var list = new List<Bounty>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
        SELECT b.*, u.CodeName as CreatorCodename 
        FROM Bounties b 
        JOIN Users u on b.CreatorID=u.UserID
        WHERE b.Status='Open' AND b.CreatorID <> @uid
        ORDER BY b.CreatedAt DESC", conn);
            cmd.Parameters.AddWithValue("@uid", currentUserID);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                try
                {
                    list.Add(MapBounty(r));
                }
                catch (Exception ex)
                {
                    throw new Exception($"BountyID={r["BountyID"]}, CoinReward={r["CoinReward"]}, Status={r["Status"]}, Error={ex.Message}");
                }
            }
            return list;
        }

        public List<Bounty> GetAllBounties()
        {
            var list = new List<Bounty>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
        SELECT b.*, u.CodeName as CreatorCodename
        FROM Bounties b
        JOIN Users u on b.CreatorID = u.UserID
        ORDER BY b.CreatedAt DESC", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                try
                {
                    list.Add(MapBounty(r));
                }
                catch (Exception ex)
                {
                    // Add a breakpoint here or show which row fails
                    MessageBox.Show($"Row failed: BountyID={r["BountyID"]}, Error={ex.Message}");
                }
            }
            return list;
        }

        public List<Bounty> GetMyBounties(int userID)
        {
            var list = new List<Bounty>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT b.*, u.CodeName as CreatorCodeName
            FROM Bounties b
            JOIN Users u on b.CreatorID = u.UserID
            WHERE b.CreatorID =@uid or b.SolverID= @uid
            ORDER BY b.CreatedAt DESC", conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(MapBounty(r));
            return list;
        }

        public (bool success, string error) PostBounty(
    int CreatorID, string title, string message, string answer, int reward)
        {

            using var conn = DBHelper.Getconnection();
            try
            {
                var cmd = new SqlCommand(@"
            INSERT INTO Bounties
            (CreatorID,Title,EncryptedMessage,Answer,CoinReward,Status)
            VALUES(@cid,@t,@EM,@a,@cr,'Open')", conn);
                cmd.Parameters.AddWithValue("@cid", CreatorID);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@EM", message);
                cmd.Parameters.AddWithValue("@a", answer);
                cmd.Parameters.AddWithValue("@cr", reward);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"INSERT failed: {ex.Message} | CreatorID={CreatorID}, Title={title}, Reward={reward}");
            }

            var (ok, err) = new EconomyService().DeductCoin(
                CreatorID, reward, "Bounty escrow posted");
            if (!ok) return (false, err);

            return (true, null);
        }

        public bool AcceptBounty(int bountyID,int solverID)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            UPDATE Bounties SET Status = 'Accepted' , SolverID = @sid
            WHERE BountyID = @bid AND Status = 'Open'", conn);
            cmd.Parameters.AddWithValue("@sid", solverID);
            cmd.Parameters.AddWithValue("@bid", bountyID);
            return cmd.ExecuteNonQuery()>0; //why this
        }

        private Bounty MapBounty(SqlDataReader r) => new Bounty
        {
            BountyID = (int)r["BountyID"],
            CreatorID = (int)r["CreatorID"],
            SolverID = r["SolverID"] == DBNull.Value ? (int?)null : (int)r["SolverID"],
            Title = r["Title"].ToString(),
            EncryptedMessage = r["EncryptedMessage"].ToString(),
            Answer = r["Answer"].ToString(),
            CoinReward = r["CoinReward"] == DBNull.Value ? 0 : (int)r["CoinReward"],
            Status = r["Status"] == DBNull.Value ? "Open" : r["Status"].ToString(),
            CreatorCodename = r["CreatorCodename"]?.ToString()
        };

        public (bool success, string msg)SolveBouny(int bountyID,int solverID,string answer)
        {
            Bounty bounty;
            using (var conn = DBHelper.Getconnection()) 
            {
                var cmd = new SqlCommand("SELECT * FROM Bounties WHERE BountyID = @bid", conn);
                cmd.Parameters.AddWithValue("@bid", bountyID);
                var r = cmd.ExecuteReader();
                while (!r.Read()) return (false, "Bounty not found");
                bounty = MapBounty(r);
            }

            if (!string.Equals(bounty.Answer, answer, StringComparison.OrdinalIgnoreCase)) return (false, "Incorrect Answer.");

            using var conn2 = DBHelper.Getconnection();
            var tx = conn2.BeginTransaction();
            try
            {
                new EconomyService().AddCoin(solverID, bounty.CoinReward, $"Bounty solved: {bounty.Title}", conn2, tx);

                var cmd2 = new SqlCommand(@"
                UPDATE Bounties SET Status = 'Solved'
                ,SolvedAt=GETDATE() WHERE BountyID = @bid
                ", conn2, tx);
                cmd2.Parameters.AddWithValue("@bid", bountyID);
                cmd2.ExecuteNonQuery();

                tx.Commit();
                SessionManager.RefreshUser();
                new AuditService().Log(solverID, "BountySolved", $"Bounty #{bountyID}: {bounty.Title}");
                return(true, $"BOUNTY CRACKED. +₵{bounty.CoinReward} credited.");
            }
            catch
            {
                tx.Rollback();
                return (false, "Transaction failed. Try again.");
            }
        }
    }
}
