using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER
{
    public partial class SidebarControl : UserControl
    {
        public SidebarControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminal_MouseEnter(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnTerminal_MouseLeave(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnMissions_MouseEnter(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnMissions_MouseLeave(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnNetwork_MouseEnter(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnNetwork_MouseLeave(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnLogs_MouseEnter(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnLogs_MouseLeave(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnTerminal_MouseHover(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnMissions_MouseHover(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnNetwork_MouseHover(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        private void btnLogs_MouseHover(object sender, EventArgs e)
        {
            SetActive(sender);
        }
        private void SetActive(object sender)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button b)
                    b.BackColor = Color.Transparent;
            }

            ((Button)sender).BackColor = Color.FromArgb(0, 50, 50);
        }
    }
}
