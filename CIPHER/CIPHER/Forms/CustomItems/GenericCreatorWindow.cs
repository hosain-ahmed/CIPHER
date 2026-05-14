using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CIPHER.Models;
using CIPHER.Services;

namespace CIPHER.Forms.CustomItems
{
    public partial class GenericCreatorWindow : Form
    {
        public Action<string, string, string, int, int, string, string, string> OnDataSubmitted;
        public GenericCreatorWindow(string windowTitle)
        {
            InitializeComponent();
            this.Text = windowTitle;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OnDataSubmitted?.Invoke(
            txtTitle.Text,
            txtDifficulty.Text,
            txtCategory.Text,
            Convert.ToInt32(txtCoin.Text),
            Convert.ToInt32(txtXP.Text),
            rtbBriefing.Text,
            rtbAnswer.Text,
            rtbHint.Text
        );

            this.Close();
        }
    }
}
