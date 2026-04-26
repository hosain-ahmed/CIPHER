using CIPHER.Forms.CustomItems;
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
    public partial class MissionContent : UserControl
    {
        MissionService MissionService = new MissionService(); // Assuming MissionService is a class that retrieves missions
        BountyService bountyService = new BountyService();
        public MissionContent()
        {
            InitializeComponent();
            LoadMissions();
        }

        public void LoadMissions()
        {
            flowLayoutPanel1.Controls.Clear();
           var missions = MissionService.GetAllMissions();
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

                // Use your theme color here!
                card.AccentColor = Color.FromArgb(0, 245, 255); // Neon Cyan

                // 3. Add to the panel
                flowLayoutPanel1.Controls.Add(card);

               

            }
        }
        
    }
    
}

