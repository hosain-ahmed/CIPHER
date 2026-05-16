using CIPHER.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.ADMINSTUFF.Content
{
    public partial class AProfileContent : UserControl
    {
        public AProfileContent()
        {
            InitializeComponent();
            DataLoader();
        }

        private void DataLoader()
        {
            lblName.Text = "CodeName: " + SessionManager.CurrentUser.Codename;
            lblFullname.Text = "Full Name: " + SessionManager.CurrentUser.FullName;

            lblEmail.Text = "Email: " + SessionManager.CurrentUser.Email;
            lblStatus.Text = "Status: " + SessionManager.CurrentUser.AccountStatus;
            lblUserID.Text = "USER ID: " + SessionManager.CurrentUser.UserID;

            if (!SessionManager.isAdmin)
            {
                lblXP.Text = "XP: " + SessionManager.CurrentUser.XP.ToString();
                lblCryptcoin.Text = "CryptCoin: " + SessionManager.CurrentUser.CryptCoin.ToString();
            }
            else
            {
                lblXP.Text = "No XP for Admins";
                lblCryptcoin.Text = "No CryptCoin for Admins";
            }
            lblPassword.Visible = false;
            txtEmail.Visible = false;
            txtOldPass.Visible = false;
            txtName.Visible = false;
            txtNewPass.Visible = false;
            txtConfirmPass.Visible = false;
            btnConfirmPass.Visible = false;
        }

        private void AProfileContent_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!txtName.Visible)
            {
                txtName.Visible = true;
                txtEmail.Visible = true;
                txtOldPass.Visible = true;
                txtNewPass.Visible = true;
                txtConfirmPass.Visible = true;
                btnConfirmPass.Visible = true;
            }
            else
            {
                txtName.Visible = false;
                txtEmail.Visible = false;
                txtOldPass.Visible = false;
                txtNewPass.Visible = false;
                txtConfirmPass.Visible = false;
                btnConfirmPass.Visible = false;
            }

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var conn = DBHelper.Getconnection();
                var cmd = new SqlCommand("UPDATE Users SET FullName = @FullName WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUser.UserID);
                cmd.ExecuteNonQuery();
                lblFullname.Text = "Full Name: " + txtName.Text;
                txtName.Clear  ();
               
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var conn = DBHelper.Getconnection();
                var cmd = new SqlCommand("UPDATE Users SET Email = @Email WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUser.UserID);
                cmd.ExecuteNonQuery();
                lblEmail.Text = "Email: " + txtEmail.Text;
                txtEmail.Clear();
                
            }
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (!BCrypt.Net.BCrypt.Verify(
        txtOldPass.Text,
        SessionManager.CurrentUser.PasswordHash))
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            // 2. Check new passwords match
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            // 3. Hash new password and update
            string newHash = BCrypt.Net.BCrypt.HashPassword(txtNewPass.Text);

            using var conn = DBHelper.Getconnection();
            new SqlCommand(
                "UPDATE Users SET PasswordHash=@h WHERE UserID=@id", conn)
            {
                Parameters = {
            new("@h", newHash),
            new("@id", SessionManager.CurrentUser.UserID)
        }
            }.ExecuteNonQuery();

            // 4. Update session
            SessionManager.CurrentUser.PasswordHash = newHash;

            //lblError.ForeColor = Color.FromArgb(0, 255, 136);
            MessageBox.Show ("Password updated successfully.");

            // Clear fields
            txtOldPass.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
        }
    }
}
