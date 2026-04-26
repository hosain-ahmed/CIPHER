namespace CIPHER
{
    partial class MainShell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dashBoardContainer1 = new CIPHER.Forms.Controls.DashBoardContainer();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dashBoardContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 616);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_2;
            // 
            // dashBoardContainer1
            // 
            dashBoardContainer1.BackColor = SystemColors.Control;
            dashBoardContainer1.Dock = DockStyle.Fill;
            dashBoardContainer1.Location = new Point(0, 0);
            dashBoardContainer1.Name = "dashBoardContainer1";
            dashBoardContainer1.Size = new Size(859, 616);
            dashBoardContainer1.TabIndex = 0;
            // 
            // MainShell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 616);
            Controls.Add(panel1);
            Name = "MainShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CIPHER";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Forms.Controls.DashBoardContainer dashBoardContainer1;
    }
}
