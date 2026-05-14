using CIPHER.Helpers;
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

        private Color normalColor = Theme.BackgroundMain;
        private Color hoverColor = Theme.BackgroundCard;

        public GenericRow()
        {
            InitializeComponent();
            this.DoubleBuffered = true; this.Cursor = Cursors.Hand;

            BackColor = hoverColor;

            this.MouseEnter += GenericRow_MouseEnter;
            this.MouseLeave += GenericRow_MouseLeave;



            foreach (Control c in this.Controls)
            {   
                c.MouseEnter += GenericRow_MouseEnter;
                c.MouseLeave += GenericRow_MouseLeave;
                c.Cursor = Cursors.Hand; // Force child panels to show the hand

                if (c is TableLayoutPanel tlp)
                {
                    foreach (Control child in tlp.Controls)
                    {
                        child.Cursor = Cursors.Hand; // Force labels to show the hand
                    }
                }
            }
            

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

        private void GenericRow_MouseEnter(object sender, EventArgs e)
        {
            BackColor = hoverColor;
        }

        private void GenericRow_MouseLeave(object sender, EventArgs e)
        {
            BackColor = normalColor;
        }
    }
}
