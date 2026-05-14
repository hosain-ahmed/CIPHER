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
            lblMissionpage4 = new Label();
            lblMissionpage3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblMissionpage6 = new Label();
            lblMissionpage5 = new Label();
            pnlLowerPanel = new Panel();
            lblMissionPage7 = new Label();
            lblMissionPage8 = new Label();
            lblMissionPage9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            pnlLowerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 221, 255);
            flowLayoutPanel1.Location = new Point(53, 129);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(863, 367);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMissionpage2
            // 
            lblMissionpage2.AutoSize = true;
            lblMissionpage2.Location = new Point(3, 47);
            lblMissionpage2.Name = "lblMissionpage2";
            lblMissionpage2.Size = new Size(547, 20);
            lblMissionpage2.TabIndex = 1;
            lblMissionpage2.Text = "Deploy into active cyber warfare scenarios. Neutralize threats, secure data nodes .";
            lblMissionpage2.Click += lblMissionpage2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMissionpage2);
            panel1.Controls.Add(lblMissionPage1);
            panel1.Location = new Point(53, 41);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 80);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblMissionPage1
            // 
            lblMissionPage1.Anchor = AnchorStyles.Left;
            lblMissionPage1.AutoSize = true;
            lblMissionPage1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionPage1.ForeColor = Color.FromArgb(4, 159, 182);
            lblMissionPage1.Location = new Point(3, 10);
            lblMissionPage1.Name = "lblMissionPage1";
            lblMissionPage1.Size = new Size(316, 37);
            lblMissionPage1.TabIndex = 0;
            lblMissionPage1.Text = "CURRENT MISSIONS";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMissionpage4);
            panel2.Controls.Add(lblMissionpage3);
            panel2.Location = new Point(711, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 67);
            panel2.TabIndex = 2;
            // 
            // lblMissionpage4
            // 
            lblMissionpage4.AutoSize = true;
            lblMissionpage4.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage4.ForeColor = Color.FromArgb(4, 159, 182);
            lblMissionpage4.Location = new Point(22, 35);
            lblMissionpage4.Name = "lblMissionpage4";
            lblMissionpage4.Size = new Size(51, 21);
            lblMissionpage4.TabIndex = 1;
            lblMissionpage4.Text = "12450";
            // 
            // lblMissionpage3
            // 
            lblMissionpage3.AutoSize = true;
            lblMissionpage3.Font = new Font("Constantia", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage3.Location = new Point(14, 11);
            lblMissionpage3.Name = "lblMissionpage3";
            lblMissionpage3.Size = new Size(67, 14);
            lblMissionpage3.TabIndex = 0;
            lblMissionpage3.Text = "TOTAL_XP";
            lblMissionpage3.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(53, 760);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 29);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMissionpage6);
            panel4.Controls.Add(lblMissionpage5);
            panel4.Location = new Point(828, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(91, 67);
            panel4.TabIndex = 4;
            // 
            // lblMissionpage6
            // 
            lblMissionpage6.AutoSize = true;
            lblMissionpage6.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage6.ForeColor = Color.FromArgb(4, 159, 182);
            lblMissionpage6.Location = new Point(24, 35);
            lblMissionpage6.Name = "lblMissionpage6";
            lblMissionpage6.Size = new Size(49, 21);
            lblMissionpage6.TabIndex = 1;
            lblMissionpage6.Text = "18/42";
            // 
            // lblMissionpage5
            // 
            lblMissionpage5.AutoSize = true;
            lblMissionpage5.Font = new Font("Constantia", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage5.Location = new Point(7, 11);
            lblMissionpage5.Name = "lblMissionpage5";
            lblMissionpage5.Size = new Size(81, 14);
            lblMissionpage5.TabIndex = 0;
            lblMissionpage5.Text = "COMPLETED";
            // 
            // pnlLowerPanel
            // 
            pnlLowerPanel.BackColor = Color.FromArgb(234, 221, 255);
            pnlLowerPanel.Controls.Add(lblMissionPage9);
            pnlLowerPanel.Controls.Add(lblMissionPage8);
            pnlLowerPanel.Controls.Add(lblMissionPage7);
            pnlLowerPanel.Location = new Point(53, 503);
            pnlLowerPanel.Name = "pnlLowerPanel";
            pnlLowerPanel.Size = new Size(860, 49);
            pnlLowerPanel.TabIndex = 5;
            // 
            // lblMissionPage7
            // 
            lblMissionPage7.AutoSize = true;
            lblMissionPage7.Location = new Point(48, 8);
            lblMissionPage7.Name = "lblMissionPage7";
            lblMissionPage7.Size = new Size(149, 20);
            lblMissionPage7.TabIndex = 0;
            lblMissionPage7.Text = "PACKET_LOSS : 0.00%";
            // 
            // lblMissionPage8
            // 
            lblMissionPage8.AutoSize = true;
            lblMissionPage8.Location = new Point(262, 8);
            lblMissionPage8.Name = "lblMissionPage8";
            lblMissionPage8.Size = new Size(98, 20);
            lblMissionPage8.TabIndex = 1;
            lblMissionPage8.Text = "LATENCY: 14s";
            // 
            // lblMissionPage9
            // 
            lblMissionPage9.AutoSize = true;
            lblMissionPage9.Location = new Point(433, 8);
            lblMissionPage9.Name = "lblMissionPage9";
            lblMissionPage9.Size = new Size(117, 20);
            lblMissionPage9.TabIndex = 2;
            lblMissionPage9.Text = "UPLINK : ACTIVE";
            // 
            // MissionContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 252);
            Controls.Add(pnlLowerPanel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MissionContent";
            Size = new Size(936, 820);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlLowerPanel.ResumeLayout(false);
            pnlLowerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblMissionPage1;
        private Label lblMissionpage2;
        private Label lblMissionpage4;
        private Label lblMissionpage3;
        private Panel panel4;
        private Label lblMissionpage6;
        private Label lblMissionpage5;
        private Panel pnlLowerPanel;
        private Label lblMissionPage9;
        private Label lblMissionPage8;
        private Label lblMissionPage7;
    }
}
