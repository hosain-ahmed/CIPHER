using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Codename { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public string Role { get; set; }

        public int XP { get; set; }
        public int CryptCoin { get; set; }
        public string Rank { get; set; }
        public int FactionID { get; set; }
        public string AccountStatus { get; set; }

    }
}
