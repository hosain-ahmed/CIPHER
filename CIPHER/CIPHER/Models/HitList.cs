using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class HitList
    {
        public int HitID { get; set; }
        public int AttackerID { get; set; }
        public int TargetID { get; set; }
        public string TargetCodename { get; set; }
        public int CoinsStaked { get; set; }
        public string Status { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime? ExecutedAt { get; set; }
        public string AttackerCodename { get; set; }
    }

}

