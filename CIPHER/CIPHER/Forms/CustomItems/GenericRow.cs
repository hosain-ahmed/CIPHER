using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.CustomItems
{
    public partial class GenericRow : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object DataReference { get; set; } // This can hold any data object you want to associate with this row
        public GenericRow()
        {
            InitializeComponent();
            this.DoubleBuffered = true; this.Cursor = Cursors.Hand;
            foreach (Control c in this.Controls)
            {
                c.Cursor = Cursors.Hand; // Force child panels to show the hand

                if (c is TableLayoutPanel tlp)
                {
                    foreach (Control child in tlp.Controls)
                    {
                        child.Cursor = Cursors.Hand; // Force labels to show the hand
                    }
                }
            }
            // Helps with smoother rendering if you have custom drawing

        }

        public void SetData(string id, string title, string value, string info)
        {
            lblID.Text = id;
            lblTitle.Text = title;
            lblSInfo.Text = value;
            lblInfo.Text = info;

        }
        private void Row_Click(object sender, EventArgs e)
        {
            OnRowClicked?.Invoke(this, DataReference);
        }

        public event EventHandler<object> OnRowClicked;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
