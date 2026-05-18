
using CIPHER.Forms.CustomItems;
using CIPHER.Helpers;
using CIPHER.Models;
using CIPHER.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Content
{
    public partial class MissionContent : UserControl
    {
        MissionService MissionService = new MissionService(); // Assuming MissionService is a class that retrieves missions

        public MissionContent()
        {
            InitializeComponent();
            LoadMissions();
            JustDoinSomething();


        }
        private List<Mission> _allMissions;
        public void LoadMissions()
        {
            _allMissions = MissionService.GetMissionForAgent(SessionManager.CurrentUser.UserID);
            ApplyFilter("");
        }

        private void ApplyFilter(string searchTerm)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            var filtered = _allMissions;
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                filtered = _allMissions.Where(m =>
                    m.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    m.MissionID.ToString() == searchTerm.Trim() ||
                    m.Difficulty.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();
            }

            
                foreach (var m in filtered)
            {
                MissionCard card = new MissionCard();
                card.MissionData = m;


                // Use the card's existing properties
                card.MissionTitle = m.Title;
                card.MissionID = "ID: " + m.MissionID;
                card.MissionDescription = m.Briefing;
                card.MissionReward = m.CoinReward + " CR";
                card.MissionDifficulty = m.Difficulty;
                card.MissionStatus = m.IsSolved == "1" ? "COMPLETED" : "AVAILABLE";
               

                flowLayoutPanel1.Controls.Add(card);
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void JustDoinSomething()
        {
            if (!SessionManager.isAdmin)
            {
                using var conn = DBHelper.Getconnection();

                var cmdTotal = new SqlCommand(@"SELECT COUNT(*) FROM Missions", conn);
                int total = (int)cmdTotal.ExecuteScalar();

                var cmdSolved = new SqlCommand(@"SELECT COUNT(*) FROM Progress WHERE UserID = @uid AND Solved =1", conn);
                cmdSolved.Parameters.AddWithValue("@uid", SessionManager.CurrentUser.UserID);
                int solved = (int)cmdSolved.ExecuteScalar();


                lblMissionpage6.Text = $"{solved}/{total}";

                lblXP.Text = SessionManager.CurrentUser.XP.ToString();
            }
            else
            {
                lblMissionpage6.Text = "Admin";
                lblXP.Text = "Admin";
            }
        }

        public void RefreshAll()
        {
            LoadMissions();
            JustDoinSomething(); // updates XP & solved count labels
        }



        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            var win = new GenericCreatorWindow();
            win.SetupMode(CreationModeEnum.Mission);
            win.Show();
        }

        private void btnSEarch_Click(object sender, EventArgs e)
        {
            ApplyFilter(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ApplyFilter(txtSearch.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

}

