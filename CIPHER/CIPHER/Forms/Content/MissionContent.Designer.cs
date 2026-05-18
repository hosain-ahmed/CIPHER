using CIPHER.Helpers;

namespace CIPHER.Forms.Content
{
    partial class MissionContent
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblMissionpage2 = new Label();
            panel1 = new Panel();
            lblMissionPage1 = new Label();
            panel2 = new Panel();
            lblXP = new Label();
            lblMissionpage3 = new Label();
            panel4 = new Panel();
            lblMISSIOM = new Label();
            lblMissionpage5 = new Label();
            panel3 = new Panel();
            btnCreateMission = new Button();
            txtSearch = new TextBox();
            btnSEarch = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(244, 247, 246);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(824, 399);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMissionpage2
            // 
            lblMissionpage2.AutoSize = true;
            lblMissionpage2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMissionpage2.ForeColor = Color.Gray;
            lblMissionpage2.Location = new Point(13, 35);
            lblMissionpage2.Name = "lblMissionpage2";
            lblMissionpage2.Size = new Size(443, 14);
            lblMissionpage2.TabIndex = 1;
            lblMissionpage2.Text = "Deploy into active cyber warfare scenarios. Neutralize threats, secure data nodes .";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 247, 246);
            panel1.Controls.Add(lblMissionpage2);
            panel1.Controls.Add(lblMissionPage1);
            panel1.Location = new Point(46, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 60);
            panel1.TabIndex = 1;
            // 
            // lblMissionPage1
            // 
            lblMissionPage1.Anchor = AnchorStyles.Left;
            lblMissionPage1.AutoSize = true;
            lblMissionPage1.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionPage1.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionPage1.Location = new Point(9, 8);
            lblMissionPage1.Name = "lblMissionPage1";
            lblMissionPage1.Size = new Size(236, 29);
            lblMissionPage1.TabIndex = 0;
            lblMissionPage1.Text = "CURRENT MISSIONS";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(240, 244, 247);
            panel2.Controls.Add(lblXP);
            panel2.Controls.Add(lblMissionpage3);
            panel2.Location = new Point(622, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 60);
            panel2.TabIndex = 2;
            // 
            // lblXP
            // 
            lblXP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblXP.AutoSize = true;
            lblXP.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXP.ForeColor = Color.FromArgb(11, 109, 126);
            lblXP.Location = new Point(32, 33);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(16, 17);
            lblXP.TabIndex = 1;
            lblXP.Text = "0";
            // 
            // lblMissionpage3
            // 
            lblMissionpage3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMissionpage3.AutoSize = true;
            lblMissionpage3.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage3.Location = new Point(12, 14);
            lblMissionpage3.Name = "lblMissionpage3";
            lblMissionpage3.Size = new Size(49, 12);
            lblMissionpage3.TabIndex = 0;
            lblMissionpage3.Text = "TOTAL_XP";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(240, 244, 247);
            panel4.Controls.Add(lblMISSIOM);
            panel4.Controls.Add(lblMissionpage5);
            panel4.Location = new Point(724, 31);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(80, 60);
            panel4.TabIndex = 4;
            // 
            // lblMISSIOM
            // 
            lblMISSIOM.AutoSize = true;
            lblMISSIOM.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMISSIOM.ForeColor = Color.FromArgb(11, 109, 126);
            lblMISSIOM.Location = new Point(21, 30);
            lblMISSIOM.Name = "lblMISSIOM";
            lblMISSIOM.Size = new Size(16, 17);
            lblMISSIOM.TabIndex = 1;
            lblMISSIOM.Text = "0";
            // 
            // lblMissionpage5
            // 
            lblMissionpage5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMissionpage5.AutoSize = true;
            lblMissionpage5.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage5.Location = new Point(3, 14);
            lblMissionpage5.Name = "lblMissionpage5";
            lblMissionpage5.Size = new Size(61, 12);
            lblMissionpage5.TabIndex = 0;
            lblMissionpage5.Text = "COMPLETED";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(46, 141);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 399);
            panel3.TabIndex = 0;
            // 
            // btnCreateMission
            // 
            btnCreateMission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateMission.BackColor = Color.FromArgb(234, 240, 240);
            btnCreateMission.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateMission.ForeColor = Color.FromArgb(11, 109, 126);
            btnCreateMission.Location = new Point(417, 104);
            btnCreateMission.Margin = new Padding(3, 2, 3, 2);
            btnCreateMission.Name = "btnCreateMission";
            btnCreateMission.Size = new Size(150, 22);
            btnCreateMission.TabIndex = 5;
            btnCreateMission.Text = "Create Mission";
            btnCreateMission.UseVisualStyleBackColor = false;
            btnCreateMission.Visible = false;
            btnCreateMission.Click += btnCreateMission_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(240, 244, 244);
            txtSearch.Location = new Point(634, 104);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(170, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSEarch
            // 
            btnSEarch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSEarch.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSEarch.ForeColor = Color.FromArgb(11, 109, 126);
            btnSEarch.Location = new Point(573, 104);
            btnSEarch.Margin = new Padding(3, 2, 3, 2);
            btnSEarch.Name = "btnSEarch";
            btnSEarch.Size = new Size(59, 22);
            btnSEarch.TabIndex = 7;
            btnSEarch.Text = "Search";
            btnSEarch.UseVisualStyleBackColor = true;
            btnSEarch.Click += btnSEarch_Click;
            // 
            // MissionContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 240, 240);
            Controls.Add(btnSEarch);
            Controls.Add(txtSearch);
            Controls.Add(btnCreateMission);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MissionContent";
            Size = new Size(914, 596);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lblMissionPage1;
        private Label lblMissionpage2;
        private Label lblXP;
        private Label lblMissionpage3;
        private Panel panel4;
        private Label lblMISSIOM;
        private Label lblMissionpage5;
        private Panel panel3;
        private Button btnCreateMission;
        private TextBox txtSearch;
        private Button btnSEarch;
    }
}
