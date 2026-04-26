using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CIPHER.Forms.Content;
using CIPHER.Models; // Make sure this points to wherever your Mission class is

namespace CIPHER.Forms.CustomItems
{
    public partial class MissionCard : UserControl
    {
        // 1. THE BRAIN: The actual data object
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Mission MissionData { get; set; }

        public MissionCard()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            foreach (Control c in this.Controls)
            {
                c.Cursor = Cursors.Hand; // Force child panels to show the hand

                if (c is TableLayoutPanel tlp)
                {
                    foreach (Control child in tlp.Controls)
                    {
                        child.Cursor = Cursors.Hand; // Force labels to show the hand
                    }
                }
            }
        }

        // 2. THE SYNC: A method to push data to your existing properties
        public void LoadData()
        {
            if (MissionData == null) return;

            this.MissionTitle = MissionData.Title;
            this.MissionID = "ID: " + MissionData.MissionID;
            this.MissionDescription = MissionData.Briefing;
            
            this.MissionReward = MissionData.XPReward.ToString() + " XP";

            // Logic for accent color based on difficulty
            if (MissionData.Difficulty == "Hard") this.AccentColor = Color.Red;
            else this.AccentColor = Color.Cyan;
        }

        // 3. THE ACTION: Opening the detail form
        private void OpenMissionDetails(object sender, EventArgs e)
        {
            if (this.MissionData == null) return;

            // Open the detail form and pass this card's specific mission object
            using (var detailForm = new PoPMissionSolve(this.MissionData))
            {
                var result = detailForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // If they solved it, maybe change the UI here?
                    this.MissionStatus = "COMPLETED";
                    this.AccentColor = Color.LimeGreen;
                }
            }
        }

        // --- Your existing properties remain below ---

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionTitle { get { return lblTitle.Text; } set { lblTitle.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionID { get { return lblID.Text; } set { lblID.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionDescription { get { return lblDescription.Text; } set { lblDescription.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionStatus { get { return lblStatus.Text; } set { lblStatus.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionReward { get { return lblExtraInfo.Text; } set { lblExtraInfo.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color AccentColor { get { return cardPanel.BackColor; } set { cardPanel.BackColor = value; } }
    }
}