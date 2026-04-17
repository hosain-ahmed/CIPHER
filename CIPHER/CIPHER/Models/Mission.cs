using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class Mission
    {
        public int MissionID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Briefing { get; set; }
        public string Answer { get; set; }
        public string Hint { get; set; }
        public int XPReward { get; set; }
        public int CoinReward { get; set; }
        public int OrderIndex { get; set; }

    }
}
