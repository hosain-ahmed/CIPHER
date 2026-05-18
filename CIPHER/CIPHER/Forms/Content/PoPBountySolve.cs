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
            var bountyService = new BountyService();
            var(correct,msg) = bountyService.SolveBounty(cB.BountyID, SessionManager.CurrentUser.UserID, rtbAnswer.Text.Trim());

            if (correct)
            {
                MessageBox.Show(msg);
                this.Close();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
