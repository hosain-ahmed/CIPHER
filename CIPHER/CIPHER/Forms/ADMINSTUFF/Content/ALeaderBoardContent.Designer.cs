using CIPHER.Helpers;

namespace CIPHER.Forms.ADMINSTUFF.Content
{
    partial class ALeaderBoardContent
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
            panel1 = new Panel();
            flpLeaderboard = new FlowLayoutPanel();
            panel2 = new Panel();
            btnRefresh = new Button();
            lblLeaderBoard = new Label();
            pnlPodium = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            lblBountiesCracked2 = new Label();
            lblMissionSolved2 = new Label();
            lblXP2 = new Label();
            lblName2 = new Label();
            lblPosition2 = new Label();
            panel4 = new Panel();
            lblBountiesCracked1 = new Label();
            lblMissionSolved1 = new Label();
            lblXP1 = new Label();
            lblPosition1 = new Label();
            lblName1 = new Label();
            panel5 = new Panel();
            lblBountiesCracked3 = new Label();
            lblMissionSolved3 = new Label();
            lblName3 = new Label();
            lblXP3 = new Label();
            lblPosition3 = new Label();
            panel1.SuspendLayout();
            pnlPodium.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(flpLeaderboard);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(90, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 386);
            panel1.TabIndex = 0;
            // 
            // flpLeaderboard
            // 
            flpLeaderboard.AutoScroll = true;
            flpLeaderboard.BackColor = Color.FromArgb(244, 247, 246);
            flpLeaderboard.Dock = DockStyle.Fill;
            flpLeaderboard.FlowDirection = FlowDirection.TopDown;
            flpLeaderboard.Location = new Point(0, 43);
            flpLeaderboard.Margin = new Padding(0);
            flpLeaderboard.Name = "flpLeaderboard";
            flpLeaderboard.Size = new Size(1031, 343);
            flpLeaderboard.TabIndex = 1;
            flpLeaderboard.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 43);
            panel2.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(977, 56);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(144, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblLeaderBoard
            // 
            lblLeaderBoard.AutoSize = true;
            lblLeaderBoard.Location = new Point(90, 32);
            lblLeaderBoard.Name = "lblLeaderBoard";
            lblLeaderBoard.Size = new Size(73, 15);
            lblLeaderBoard.TabIndex = 6;
            lblLeaderBoard.Text = "Leaderboard";
            // 
            // pnlPodium
            // 
            pnlPodium.Controls.Add(tableLayoutPanel1);
            pnlPodium.Location = new Point(165, 102);
            pnlPodium.Name = "pnlPodium";
            pnlPodium.Size = new Size(866, 154);
            pnlPodium.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3312263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3345528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3342247F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(866, 154);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(lblBountiesCracked2);
            panel3.Controls.Add(lblMissionSolved2);
            panel3.Controls.Add(lblXP2);
            panel3.Controls.Add(lblName2);
            panel3.Controls.Add(lblPosition2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 130);
            panel3.TabIndex = 8;
            // 
            // lblBountiesCracked2
            // 
            lblBountiesCracked2.AutoSize = true;
            lblBountiesCracked2.Location = new Point(184, 85);
            lblBountiesCracked2.Name = "lblBountiesCracked2";
            lblBountiesCracked2.Size = new Size(44, 15);
            lblBountiesCracked2.TabIndex = 4;
            lblBountiesCracked2.Text = "label11";
            // 
            // lblMissionSolved2
            // 
            lblMissionSolved2.AutoSize = true;
            lblMissionSolved2.Location = new Point(184, 47);
            lblMissionSolved2.Name = "lblMissionSolved2";
            lblMissionSolved2.Size = new Size(44, 15);
            lblMissionSolved2.TabIndex = 3;
            lblMissionSolved2.Text = "label10";
            // 
            // lblXP2
            // 
            lblXP2.AutoSize = true;
            lblXP2.Location = new Point(12, 78);
            lblXP2.Name = "lblXP2";
            lblXP2.Size = new Size(38, 15);
            lblXP2.TabIndex = 2;
            lblXP2.Text = "label9";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Location = new Point(12, 47);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(38, 15);
            lblName2.TabIndex = 1;
            lblName2.Text = "label8";
            // 
            // lblPosition2
            // 
            lblPosition2.AutoSize = true;
            lblPosition2.Location = new Point(12, 20);
            lblPosition2.Name = "lblPosition2";
            lblPosition2.Size = new Size(38, 15);
            lblPosition2.TabIndex = 0;
            lblPosition2.Text = "label7";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(lblBountiesCracked1);
            panel4.Controls.Add(lblMissionSolved1);
            panel4.Controls.Add(lblXP1);
            panel4.Controls.Add(lblPosition1);
            panel4.Controls.Add(lblName1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(291, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 148);
            panel4.TabIndex = 9;
            // 
            // lblBountiesCracked1
            // 
            lblBountiesCracked1.AutoSize = true;
            lblBountiesCracked1.Location = new Point(125, 103);
            lblBountiesCracked1.Name = "lblBountiesCracked1";
            lblBountiesCracked1.Size = new Size(38, 15);
            lblBountiesCracked1.TabIndex = 4;
            lblBountiesCracked1.Text = "label6";
            // 
            // lblMissionSolved1
            // 
            lblMissionSolved1.AutoSize = true;
            lblMissionSolved1.Location = new Point(125, 55);
            lblMissionSolved1.Name = "lblMissionSolved1";
            lblMissionSolved1.Size = new Size(38, 15);
            lblMissionSolved1.TabIndex = 3;
            lblMissionSolved1.Text = "label5";
            // 
            // lblXP1
            // 
            lblXP1.AutoSize = true;
            lblXP1.Location = new Point(25, 101);
            lblXP1.Name = "lblXP1";
            lblXP1.Size = new Size(38, 15);
            lblXP1.TabIndex = 2;
            lblXP1.Text = "label4";
            lblXP1.Click += label4_Click;
            // 
            // lblPosition1
            // 
            lblPosition1.AutoSize = true;
            lblPosition1.Location = new Point(25, 18);
            lblPosition1.Name = "lblPosition1";
            lblPosition1.Size = new Size(38, 15);
            lblPosition1.TabIndex = 1;
            lblPosition1.Text = "label3";
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Location = new Point(25, 55);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(38, 15);
            lblName1.TabIndex = 0;
            lblName1.Text = "label2";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RosyBrown;
            panel5.Controls.Add(lblBountiesCracked3);
            panel5.Controls.Add(lblMissionSolved3);
            panel5.Controls.Add(lblName3);
            panel5.Controls.Add(lblXP3);
            panel5.Controls.Add(lblPosition3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(579, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 110);
            panel5.TabIndex = 10;
            // 
            // lblBountiesCracked3
            // 
            lblBountiesCracked3.AutoSize = true;
            lblBountiesCracked3.Location = new Point(140, 95);
            lblBountiesCracked3.Name = "lblBountiesCracked3";
            lblBountiesCracked3.Size = new Size(44, 15);
            lblBountiesCracked3.TabIndex = 4;
            lblBountiesCracked3.Text = "label16";
            // 
            // lblMissionSolved3
            // 
            lblMissionSolved3.AutoSize = true;
            lblMissionSolved3.Location = new Point(140, 58);
            lblMissionSolved3.Name = "lblMissionSolved3";
            lblMissionSolved3.Size = new Size(44, 15);
            lblMissionSolved3.TabIndex = 3;
            lblMissionSolved3.Text = "label15";
            // 
            // lblName3
            // 
            lblName3.AutoSize = true;
            lblName3.Location = new Point(18, 58);
            lblName3.Name = "lblName3";
            lblName3.Size = new Size(44, 15);
            lblName3.TabIndex = 2;
            lblName3.Text = "label14";
            // 
            // lblXP3
            // 
            lblXP3.AutoSize = true;
            lblXP3.Location = new Point(18, 95);
            lblXP3.Name = "lblXP3";
            lblXP3.Size = new Size(44, 15);
            lblXP3.TabIndex = 1;
            lblXP3.Text = "label13";
            // 
            // lblPosition3
            // 
            lblPosition3.AutoSize = true;
            lblPosition3.Location = new Point(18, 17);
            lblPosition3.Name = "lblPosition3";
            lblPosition3.Size = new Size(44, 15);
            lblPosition3.TabIndex = 0;
            lblPosition3.Text = "label12";
            // 
            // ALeaderBoardContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPodium);
            Controls.Add(lblLeaderBoard);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Name = "ALeaderBoardContent";
            Size = new Size(1227, 708);
            panel1.ResumeLayout(false);
            pnlPodium.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flpLeaderboard;
        private Panel panel2;
        private Button btnRefresh;
        private Label lblLeaderBoard;
        private Panel pnlPodium;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label lblBountiesCracked2;
        private Label lblMissionSolved2;
        private Label lblXP2;
        private Label lblName2;
        private Label lblPosition2;
        private Label lblBountiesCracked1;
        private Label lblMissionSolved1;
        private Label lblXP1;
        private Label lblPosition1;
        private Label lblName1;
        private Label lblBountiesCracked3;
        private Label lblMissionSolved3;
        private Label lblName3;
        private Label lblXP3;
        private Label lblPosition3;
    }
}
