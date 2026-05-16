using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Services
{
    public class LeaderboardService
    {
        public List<LeaderboardEntry> GetRankings()
        {
            var list = new List<LeaderboardEntry>();
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT u.Codename, u.XP, u.Rank, f.Name AS Faction, 
    COUNT(DISTINCT p.MissionID) AS MissionsSolved,
    COUNT(DISTINCT b.BountyID) AS BountiesSolved
FROM Users u
LEFT JOIN Factions f ON u.FactionID = f.FactionID
LEFT JOIN Progress p ON u.UserID = p.UserID AND p.Solved = 1
LEFT JOIN Bounties b ON u.UserID = b.SolverID
WHERE u.Role = 'Agent'
GROUP BY u.UserID, u.Codename, u.XP, u.Rank, f.Name
ORDER BY u.XP DESC, MissionsSolved DESC, BountiesSolved DESC;
            
            ", conn);
            using var r = cmd.ExecuteReader();
            int position = 1;
            while (r.Read()) list.Add(new LeaderboardEntry
            {
                Position = position++,
                Codename = r["Codename"].ToString(),
                XP = (int)r["XP"],
                Rank = r["Rank"].ToString(),
                Faction = r["Faction"].ToString(),
                MissionsSolved = (int)r["MissionsSolved"],
                BountiesCracked = (int)r["BountiesSolved"]
            });
            return list;
        }
    }
}
