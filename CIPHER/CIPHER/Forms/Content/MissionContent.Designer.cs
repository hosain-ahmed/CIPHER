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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(758, 318);
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
            lblMissionpage2.Click += lblMissionpage2_Click;
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
            panel1.Paint += panel1_Paint;
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
            lblMissionPage1.Click += lblMissionPage1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 244, 247);
            panel2.Controls.Add(lblMissionpage4);
            panel2.Controls.Add(lblMissionpage3);
            panel2.Location = new Point(622, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 60);
            panel2.TabIndex = 2;
            // 
            // lblMissionpage4
            // 
            lblMissionpage4.AutoSize = true;
            lblMissionpage4.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage4.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionpage4.Location = new Point(19, 29);
            lblMissionpage4.Name = "lblMissionpage4";
            lblMissionpage4.Size = new Size(44, 17);
            lblMissionpage4.TabIndex = 1;
            lblMissionpage4.Text = "12450";
            // 
            // lblMissionpage3
            // 
            lblMissionpage3.AutoSize = true;
            lblMissionpage3.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage3.Location = new Point(12, 14);
            lblMissionpage3.Name = "lblMissionpage3";
            lblMissionpage3.Size = new Size(49, 12);
            lblMissionpage3.TabIndex = 0;
            lblMissionpage3.Text = "TOTAL_XP";
            lblMissionpage3.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 244, 247);
            panel4.Controls.Add(lblMissionpage6);
            panel4.Controls.Add(lblMissionpage5);
            panel4.Location = new Point(724, 31);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(80, 60);
            panel4.TabIndex = 4;
            // 
            // lblMissionpage6
            // 
            lblMissionpage6.AutoSize = true;
            lblMissionpage6.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage6.ForeColor = Color.FromArgb(11, 109, 126);
            lblMissionpage6.Location = new Point(21, 30);
            lblMissionpage6.Name = "lblMissionpage6";
            lblMissionpage6.Size = new Size(0, 17);
            lblMissionpage6.TabIndex = 1;
            // 
            // lblMissionpage5
            // 
            lblMissionpage5.AutoSize = true;
            lblMissionpage5.Font = new Font("Bahnschrift SemiBold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionpage5.Location = new Point(6, 14);
            lblMissionpage5.Name = "lblMissionpage5";
            lblMissionpage5.Size = new Size(61, 12);
            lblMissionpage5.TabIndex = 0;
            lblMissionpage5.Text = "COMPLETED";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(46, 141);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 318);
            panel3.TabIndex = 0;
            // 
            // btnCreateMission
            // 
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
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 244, 244);
            textBox1.Location = new Point(634, 104);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 6;
            // 
            // btnSEarch
            // 
            btnSEarch.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSEarch.ForeColor = Color.FromArgb(11, 109, 126);
            btnSEarch.Location = new Point(573, 104);
            btnSEarch.Margin = new Padding(3, 2, 3, 2);
            btnSEarch.Name = "btnSEarch";
            btnSEarch.Size = new Size(59, 22);
            btnSEarch.TabIndex = 7;
            btnSEarch.Text = "Search";
            btnSEarch.UseVisualStyleBackColor = true;
            // 
            // MissionContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 240, 240);
            Controls.Add(btnSEarch);
            Controls.Add(textBox1);
            Controls.Add(btnCreateMission);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MissionContent";
            Size = new Size(819, 487);
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
