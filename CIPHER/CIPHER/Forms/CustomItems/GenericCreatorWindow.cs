using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CIPHER.Helpers;
using CIPHER.Models;
using CIPHER.Services;

namespace CIPHER.Forms.CustomItems
{
    public partial class GenericCreatorWindow : Form
    {
        private CreationModeEnum _currMode;
        private AdminService _adminService = new AdminService();
        private AuthService _authService = new AuthService();
        private BountyService _bountyService = new BountyService();
       // public Action<string, string, string, int, int, string, string, string> OnDataSubmitted;
        public GenericCreatorWindow()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                switch(_currMode){
                    case CreationModeEnum.Mission:
                        if(_editMission !=null){
                            _editMission.Title = txtTitle.Text;
                            _editMission.Category = txtCategory.Text;
                            _editMission.Difficulty = txtDifficulty.Text;
                            _editMission.CoinReward = int.Parse(txtCoin.Text);
                            _editMission.XPReward = int.Parse(txtXP.Text);
                            _editMission.Briefing = rtbBriefing.Text;
                            _editMission.Answer = rtbAnswer.Text;
                            _editMission.Hint = rtbHint.Text;
                            bool updated = _adminService.UpdateMission(_editMission);
                            if (!updated) throw new Exception("Update failed.");
                        }



                        else {
                            var mission = new Mission
                            {
                                Title = txtTitle.Text,
                                Category = txtCategory.Text,
                                Difficulty = txtDifficulty.Text,
                                CoinReward = int.Parse(txtCoin.Text),
                                XPReward = int.Parse(txtXP.Text),
                                Briefing = rtbBriefing.Text,
                                Answer = rtbAnswer.Text,
                                Hint = rtbHint.Text
                            };
                            _adminService.CreateMission(mission); }
                        break;
                    case CreationModeEnum.User:
                        var user = new User
                        {
                            Codename = txtTitle.Text,
                            FullName = txtCategory.Text,
                            PasswordHash = rtbHint.Text,
                            CryptCoin = int.Parse(txtCoin.Text),
                            FactionID = int.Parse(txtXP.Text),
                            Email = rtbBriefing.Text
                        };
                        _authService.Register(user.Codename,user.FullName, user.Email, user.PasswordHash,user.FactionID);
                        break;
                    case CreationModeEnum.Bounty:
                        var bounty = new Bounty
                        {
                            Title = txtTitle.Text,
                            CoinReward = int.Parse(txtCoin.Text),
                            EncryptedMessage = rtbBriefing.Text,
                            Answer = rtbAnswer.Text
                        };
                        var(okk, errr) = _bountyService.PostBounty(SessionManager.CurrentUser.UserID, bounty.Title,bounty.EncryptedMessage,bounty.Answer,bounty.CoinReward);
                        if (!okk )
                        {
                            MessageBox.Show($"ERROR CREATING BOUNTY: {errr}");
                            return;
                        }
                        break;
                    case CreationModeEnum.Hitlist:
                        int targetID = int.Parse(txtTitle.Text);
                        int durationMinutes = int.Parse(txtDifficulty.Text) * 60;

                        var hitSvc = new HitlistService();
                        var (ok, err) = hitSvc.PlaceHit(
                            SessionManager.CurrentUser.UserID,
                            targetID,
                            durationMinutes);

                        if (ok)
                            MessageBox.Show("CONTRACT INITIATED. CHALLENGES GENERATED.");
                        else
                            MessageBox.Show($"CONTRACT FAILED: {err}");
                        break;
                }

                MessageBox.Show($"{_currMode.ToString().ToUpper()} CREATED SUCCESSFULLY.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR CREATING {_currMode.ToString().ToUpper()}: {ex.Message}");
            }

        }

        private Mission _editMission; // null if creating

        public void SetupEditMode(Mission mission)
        {
            _editMission = mission;
            this.Text = $"LOG_DEPT :: EDIT_MISSION #{mission.MissionID}";

            // Show all controls (like Mission creation mode)
            ToggleAllControls(true);
            lblTitle.Text = "Mission Title";
            lblCategory.Text = "Category";
            lblDifficulty.Text = "Difficulty";
            lblCoin.Text = "Coin Reward";
            lblXP.Text = "XP Reward";
            lblBriefing.Text = "Briefing";
            lblAnswer.Text = "Answer";
            lblHint.Text = "Hint";
            // Ensure all labels/fields visible
            lblAnswer.Visible = rtbAnswer.Visible = true;
            lblHint.Visible = rtbHint.Visible = true;
            lblCategory.Visible = txtCategory.Visible = true;
            lblXP.Visible = txtXP.Visible = true;
            lblDifficulty.Visible = txtDifficulty.Visible = true;

            // Pre-fill data
            txtTitle.Text = mission.Title;
            txtCategory.Text = mission.Category;
            txtDifficulty.Text = mission.Difficulty;
            txtCoin.Text = mission.CoinReward.ToString();
            txtXP.Text = mission.XPReward.ToString();
            rtbBriefing.Text = mission.Briefing;
            rtbAnswer.Text = mission.Answer;
            rtbHint.Text = mission.Hint;
        }

        public void SetupMode(CreationModeEnum mode)
        {
            _currMode = mode;
            this.Text = $"LOG_DEPT :: CREATE_{mode.ToString().ToUpper()}";
            ToggleAllControls(true);
            switch (mode)
            {
                case CreationModeEnum.Mission:
                    
                    break;
                case CreationModeEnum.User:
                    lblTitle.Text = "Agent Codename";
                    lblCategory.Text = "Full Name";
                    lblHint.Text = "Initial Password";
                    lblCoin.Text = "Starting CryptCoin";
                    lblXP.Text = "Faction ID";
                    lblBriefing.Text = "Secure Email Route";

                    lblAnswer.Visible = rtbAnswer.Visible = false;
                    lblDifficulty.Visible = txtDifficulty.Visible = false;
                    break;
                case CreationModeEnum.Bounty:
                    lblTitle.Text = "Bounty Title";
                   
                   
                    lblCoin.Text = "Reward (CryptCoin)";
                    lblBriefing.Text = "Bounty Description";
                    lblAnswer.Text = "Bounty Solution";

                    lblDifficulty.Visible = txtDifficulty.Visible = false;
                    lblCategory.Visible = txtCategory.Visible = false;
                    lblXP.Visible = txtXP.Visible = false;
                    lblHint.Visible = rtbHint.Visible = false;
                    break;
                case CreationModeEnum.Hitlist:
                    lblTitle.Text = "Target UserID";
                    lblDifficulty.Text = "Contract Duration (Hours)";

                    // Hide everything not needed
                    lblCategory.Visible = txtCategory.Visible = false;
                    lblCoin.Visible = txtCoin.Visible = false;
                    lblXP.Visible = txtXP.Visible = false;
                    lblBriefing.Visible = rtbBriefing.Visible = false;
                    lblAnswer.Visible = rtbAnswer.Visible = false;
                    lblHint.Visible = rtbHint.Visible = false;
                    break; ;
            }
        }

        private void ToggleAllControls(bool visible)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Visible = visible;
            }

            btnSubmit.Visible = true;
            btnExit.Visible = true;
        }


    }
}
