using CIPHER.Forms.CustomItems;
using CIPHER.Helpers;
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
    public partial class LogContent : UserControl
    {
        BountyService bountyService = new BountyService();

        public LogContent()
        {
            InitializeComponent();

            LoadAllActivity();

        }

        public void LoadAllActivity()
        {
            flowLayoutPanel1.Controls.Clear();
            var logs = new AuditService().GetMasterLogs(1);

            foreach (var entry in logs)
            {
                GenericRow row = new GenericRow();

                // Mapping our model to the GenericRow labels
                row.SetData(
                    entry.Category,                  // ID Slot
                    entry.Action.Replace("_", " "),  // Title Slot (Cleaner look)
                    entry.Timestamp.ToString("HH:mm:ss"), // Value Slot
                    entry.Details                    // Info Slot
                );

                row.Width = flowLayoutPanel1.ClientSize.Width - 25;
                flowLayoutPanel1.Controls.Add(row);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
