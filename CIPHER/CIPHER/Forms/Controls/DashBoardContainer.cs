using CIPHER.Forms.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Controls
{
    public partial class DashBoardContainer : UserControl
    {
        public DashBoardContainer()
        {
            InitializeComponent();
        }

        public void LoadView(UserControl view)
        {
            if (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Dispose();
            }
            pnlContent.Controls.Clear();

            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
        }


        private void sdbControl_Load(object sender, EventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            LoadView(new MissionContent());
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            LoadView(new MarketContent());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            LoadView(new LogContent());

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
        private void HighlightButton(Button btn)
        {
            // Reset all buttons to the dark color first
            btnMission.BackColor = Color.FromArgb(18, 18, 18);
            btnMarket.BackColor = Color.FromArgb(18, 18, 18);

            // Make the clicked one glow Cyan
            btn.BackColor = Color.FromArgb(30, 30, 30); // Slightly lighter
            btn.ForeColor = Color.FromArgb(0, 245, 255); // Neon Cyan text
        }
    }
}
