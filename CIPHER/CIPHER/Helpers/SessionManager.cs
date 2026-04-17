using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;
using CIPHER.Models;

namespace CIPHER.Helpers
{
    public static class SessionManager
    {
        public static Models.User CurrentUser { get; private set; }
        public static bool isAdmin => CurrentUser?.Role == "Admin";
        public static void Login(Models.User u) => CurrentUser = u;
        public static void Logout() => CurrentUser = null;

        public static void RefreshUser()
        {
            if (CurrentUser == null) return;
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT XP, CryptCoin, Rank, AccountStatus FROM Users WHERE UserID=@id", conn);
            cmd.Parameters.AddWithValue("@id", CurrentUser.UserID);
            using var r = cmd.ExecuteReader();
            if (!r.Read()) return;
            CurrentUser.XP = (int)r["XP"];
            CurrentUser.CryptCoin = (int)r["CryptCoin"];
            CurrentUser.Rank = r["Rank"].ToString();
            CurrentUser.AccountStatus = r["AccountStatus"].ToString();
        }
    }
}
