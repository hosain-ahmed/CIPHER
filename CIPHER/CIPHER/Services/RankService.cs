using CIPHER.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
   public static class RankService
    {
        public static string GetRank(int xp) => xp switch
        {
            < 200 => "Recruit",
            < 500 => "Operative",
            < 1000 => "Agent",
            < 2000 => "Phantom",
            _ => "Elite"
        };

        public static void UpdateRank(int userID, int xp)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(
                "UPDATE Users SET Rank= @r WHERE UserID = @id", conn);
            cmd.Parameters.AddWithValue("@r",GetRank(xp));
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.ExecuteNonQuery();
        }
    }
}
