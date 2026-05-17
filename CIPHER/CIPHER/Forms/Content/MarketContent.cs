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

        public MarketContent()
        {
            InitializeComponent();
            LoadBounties();


            this.BackColor = Theme.BackgroundMain;

        }

        private void ShowSection(string section)
        {
            // Hide everything first
            flowLayoutPanel1.Visible = false;
            pnlHolder.Visible = false;

            switch (section)
            {
                case "bounties":
                    flowLayoutPanel1.Visible = true;
                    LoadBounties();
                    break;
                case "hitlist":
                    flowLayoutPanel1.Visible = true;
                    LoadHitlist();
                    break;
                case "items":
                    pnlHolder.Visible = true;
                    break;
            }
        }

        public void LoadBounties()
        {
            var Bounties = bountyService.GetAllBounties();



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

        public void LoadHitlist()
        {

        }


        public void LoadExtras()
        {

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
            ShowSection("bounties");
        }

        private void btnExtraFeaturesShow_Click(object sender, EventArgs e)
        {
            ShowSection("items");
        }
    }
}
