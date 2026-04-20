using BCrypt.Net;
using CIPHER.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public class AuthService
    {
        public (bool success, string error) Register(string codename, string fullName, string email, string password, int factionID) 
        { 
            using var conn = DBHelper.Getconnection();
            var check = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Codename = @c OR Email = @e", conn);
            check.Parameters.AddWithValue("@c", codename);
            check.Parameters.AddWithValue("@e", email);
            if((int)check.ExecuteScalar() > 0)
            {
                return (false, "Codename or email already exists.");
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            var cmd = new SqlCommand(
                @"INSERT INTO Users(Codename,FullName,Email,PasswordHash,FactionID) VALUES (@c,@fn,@e,@h,@f)",conn);
            cmd.Parameters.AddWithValue("@c", codename);
            cmd.Parameters.AddWithValue("@fn", fullName);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@h", hash);
            cmd.Parameters.AddWithValue("@f", factionID);
            cmd.ExecuteNonQuery();
            return (true, null);
        }

        public(bool success, Models.User user, string error) Login(string codename, string password)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT * FROM Users WHERE Codename=@c", conn);
            cmd.Parameters.AddWithValue("@c", codename);
            using var r = cmd.ExecuteReader();
            if(!r.Read())
            {
                return (false, null, "Agent Not Found.");
            }

            var user = new Models.User
            {
                UserID = (int)r["UserID"],
                Codename = r["Codename"].ToString(),
                FullName = r["FullName"].ToString(),
                Email = r["Email"].ToString(),
                PasswordHash = r["PasswordHash"].ToString(),
                Role = r["Role"].ToString(),
                XP = (int)r["XP"],
                CryptCoin = (int)r["CryptCoin"],
                Rank = r["Rank"].ToString(),
                FactionID = (int)r["FactionID"],
                AccountStatus = r["AccountStatus"].ToString()
            };

            if(user.AccountStatus == "Locked")
            {
                return (false, null, "Account is Locked, Wait 30 seconds");
            }
            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return (false, null, "Incorrect Password");
            }

            SessionManager.Login(user);
            return (true, user, null);
        }

        public List<(int ID, string Name)> GetFactions()
        {
            var list = new List<(int, string)>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT FactionID, Name FROM Factions", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(((int)r["FactionID"], r["Name"].ToString()));
            return list;
        }


    }
}
