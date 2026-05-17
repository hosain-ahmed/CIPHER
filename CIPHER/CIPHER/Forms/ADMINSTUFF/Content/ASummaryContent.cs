using CIPHER.Models;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.ADMINSTUFF.Content
{
    public partial class ASummaryContent : UserControl
    {
        List<UserDTO> userList = new List<UserDTO>();
        private UserDTO tempUser = new UserDTO();
        AdminService adminService = new AdminService();

        public ASummaryContent()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {

            List<User> users = adminService.GetAllUsers();

            userList.Clear();

            foreach (var user in users)
            {
                userList.Add(new UserDTO
                {
                    Codename = user.Codename,
                    Role = user.Role,
                    Status = user.AccountStatus,
                    Rank = user.Rank,
                    XpQuota = user.XP,
                    Email = user.Email,
                    FullName = user.FullName,
                    CryptCoin = user.CryptCoin,
                    UserID = user.UserID.ToString(),
                    FactionID = user.FactionID

                });
            }
            dgvUsers.DataSource = null; // Clear existing binding
            dgvUsers.DataSource = userList;
            // 1. Stretch the columns
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Hide the left-side arrow column
            dgvUsers.RowHeadersVisible = false;

            // 3. Remove the border for that flat look
            dgvUsers.BorderStyle = BorderStyle.None;

            // 4. Make the selection look modern (no dotted lines)
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // 5. Change the background to match your panel
            dgvUsers.BackgroundColor = Color.White; // Or your specific hex code

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                tempUser = (UserDTO)dgvUsers.SelectedRows[0].DataBoundItem;
                User testUser = new User();

                if (tempUser != null)
                {

                    lblCodeName.Text = tempUser.Codename;
                    lblUserID.Text = $"USER ID:  {tempUser.UserID}";
                    lblFullName.Text = $"FULL NAME: {tempUser.FullName} ";
                    lblFactionID.Text = "FACTION ID: " + tempUser.FactionID;
                    lblRole.Text = tempUser.Role;
                    lblStatus.Text = tempUser.Status;
                    lblRank.Text = tempUser.Rank;
                    lblXP.Text = tempUser.XpQuota.ToString();
                    lblEmail.Text = tempUser.Email;
                    lblCryptcoin.Text = "CRYPTCOIN: " + tempUser.CryptCoin.ToString();
                }

                if (tempUser.Status == "Active")
                {
                    lblStatus.Text = "● STATUS: ACTIVE";
                    lblStatus.ForeColor = Color.SpringGreen;
                    btnLock.Enabled = true; // Allow admin to lock active users
                }
                else
                {
                    lblStatus.Text = "● STATUS: LOCKED";
                    lblStatus.ForeColor = Color.Crimson;
                    btnLock.Enabled = false; // Already locked
                }

                btnLock.Text = tempUser.Status == "Active" ? "LOCK USER" : "UNLOCK USER";
                btnPromote.Text = tempUser.Role == "Agent" ? "PROMOTE TO ADMIN" : "DEMOTE TO AGENT";
                btnDelete.Enabled = true; // Allow deletion of any user
                btnPromote.Enabled = tempUser.Role != "ADMIN"; // Can't promote admins
                btnReset.Enabled = true; // Allow password reset for any user
                btnLock.Enabled = true; // Allow locking/unlocking of any user
            }

            else
            {
                // No user selected, reset labels and disable buttons
                btnLock.Text = tempUser.Status == "Active" ? "LOCK USER" : "UNLOCK USER";
                btnPromote.Text = tempUser.Role == "Agent" ? "PROMOTE TO ADMIN" : "DEMOTE TO AGENT";
                lblCodeName.Text = "CODENAME: N/A";
                lblRole.Text = "ROLE: N/A";
                lblStatus.Text = "STATUS: N/A";
                lblRank.Text = "RANK: N/A";
                lblXP.Text = "XP QUOTA: N/A";
                lblEmail.Text = "EMAIL: N/A";
                btnDelete.Enabled = false;
                btnPromote.Enabled = false;
                btnReset.Enabled = false;
                btnLock.Enabled = false;
            }

        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (tempUser == null) return;

            btnLock.Text = tempUser.Status == "Active" ? "LOCK USER" : "UNLOCK USER";

            if (tempUser.Status == "Active")
            {
                adminService.LockAgent(int.Parse(tempUser.UserID));
            }
            else
            {
                adminService.UnlockAgent(int.Parse(tempUser.UserID));
            }

            LoadUsers(); // Refresh the user list to reflect changes
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (tempUser == null) return;

            btnPromote.Text = tempUser.Role == "Agent" ? "PROMOTE TO ADMIN" : "DEMOTE TO AGENT";

            if (tempUser.Role == "Agent")
            {
                adminService.PromoteUser(int.Parse(tempUser.UserID));
            }
            else
            {
                adminService.DemoteUser(int.Parse(tempUser.UserID));
            }

            LoadUsers(); // Refresh the user list to reflect changes
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tempUser == null) return;

            var result = MessageBox.Show($"RESET PROGRESS FOR {tempUser.Codename}?", "CONFIRM PROGRESS RESET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            adminService.ResetAgentProgress(int.Parse(tempUser.UserID));
            MessageBox.Show($"Progress for {tempUser.Codename} has been reset.", "PROGRESS RESET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tempUser == null) return;

            var result = MessageBox.Show($"PERMANENTLY DELETE {tempUser.Codename}?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AdminService adminService = new AdminService();
                if (adminService.DeleteUser(int.Parse(tempUser.UserID)))
                {
                    // 1. Remove from our local list
                    userList.Remove(tempUser);

                    // 2. Refresh the DataGridView binding
                    dgvUsers.DataSource = null;
                    dgvUsers.DataSource = userList;

                    // 3. Reset the Inspector Panel
                    tempUser = null;
                    // This will trigger your 'else' logic in SelectionChanged to clear labels
                    dgvUsers_SelectionChanged(null, null);
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveSessions_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentUser_Click(object sender, EventArgs e)
        {

        }

        private void lblCryptcoin_Click(object sender, EventArgs e)
        {

        }
    }
}
