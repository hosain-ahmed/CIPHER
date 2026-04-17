using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Helpers
{
    public static class UIHelper
    {

        public static void Typewrite(RichTextBox rtb, string text,
            int intervalMs = 35, Action onComplete = null)
        {
            int i = 0;
            var t = new System.Windows.Forms.Timer { Interval = intervalMs };
            t.Tick += (s, e) => {
                if (i < text.Length)
                {
                    rtb.AppendText(text[i++].ToString());
                    rtb.ScrollToCaret();
                }
                else { t.Stop(); onComplete?.Invoke(); }
            };
            t.Start();
        }

        public static void TypewriteLabel(Label lbl, string text,
            int intervalMs = 50, Action onComplete = null)
        {
            lbl.Text = "";
            int i = 0;
            var t = new System.Windows.Forms.Timer { Interval = intervalMs };
            t.Tick += (s, e) => {
                if (i < text.Length) lbl.Text += text[i++];
                else { t.Stop(); onComplete?.Invoke(); }
            };
            t.Start();
        }

        public static void ApplyDarkDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(13, 13, 13);
            dgv.GridColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(0, 245, 255);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 80, 100);
            dgv.DefaultCellStyle.Font = new Font("Consolas", 9f);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 40, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
