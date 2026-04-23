using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class AdminStats
    {
        public int TotalAgents { get; set; }
        public int MissionsSolvedToday { get; set; }
        public string TopAgentCodename { get; set; }
        public string MostFailedMission { get; set; }
        public int ActiveBounties { get; set; }
    }
}
