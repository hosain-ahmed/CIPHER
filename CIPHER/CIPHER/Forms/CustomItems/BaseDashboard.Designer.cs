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
            btnLeaderBoard = new Button();
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
            pnlSidebar.Controls.Add(btnLeaderBoard);
            pnlSidebar.Controls.Add(btnLogs);
            pnlSidebar.Controls.Add(btnAgentManagement);
            pnlSidebar.Controls.Add(btnMission);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(32, 750);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLeaderBoard
            // 
            btnLeaderBoard.BackColor = Color.Transparent;
            btnLeaderBoard.BackgroundImage = Properties.Resources.SSCMD1;
            btnLeaderBoard.FlatAppearance.BorderSize = 0;
            btnLeaderBoard.FlatStyle = FlatStyle.Flat;
            btnLeaderBoard.Location = new Point(3, 193);
            btnLeaderBoard.Name = "btnLeaderBoard";
            btnLeaderBoard.Size = new Size(23, 23);
            btnLeaderBoard.TabIndex = 3;
            btnLeaderBoard.UseVisualStyleBackColor = false;
            btnLeaderBoard.Click += btnLeaderBoard_Click;
            // 
            // btnLogs
            // 
            btnLogs.BackgroundImage = Properties.Resources.SSLog;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Location = new Point(3, 154);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(23, 19);
            btnLogs.TabIndex = 3;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnAgentManagement
            // 
            btnAgentManagement.BackgroundImage = (Image)resources.GetObject("btnAgentManagement.BackgroundImage");
            btnAgentManagement.FlatAppearance.BorderSize = 0;
            btnAgentManagement.FlatStyle = FlatStyle.Flat;
            btnAgentManagement.Location = new Point(4, 106);
            btnAgentManagement.Name = "btnAgentManagement";
            btnAgentManagement.Size = new Size(22, 19);
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
            btnMission.Location = new Point(0, 54);
            btnMission.Name = "btnMission";
            btnMission.Size = new Size(29, 32);
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
            btnProfile.Location = new Point(0, 719);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(32, 31);
            btnProfile.TabIndex = 0;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(244, 247, 246);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(32, 48);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1248, 702);
            pnlContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(32, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 48);
            panel1.TabIndex = 2;
            // 
            // BaseDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
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
        private Button btnMission;
        private Panel panel1;
        private Button btnAgentManagement;
        private Button btnLogs;
        private Button btnLeaderBoard;
    }
}
