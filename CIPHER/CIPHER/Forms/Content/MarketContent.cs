using CIPHER.Forms.CustomItems;
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
            
        }

        public void LoadBounties()
        {
            var Bounties = bountyService.GetAllBounties();

        

            flowLayoutPanel1.Controls.Clear();


            foreach (var item in Bounties)
            {
                GenericRow row = new GenericRow();
                row.DataReference = item; // Store the actual Bounty object here
                row.SetData(item.BountyID.ToString(), item.Title, item.CoinReward.ToString(), item.Status);

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
    }
}
