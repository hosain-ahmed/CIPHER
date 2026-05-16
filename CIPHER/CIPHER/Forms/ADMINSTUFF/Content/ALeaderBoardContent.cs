using CIPHER.Forms.CustomItems;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.ADMINSTUFF.Content
{
    public partial class ALeaderBoardContent : UserControl
    {
        public ALeaderBoardContent()
        {
            InitializeComponent();
            LoadLeaderboard();
        }


        private void LoadLeaderboard()
        {
            flpLeaderboard.Controls.Clear();
            LeaderboardService lbService = new LeaderboardService();
            var rankings = lbService.GetRankings();

            lblPosition1.Text = lblName1.Text = lblXP1.Text = lblMissionSolved1.Text = lblBountiesCracked1.Text = "";
            lblPosition2.Text = lblName2.Text = lblXP2.Text = lblMissionSolved2.Text = lblBountiesCracked2.Text = "";
            lblPosition3.Text = lblName3.Text = lblXP3.Text = lblMissionSolved3.Text = lblBountiesCracked3.Text = "";
            foreach (var entry in rankings)
            {
                if (entry.Position == 1)
                {
                    lblPosition1.Text = entry.Position.ToString();
                    lblName1.Text = entry.Codename;
                    lblXP1.Text = entry.XP.ToString();
                    lblMissionSolved1.Text = entry.MissionsSolved.ToString();
                    lblBountiesCracked1.Text = entry.BountiesCracked.ToString();
                }

                else if (entry.Position == 2)
                {
                    lblPosition2.Text = entry.Position.ToString();
                    lblName2.Text = entry.Codename;
                    lblXP2.Text = entry.XP.ToString();
                    lblMissionSolved2.Text = entry.MissionsSolved.ToString();
                    lblBountiesCracked2.Text = entry.BountiesCracked.ToString();
                }
                else if (entry.Position == 3)
                {
                    lblPosition3.Text = entry.Position.ToString();
                    lblName3.Text = entry.Codename;
                    lblXP3.Text = entry.XP.ToString();
                    lblMissionSolved3.Text = entry.MissionsSolved.ToString();
                    lblBountiesCracked3.Text = entry.BountiesCracked.ToString();
                }
                else
                {
                    var row = new GenericRow();
                    row.SetData(entry.Position.ToString(), entry.Codename, entry.XP.ToString(), entry.MissionsSolved.ToString(), entry.BountiesCracked.ToString());
                    flpLeaderboard.Controls.Add(row);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            LoadLeaderboard();
        }
    }
}
