
using CIPHER.Forms.CustomItems;
using CIPHER.Helpers;
using CIPHER.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Content
{
    public partial class MissionContent : UserControl
    {
        MissionService MissionService = new MissionService(); // Assuming MissionService is a class that retrieves missions
        BountyService bountyService = new BountyService();
        public MissionContent()
        {
            InitializeComponent();
            LoadMissions();
            JustDoinSomething();
        }

        public void LoadMissions()
        {
            flowLayoutPanel1.Controls.Clear();
            var missions = MissionService.GetMissionForAgent(SessionManager.CurrentUser.UserID);
            //var missions = bountyService.GetAllBounties(); // Replace with your actual method to get missions
            // If you don't see this popup, the method isn't running!

            foreach (var m in missions)
            {
                MissionCard card = new MissionCard();

                // 1. Give the card the "Whole Soul" of the mission
                card.MissionData = m;

                // 2. Map the UI (You can keep your existing mapping or 
                // move this inside a 'card.LoadData()' method later)
                card.MissionTitle = m.Title;
                card.MissionID = "ID: " + m.MissionID.ToString();
                card.MissionDescription = m.Briefing;
                //card.MissionStatus = m.Status; // Make sure your card has this property!
                card.MissionReward = m.CoinReward.ToString() + " CR";
                card.MissionDifficulty = m.Difficulty;

                // Use your theme color here!
                // card.AccentColor = Color.FromArgb(0, 245, 255); // Neon Cyan

                // 3. Add to the panel
                flowLayoutPanel1.Controls.Add(card);



            }
        }

        private void JustDoinSomething()
        {
            using var conn = DBHelper.Getconnection();

            var cmdTotal = new SqlCommand(@"SELECT COUNT(*) FROM Missions", conn);
            int total = (int)cmdTotal.ExecuteScalar();

            var cmdSolved = new SqlCommand(@"SELECT COUNT(*) FROM Progress WHERE UserID = @uid AND Solved =1", conn);
                cmdSolved.Parameters.AddWithValue("@uid", SessionManager.CurrentUser.UserID);
            int solved = (int)cmdSolved.ExecuteScalar();

            
            lblMissionpage6.Text = $"{solved}/{total}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMissionpage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMissionPage1_Click(object sender, EventArgs e)
        {

        }
    }

}

