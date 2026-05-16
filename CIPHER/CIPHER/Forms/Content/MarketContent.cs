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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnHint_Click(object sender, EventArgs e)
        {

        }

        private void btnHint_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnHint_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnHint_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnBounty_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnBounty_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnBounty_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblMarketTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
