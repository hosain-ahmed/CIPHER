using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CIPHER.Forms.Content;
using CIPHER.Helpers;
using CIPHER.Models;
using Microsoft.Data.SqlClient; // Make sure this points to wherever your Mission class is

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
            //this.MissionDescription = MissionData.Briefing;

            this.MissionReward = MissionData.XPReward.ToString() + " XP";
            this.MissionDifficulty = MissionData.Difficulty;

            this.MissionStatus = MissionData.IsSolved == "1" ? "COMPLETED" : "AVAILABLE";



            lblDifficulty.Invalidate();

            // Logic for accent color based on difficulty
            /* if (MissionData.Difficulty == "Hard") this.AccentColor = Color.Red;
             else this.AccentColor = Color.Cyan;*/
        }

        // 3. THE ACTION: Opening the detail form
        private void OpenMissionDetails(object sender, EventArgs e)
        {
            if (this.MissionData == null) return;

            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand("SELECT Solved FROM Progress WHERE UserID = @userID AND MissionID = @missionID", conn);
            cmd.Parameters.AddWithValue("@userID", SessionManager.CurrentUser.UserID);
            cmd.Parameters.AddWithValue("@missionID", this.MissionData.MissionID);
            var isSolved = cmd.ExecuteScalar();
            if (isSolved != null && Convert.ToInt32(isSolved) == 1)
            {
                MessageBox.Show("You've already completed this mission!", "Mission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SessionManager.isAdmin)
            {
                // Open the detail form and pass this card's specific mission object
                using (var detailForm = new PoPMissionSolve(this.MissionData))
                {
                    var result = detailForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // If they solved it, maybe change the UI here?
                        this.MissionStatus = "COMPLETED";

                        Control parent = this.Parent;
                        while (parent != null && !(parent is MissionContent))
                            parent = parent.Parent;

                        if (parent is MissionContent content)
                            content.RefreshAll();
                    }
                }
            }
            else
            {
                var win = new GenericCreatorWindow();
                win.SetupEditMode(this.MissionData);
                win.ShowDialog();
            }
        }

        private void MissionCard_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, Color.Gray); // Slightly darker on hover
        }

        private void MissionCard_MouseHover(object sender, EventArgs e)
        {
           // BackColor = Color.FromArgb(30, Color.Gray); // Slightly lighter on hover
        }

        private void MissionCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White; // Reset to original color when mouse leaves
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionTitle { get { return lblTitle.Text; } set { lblTitle.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionID { get { return lblID.Text; } set { lblID.Text = value; } }

        //[Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public string MissionDescription { get { return lblDescription.Text; } set { lblDescription.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionStatus { get { return lblStatus.Text; } set { lblStatus.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionReward { get { return lblReward.Text; } set { lblReward.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MissionDifficulty
        {
            get => lblDifficulty.Text;
            set
            {
                lblDifficulty.Text = value;

                // Update color automatically whenever text changes
                switch (value?.ToLower())
                {
                    case "expert":
                        lblDifficulty.ForeColor = Color.Purple;
                        break;
                    case "hard":
                        lblDifficulty.ForeColor = Color.Red;
                        break;
                    case "medium":
                        lblDifficulty.ForeColor = Color.Orange;
                        break;
                    default:
                        lblDifficulty.ForeColor = Color.LimeGreen;
                        break;
                }
            }
        }

        //[Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // public Color AccentColor { get { return cardPanel.BackColor; } set { cardPanel.BackColor = value; } }
    }
}