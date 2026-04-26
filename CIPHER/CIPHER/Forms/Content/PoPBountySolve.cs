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
    public partial class PoPBountySolve : Form
    {
        Bounty cB = new Bounty();
        public PoPBountySolve(Bounty b)
        {
            InitializeComponent();
            cB = b;
            lblTitle.Text = b.Title;
            
            lblcReward.Text = b.CoinReward.ToString();
            lblMissionID.Text = b.BountyID.ToString();
            //lblXP.Text = b.XPReward.ToString();
            rtbQuestion.Text = b.EncryptedMessage;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rtbAnswer.Text.Trim() == cB.Answer.Trim())
            {
                MessageBox.Show("Correct! You've completed the bounty.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.");
            }
        }
    }
}
