using CIPHER.Helpers;
using CIPHER.Models;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Content
{
    public partial class PoPMissionSolve : Form
    {
        Mission cM = new Mission();
        public PoPMissionSolve(Mission m)
        {
            InitializeComponent();
            cM = m;
            lblTitle.Text = m.Title;

            lblcReward.Text = m.CoinReward.ToString();
            lblMissionID.Text = m.MissionID.ToString();
            MessageBox.Show("MissionID: " + m.MissionID, "Debug");
            lblXP.Text = m.XPReward.ToString();
            rtbQuestion.Text = m.Briefing;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var missionService = new MissionService();
            var (correct, xp, coin) = missionService.SubmitAnswer(SessionManager.CurrentUser.UserID, cM.MissionID, rtbAnswer.Text.Trim());
            if (correct)
            {

                MessageBox.Show("Correct! You've completed the mission.", "Mission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.", "Mission Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
