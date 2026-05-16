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
            panel4 = new Panel();
            lblMissionpage6 = new Label();
            lblMissionpage5 = new Label();
            panel3 = new Panel();
            btnCreateMission = new Button();
            textBox1 = new TextBox();
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
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(866, 424);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMissionpage2
            // 
            lblMissionpage2.AutoSize = true;
            lblMissionpage2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMissionpage2.ForeColor = Color.Gray;
            lblMissionpage2.Location = new Point(15, 47);
            lblMissionpage2.Name = "lblMissionpage2";
            lblMissionpage2.Size = new Size(556, 18);
            lblMissionpage2.TabIndex = 1;
            lblMissionpage2.Text = "Deploy into active cyber warfare scenarios. Neutralize threats, secure data nodes .";
            lblMissionpage2.Click += lblMissionpage2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 247, 246);
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
            lblMissionPage1.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionPage1.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionPage1.Location = new Point(10, 11);
            lblMissionPage1.Name = "lblMissionPage1";
            lblMissionPage1.Size = new Size(287, 36);
            lblMissionPage1.TabIndex = 0;
            lblMissionPage1.Text = "CURRENT MISSIONS";
            lblMissionPage1.Click += lblMissionPage1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 244, 247);
            panel2.Controls.Add(lblMissionpage4);
            panel2.Controls.Add(lblMissionpage3);
            panel2.Location = new Point(711, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 80);
            panel2.TabIndex = 2;
            // 
            // lblMissionpage4
            // 
            lblMissionpage4.AutoSize = true;
            lblMissionpage4.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage4.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionpage4.Location = new Point(22, 39);
            lblMissionpage4.Name = "lblMissionpage4";
            lblMissionpage4.Size = new Size(53, 21);
            lblMissionpage4.TabIndex = 1;
            lblMissionpage4.Text = "12450";
            // 
            // lblMissionpage3
            // 
            lblMissionpage3.AutoSize = true;
            lblMissionpage3.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage3.Location = new Point(14, 19);
            lblMissionpage3.Name = "lblMissionpage3";
            lblMissionpage3.Size = new Size(63, 16);
            lblMissionpage3.TabIndex = 0;
            lblMissionpage3.Text = "TOTAL_XP";
            lblMissionpage3.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 244, 247);
            panel4.Controls.Add(lblMissionpage6);
            panel4.Controls.Add(lblMissionpage5);
            panel4.Location = new Point(828, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(91, 80);
            panel4.TabIndex = 4;
            // 
            // lblMissionpage6
            // 
            lblMissionpage6.AutoSize = true;
            lblMissionpage6.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage6.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionpage6.Location = new Point(24, 40);
            lblMissionpage6.Name = "lblMissionpage6";
            lblMissionpage6.Size = new Size(51, 21);
            lblMissionpage6.TabIndex = 1;
            lblMissionpage6.Text = "18/42";
            // 
            // lblMissionpage5
            // 
            lblMissionpage5.AutoSize = true;
            lblMissionpage5.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage5.Location = new Point(7, 19);
            lblMissionpage5.Name = "lblMissionpage5";
            lblMissionpage5.Size = new Size(79, 16);
            lblMissionpage5.TabIndex = 0;
            lblMissionpage5.Text = "COMPLETED";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(53, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(866, 424);
            panel3.TabIndex = 0;
            // 
            // btnCreateMission
            // 
            btnCreateMission.BackColor = Color.FromArgb(234, 240, 240);
            btnCreateMission.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateMission.ForeColor = Color.FromArgb(11, 109, 126);
            btnCreateMission.Location = new Point(477, 138);
            btnCreateMission.Name = "btnCreateMission";
            btnCreateMission.Size = new Size(172, 29);
            btnCreateMission.TabIndex = 5;
            btnCreateMission.Text = "Create Mission";
            btnCreateMission.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 244, 244);
            textBox1.Location = new Point(725, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 6;
            // 
            // btnSEarch
            // 
            btnSEarch.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSEarch.ForeColor = Color.FromArgb(11, 109, 126);
            btnSEarch.Location = new Point(655, 138);
            btnSEarch.Name = "btnSEarch";
            btnSEarch.Size = new Size(67, 29);
            btnSEarch.TabIndex = 7;
            btnSEarch.Text = "Search";
            btnSEarch.UseVisualStyleBackColor = true;
            // 
            // MissionContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 240, 240);
            Controls.Add(btnSEarch);
            Controls.Add(textBox1);
            Controls.Add(btnCreateMission);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MissionContent";
            Size = new Size(936, 649);
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
        private Label lblMissionpage4;
        private Label lblMissionpage3;
        private Panel panel4;
        private Label lblMissionpage6;
        private Label lblMissionpage5;
        private Panel panel3;
        private Button btnCreateMission;
        private TextBox textBox1;
        private Button btnSEarch;
    }
}
