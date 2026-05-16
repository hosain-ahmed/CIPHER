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
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Content
{
    public partial class LogContent : UserControl
    {
        //BountyService bountyService = new BountyService();

        public LogContent()
        {
            InitializeComponent();
            logsLoader(null, null);


        }

        private void LoadLogs(string filter = null, string search = null)
        {
            //MessageBox.Show($"LoadLogs called with filter: '{filter}'");
            using var conn = DBHelper.Getconnection();
            SqlCommand cmd;

            if (SessionManager.isAdmin)
            {
                string sql = @"
        SELECT a.LogID, u.Codename, a.EventType, a.Details, a.Timestamp
        FROM AuditLog a
        JOIN Users u ON a.UserID = u.UserID
        WHERE 1=1";

                if (filter != null && filter != "All")
                    sql += " AND a.EventType = @filter";

                if (!string.IsNullOrEmpty(search))
                    sql += " AND u.Codename LIKE @search";

                sql += " ORDER BY a.Timestamp DESC";

                cmd = new SqlCommand(sql, conn);

                if (filter != null && filter != "All")
                    cmd.Parameters.AddWithValue("@filter", filter);

                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@search", $"%{search}%");

            }
            else
            {
                string sqll = @"
            SELECT LogID, EventType, 
                   Details, Timestamp
            FROM AuditLog
            WHERE UserID = @uid";

                if (filter != null && filter != "All")
                    sqll += " AND EventType = @filter";

                sqll += " ORDER BY Timestamp DESC";

                cmd = new SqlCommand(sqll, conn);
                cmd.Parameters.AddWithValue("@uid",
                    SessionManager.CurrentUser.UserID);
                if (filter != null && filter != "All")
                    cmd.Parameters.AddWithValue("@filter", filter);
            }

            var table = new DataTable();
            new SqlDataAdapter(cmd).Fill(table);
            dgvLogs.DataSource = table;

            UIHelper.ApplyDarkDataGrid(dgvLogs);

            // Show/hide Codename column based on role
            if (dgvLogs.Columns["Codename"] != null)
                dgvLogs.Columns["Codename"].Visible = SessionManager.isAdmin;

            // Hide raw ID column
            if (dgvLogs.Columns["LogID"] != null)
                dgvLogs.Columns["LogID"].Visible = false;

            // Rename column headers
            if (dgvLogs.Columns["EventType"] != null)
                dgvLogs.Columns["EventType"].HeaderText = "EVENT";
            if (dgvLogs.Columns["Details"] != null)
                dgvLogs.Columns["Details"].HeaderText = "DETAILS";
            if (dgvLogs.Columns["Timestamp"] != null)
                dgvLogs.Columns["Timestamp"].HeaderText = "TIME";
            if (dgvLogs.Columns["Codename"] != null)
                dgvLogs.Columns["Codename"].HeaderText = "AGENT";

            foreach (DataGridViewRow row in dgvLogs.Rows)
            {
                string eventType = row.Cells["EventType"]
                    .Value?.ToString();
                row.DefaultCellStyle.ForeColor = eventType switch
                {
                    "AccountLocked" => Color.FromArgb(255, 80, 80),
                    "HitExecuted" => Color.FromArgb(255, 140, 0),
                    "BountySolved" => Color.FromArgb(0, 255, 136),
                    "FailedAttempt" => Color.FromArgb(255, 200, 0),
                    "AccountUnlocked" => Color.FromArgb(0, 200, 255),
                    _ => Color.FromArgb(200, 200, 200)
                };
            }
        }

        private void logsLoader(object sender, EventArgs e)
        {
            cmbFilter.Visible = SessionManager.isAdmin;
            lblFilter.Visible = SessionManager.isAdmin;

            if (SessionManager.isAdmin)
            {
                cmbFilter.Items.AddRange(new string[]
                {
                    "All",
            "FailedAttempt",
            "AccountLocked",
            "AccountUnlocked",
            "BountySolved",
            "HitExecuted",
            "AdminAction",
            "GhostProtocol"
                });
                cmbFilter.SelectedIndex = 0;
                cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            LoadLogs();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogs(cmbFilter.SelectedItem?.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs(cmbFilter.SelectedItem?.ToString(), textBox1.Text.Trim());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
