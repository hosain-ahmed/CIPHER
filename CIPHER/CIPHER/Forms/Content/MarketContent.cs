using CIPHER.Forms.CustomItems;
using CIPHER.Helpers;
using CIPHER.Models;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Content
{
    public partial class MarketContent : UserControl
    {
        BountyService bountyService = new BountyService();
        private List<Bounty> _allOpenBounties;
        public MarketContent()
        {
            InitializeComponent();



            this.BackColor = Theme.BackgroundMain;

            LoadBounties();

        }



        public void LoadBounties()
        {
            var Bounties = bountyService.GetOpenBounties(SessionManager.CurrentUser.UserID);
            _allOpenBounties = Bounties; 
            


            flowLayoutPanel1.Controls.Clear();


            foreach (var item in Bounties)
            {
                GenericRow row = new GenericRow();
                row.Width = flowLayoutPanel1.ClientSize.Width - 10;
                row.Height = 45;

                row.DataReference = item; // Store the actual Bounty object here
                row.SetData(item.BountyID.ToString(), item.Title, "", item.CoinReward.ToString(), item.Status);

                // Subscribe to the click event
                row.OnRowClicked += (s, data) =>
                {
                    // Cast the 'data' back to a Bounty object
                    var selectedBounty = (Bounty)data;

                    // Open your new window
                    using (var detailWindow = new PoPBountySolve(selectedBounty))
                    {
                        detailWindow.ShowDialog(); // ShowDialog blocks the main window until closed
                    }
                };

                flowLayoutPanel1.Controls.Add(row);
            }

            flowLayoutPanel1.Refresh(); // Force the panel to redraw
        }

     


        public void LoadView(UserControl view)
        {
            if (pnlHolder.Controls.Count > 0)
            {
                pnlHolder.Controls[0].Dispose();
            }
            pnlHolder.Controls.Clear();

            view.Dock = DockStyle.Fill;
            pnlHolder.Controls.Add(view);
        }

        private void btnBountyShow_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Visible = true;
            LoadBounties();
        }

        private void btnExtraFeaturesShow_Click(object sender, EventArgs e)
        {
            ExtraFeatures ef = new ExtraFeatures();
            ef.Show();

        }

   

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var win = new GenericCreatorWindow();
            win.SetupMode(CreationModeEnum.Bounty);
            win.Show();
        }

        private void btnHitlistShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitlist Coming Soon!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
