using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CIPHER.Forms.Controls;
using CIPHER.Forms.CustomItems;

namespace CIPHER.Forms.ADMINSTUFF.Controls
{
    public partial class ADashboardContainer : BaseDashboard
    {
        public ADashboardContainer()
        {
            InitializeComponent();
        }

        protected override void btnProfile_Click(object sender, EventArgs e)
        {

        }


        protected override void btnMission_Click(object sender, EventArgs e)
        {
            LoadView(new Content.AMissionContent());
        }

        protected override void btnAgentManagement_Click(object sender, EventArgs e)
        {
            LoadView(new Content.ASummaryContent());
        }

    }
}