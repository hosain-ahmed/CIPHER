using CIPHER.Helpers;

namespace CIPHER.Forms.ADMINSTUFF.Content
{
    partial class AProfileContent
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
            btnConfirmPass = new Button();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            btnEdit = new Button();
            txtOldPass = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUserID = new Label();
            lblStatus = new Label();
            lblFullname = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblSuccessRate = new Label();
            lblMissionCompletion = new Label();
            panel3 = new Panel();
            lblXP = new Label();
            panel4 = new Panel();
            lblCryptcoin = new Label();
            panel5 = new Panel();
            lblAchievements = new Label();
            panel6 = new Panel();
            lblGraph = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirmPass);
            panel1.Controls.Add(txtConfirmPass);
            panel1.Controls.Add(txtNewPass);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(txtOldPass);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblUserID);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblFullname);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(50, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 217);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnConfirmPass
            // 
            btnConfirmPass.Location = new Point(531, 193);
            btnConfirmPass.Name = "btnConfirmPass";
            btnConfirmPass.Size = new Size(75, 23);
            btnConfirmPass.TabIndex = 12;
            btnConfirmPass.Text = "Change";
            btnConfirmPass.UseVisualStyleBackColor = true;
            btnConfirmPass.Click += btnConfirmPass_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(411, 188);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm Pass";
            txtConfirmPass.Size = new Size(100, 23);
            txtConfirmPass.TabIndex = 11;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(283, 186);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PlaceholderText = "New Pass";
            txtNewPass.Size = new Size(100, 23);
            txtNewPass.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(644, 187);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(154, 183);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PlaceholderText = "Old Pass";
            txtOldPass.Size = new Size(100, 23);
            txtOldPass.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(38, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "label6";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "label5";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(583, 40);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(38, 15);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "label4";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(664, 39);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "label3";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(28, 89);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(38, 15);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "label2";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSuccessRate);
            panel2.Controls.Add(lblMissionCompletion);
            panel2.Location = new Point(809, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 215);
            panel2.TabIndex = 1;
            // 
            // lblSuccessRate
            // 
            lblSuccessRate.AutoSize = true;
            lblSuccessRate.Location = new Point(223, 174);
            lblSuccessRate.Name = "lblSuccessRate";
            lblSuccessRate.Size = new Size(44, 15);
            lblSuccessRate.TabIndex = 1;
            lblSuccessRate.Text = "label10";
            // 
            // lblMissionCompletion
            // 
            lblMissionCompletion.AutoSize = true;
            lblMissionCompletion.Location = new Point(20, 176);
            lblMissionCompletion.Name = "lblMissionCompletion";
            lblMissionCompletion.Size = new Size(38, 15);
            lblMissionCompletion.TabIndex = 0;
            lblMissionCompletion.Text = "label9";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblXP);
            panel3.Location = new Point(809, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 100);
            panel3.TabIndex = 2;
            // 
            // lblXP
            // 
            lblXP.AutoSize = true;
            lblXP.Location = new Point(78, 48);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(44, 15);
            lblXP.TabIndex = 0;
            lblXP.Text = "label11";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCryptcoin);
            panel4.Location = new Point(1005, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 100);
            panel4.TabIndex = 3;
            // 
            // lblCryptcoin
            // 
            lblCryptcoin.AutoSize = true;
            lblCryptcoin.Location = new Point(72, 44);
            lblCryptcoin.Name = "lblCryptcoin";
            lblCryptcoin.Size = new Size(44, 15);
            lblCryptcoin.TabIndex = 0;
            lblCryptcoin.Text = "label12";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblAchievements);
            panel5.Location = new Point(50, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(731, 100);
            panel5.TabIndex = 4;
            // 
            // lblAchievements
            // 
            lblAchievements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAchievements.AutoSize = true;
            lblAchievements.Location = new Point(267, 44);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(164, 15);
            lblAchievements.TabIndex = 0;
            lblAchievements.Text = "Achievements : Coming Soon";
            lblAchievements.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblGraph);
            panel6.Location = new Point(50, 423);
            panel6.Name = "panel6";
            panel6.Size = new Size(1123, 319);
            panel6.TabIndex = 5;
            // 
            // lblGraph
            // 
            lblGraph.AutoSize = true;
            lblGraph.Location = new Point(477, 154);
            lblGraph.Name = "lblGraph";
            lblGraph.Size = new Size(186, 15);
            lblGraph.TabIndex = 0;
            lblGraph.Text = "Progress Visualizaer Coming Soon";
            // 
            // AProfileContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AProfileContent";
            Size = new Size(1244, 779);
            Load += AProfileContent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblUserID;
        private Label lblStatus;
        private Label lblFullname;
        private Label lblName;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtOldPass;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblSuccessRate;
        private Label lblMissionCompletion;
        private Label lblXP;
        private Label lblCryptcoin;
        private Label lblAchievements;
        private Label lblGraph;
        private Button btnEdit;
        private Button btnConfirmPass;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
    }
}
