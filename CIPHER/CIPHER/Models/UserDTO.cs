using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CIPHER.Models
{
    public class UserDTO
    {
        // --- VISIBLE COLUMNS ---
        [DisplayName("CODENAME")]
        public string Codename { get; set; }

        [DisplayName("ROLE")]
        public string Role { get; set; }

        [DisplayName("STATUS")]
        public string Status { get; set; }

        [DisplayName("RANK")]
        public string Rank { get; set; }

        [DisplayName("XP_QUOTA")]
        public int XpQuota { get; set; }


        // --- HIDDEN DATA (For the Right Panel only) ---
        [Browsable(false)]
        public string FullName { get; set; }

        [Browsable(false)]
        public string Email { get; set; }

        [Browsable(false)]
        public int CryptCoin { get; set; }

        [Browsable(false)]
        public string UserID { get; set; }

        [Browsable(false)]
        public int FactionID { get; set; }
    }
}
