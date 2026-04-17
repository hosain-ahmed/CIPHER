using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
   public class Bounty
    {
        public int BountyID { get; set; }
        public int CreatorID { get; set; }
        public int SolverID { get; set; }
        public string CreatorCodename { get; set; }
        public string Title { get; set; }
        public string EncryptedMessage { get; set; }
        public string Answer { get; set; }
        public int CoinReward { get; set; }
        public string Status { get; set; }
    }
}
