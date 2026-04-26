using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Controls
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void loginTerminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("KeyDown fired");
        }

        private void loginTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void loginTerminal_SelectionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("SelectionChanged fired");
        }

        private void loginTerminal_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("KeyUp fired");
        }
    }
}
