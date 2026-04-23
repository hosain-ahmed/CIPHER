using CIPHER.Forms.Agent;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Helpers
{
    public class CommandParser
    {
        private readonly AgentDashboard _dash;
        private readonly EconomyService _econ = new();

        public CommandParser(AgentDashboard dash) => _dash = dash;

        public string Execute(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return "";
            var parts = raw.Trim().Split(' ');
            return parts[0].ToLower() switch
            {
                "help" => Help(),
                "whoami" => WhoAmI(),
                "check_balance" => $"BALANCE: ₵{_econ.GetBalance(SessionManager.CurrentUser.UserID)}",
                "open_missions" => Nav("missions"),
                "open_bounties" => Nav("bounties"),
                "open_market" => Nav("market"),
                "leaderboard" => Nav("leaderboard"),
                "decrypt" => Decrypt(parts),
                "clear" => "CLEAR",
                _ => $"Unknown: '{parts[0]}'. Type 'help'."
            };
        }

        private string Help() => @"
COMMANDS:
  whoami              — agent profile summary
  check_balance       — Crypt-Coin balance
  open_missions       — Mission Board
  open_bounties       — Bounty Board
  open_market         — Black Market
  leaderboard         — rankings
  decrypt --caesar [text] --shift [n]
  clear               — clear terminal";

        private string WhoAmI()
        {
            var u = SessionManager.CurrentUser;
            return $"AGENT: {u.Codename}\nRANK:  {u.Rank}\nXP:    {u.XP}\nBAL:   ₵{u.CryptCoin}";
        }

        private string Nav(string section)
        {
            _dash.NavigateTo(section);
            return $"// Navigating to {section}...";
        }

        private string Decrypt(string[] parts)
        {
            try
            {
                int ci = Array.IndexOf(parts, "--caesar");
                int si = Array.IndexOf(parts, "--shift");
                if (ci < 0 || si < 0) return "Usage: decrypt --caesar [TEXT] --shift [N]";
                string text = parts[ci + 1].ToUpper();
                int shift = int.Parse(parts[si + 1]);
                string result = new string(text.Select(c =>
                    char.IsLetter(c)
                        ? (char)(((c - 'A' - shift + 26) % 26) + 'A')
                        : c).ToArray());
                return $"DECRYPTED: {result}";
            }
            catch { return "Parse error. Check syntax."; }
        }
    }
}
