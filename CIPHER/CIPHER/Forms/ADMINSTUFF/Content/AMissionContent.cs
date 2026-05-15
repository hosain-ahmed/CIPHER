using CIPHER.Forms.CustomItems;
using CIPHER.Models;
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
    public partial class AMissionContent : UserControl
    {
        private MissionService missionService = new MissionService();
        public AMissionContent()
        {
            InitializeComponent();
            loadRows();
        }

        private void loadRows()
        {
            var mission = missionService.GetAllMissions();
            flowLayoutPanel1.SuspendLayout();

            for (int i = 0; i < mission.Count; i++)
            {
                var row = new CustomItems.GenericRow();
                row.SetData(mission[i].MissionID.ToString(), mission[i].Title, mission[i].Difficulty, mission[i].CoinReward.ToString(),"");
                flowLayoutPanel1.Controls.Add(row);
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            var win = new GenericCreatorWindow("Create Mission");

            win.OnDataSubmitted = (title, diff, cat, coin, xp, brief, ans, hint) => {
                Mission m = new Mission
                {
                    Title = title,
                    Difficulty = diff,
                    Category = cat,
                    CoinReward = coin,
                    XPReward = xp,
                    Briefing = brief,
                    Answer = ans,
                    Hint = hint
                };
                new AdminService().CreateMission(m);
                MessageBox.Show("Mission Saved!");
            };

            win.Show();
        }
    }
}
