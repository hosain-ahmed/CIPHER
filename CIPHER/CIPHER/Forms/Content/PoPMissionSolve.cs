using CIPHER.Models;
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
            lblXP.Text = m.XPReward.ToString();
            rtbQuestion.Text = m.Briefing;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rtbAnswer.Text.Trim() == cM.Answer.Trim())
            {
                MessageBox.Show("Correct! You've completed the mission.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.");
            }
        }
    }
}
