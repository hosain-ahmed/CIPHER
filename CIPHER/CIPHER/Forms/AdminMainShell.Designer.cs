namespace CIPHER.Forms
{
    partial class AdminMainShell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            aDashboardContainer1 = new CIPHER.Forms.ADMINSTUFF.Controls.ADashboardContainer();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(aDashboardContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 711);
            panel1.TabIndex = 0;
            // 
            // aDashboardContainer1
            // 
            aDashboardContainer1.Dock = DockStyle.Fill;
            aDashboardContainer1.Location = new Point(0, 0);
            aDashboardContainer1.Name = "aDashboardContainer1";
            aDashboardContainer1.Size = new Size(1264, 711);
            aDashboardContainer1.TabIndex = 0;
            // 
            // AdminMainShell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 711);
            Controls.Add(panel1);
            Name = "AdminMainShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CIPHER";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ADMINSTUFF.Controls.ADashboardContainer aDashboardContainer1;
    }
}