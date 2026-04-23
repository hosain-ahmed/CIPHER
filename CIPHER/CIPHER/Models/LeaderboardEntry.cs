using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class LeaderboardEntry
    {
        public int Position { get; set; }
        public string Codename { get; set; }
        public int XP { get; set; }
        public string Rank { get; set; }
        public string Faction { get; set; }
        public int MissionsSolved { get; set; }
        public int BountiesCracked { get; set; }
    }
}
