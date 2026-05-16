using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class HitChallenge
    {
        public int ChallengeID { get; set; }
        public int HitID { get; set; }
        public int MissionID { get; set; }
        public string Title { get; set; }
        public string Briefing { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public bool Solved { get; set; }
    }
}
