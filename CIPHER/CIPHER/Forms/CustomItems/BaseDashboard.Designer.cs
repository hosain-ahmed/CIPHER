using CIPHER.Helpers;

namespace CIPHER.Forms.CustomItems
{
    partial class BaseDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnProfile = new Button();
            pnlContainer = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(50, 56, 62);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(32, 750);
            pnlSidebar.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(50, 56, 62);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = Properties.Resources.SSMale;
            btnProfile.Location = new Point(3, 706);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(28, 31);
            btnProfile.TabIndex = 0;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(244, 247, 246);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(32, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1248, 750);
            pnlContainer.TabIndex = 1;
            // 
            // BaseDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Controls.Add(pnlSidebar);
            Name = "BaseDashboard";
            Size = new Size(1280, 750);
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContainer;
        private Button btnProfile;
    }
}
