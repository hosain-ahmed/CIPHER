using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CIPHER.Forms.Content;

namespace CIPHER.Forms.CustomItems
{
    public partial class BaseDashboard : UserControl
    {
        public BaseDashboard()
        {
            InitializeComponent();
        }

        public void LoadView(UserControl view)
        {
            if (pnlContainer.Controls.Count > 0)
            {
                pnlContainer.Controls[0].Dispose();
            }
            pnlContainer.Controls.Clear();

            view.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(view);
        }


        protected virtual void btnProfile_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnMission_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAgentManagement_Click(object sender, EventArgs e)
        {
        }

        protected virtual void btnLogs_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnLeaderBoard_Click(object sender, EventArgs e)
        {

        }
    }
}
