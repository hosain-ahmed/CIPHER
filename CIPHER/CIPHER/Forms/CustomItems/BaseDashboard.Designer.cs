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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDashboard));
            pnlSidebar = new Panel();
            btnLogs = new Button();
            btnAgentManagement = new Button();
            btnMission = new Button();
            btnProfile = new Button();
            pnlContainer = new Panel();
            panel1 = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(50, 56, 62);
            pnlSidebar.Controls.Add(btnLogs);
            pnlSidebar.Controls.Add(btnAgentManagement);
            pnlSidebar.Controls.Add(btnMission);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(37, 1000);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogs
            // 
            btnLogs.BackgroundImage = Properties.Resources.SSLog;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Location = new Point(3, 205);
            btnLogs.Margin = new Padding(3, 4, 3, 4);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(26, 25);
            btnLogs.TabIndex = 3;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnAgentManagement
            // 
            btnAgentManagement.BackgroundImage = (Image)resources.GetObject("btnAgentManagement.BackgroundImage");
            btnAgentManagement.FlatAppearance.BorderSize = 0;
            btnAgentManagement.FlatStyle = FlatStyle.Flat;
            btnAgentManagement.Location = new Point(4, 142);
            btnAgentManagement.Margin = new Padding(3, 4, 3, 4);
            btnAgentManagement.Name = "btnAgentManagement";
            btnAgentManagement.Size = new Size(25, 25);
            btnAgentManagement.TabIndex = 2;
            btnAgentManagement.UseVisualStyleBackColor = false;
            btnAgentManagement.Click += btnAgentManagement_Click;
            // 
            // btnMission
            // 
            btnMission.BackColor = Color.Transparent;
            btnMission.FlatAppearance.BorderSize = 0;
            btnMission.FlatStyle = FlatStyle.Flat;
            btnMission.Image = Properties.Resources.SSGoal;
            btnMission.Location = new Point(0, 72);
            btnMission.Margin = new Padding(3, 4, 3, 4);
            btnMission.Name = "btnMission";
            btnMission.Size = new Size(33, 43);
            btnMission.TabIndex = 1;
            btnMission.UseVisualStyleBackColor = false;
            btnMission.Click += btnMission_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(50, 56, 62);
            btnProfile.Dock = DockStyle.Bottom;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = Properties.Resources.SSMale;
            btnProfile.Location = new Point(0, 959);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(37, 41);
            btnProfile.TabIndex = 0;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(244, 247, 246);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(37, 64);
            pnlContainer.Margin = new Padding(3, 4, 3, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1426, 936);
            pnlContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(37, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 64);
            panel1.TabIndex = 2;
            // 
            // BaseDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BaseDashboard";
            Size = new Size(1463, 1000);
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContainer;
        private Button btnProfile;
        private Button btnMission;
        private Panel panel1;
        private Button btnAgentManagement;
        private Button btnLogs;
    }
}
