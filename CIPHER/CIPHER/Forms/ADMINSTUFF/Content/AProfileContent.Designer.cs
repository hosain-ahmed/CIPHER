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
            label1 = new Label();
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
            panel1.BackColor = Color.FromArgb(244, 247, 246);
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
            panel1.Location = new Point(57, 66);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 289);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnConfirmPass
            // 
            btnConfirmPass.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPass.Location = new Point(588, 248);
            btnConfirmPass.Margin = new Padding(3, 4, 3, 4);
            btnConfirmPass.Name = "btnConfirmPass";
            btnConfirmPass.Size = new Size(140, 31);
            btnConfirmPass.TabIndex = 12;
            btnConfirmPass.Text = "Change Password";
            btnConfirmPass.UseVisualStyleBackColor = true;
            btnConfirmPass.Click += btnConfirmPass_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(444, 250);
            txtConfirmPass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm Password";
            txtConfirmPass.Size = new Size(134, 26);
            txtConfirmPass.TabIndex = 11;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(319, 250);
            txtNewPass.Margin = new Padding(3, 4, 3, 4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PlaceholderText = "New Password";
            txtNewPass.Size = new Size(114, 26);
            txtNewPass.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(736, 248);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(191, 249);
            txtOldPass.Margin = new Padding(3, 4, 3, 4);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PlaceholderText = "Old Password";
            txtOldPass.Size = new Size(114, 27);
            txtOldPass.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 182);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 7;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 114);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.FlatStyle = FlatStyle.Flat;
            lblPassword.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Teal;
            lblPassword.Location = new Point(29, 251);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Teal;
            lblEmail.Location = new Point(32, 183);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.Teal;
            lblUserID.Location = new Point(603, 53);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(69, 21);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User_ID";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Teal;
            lblStatus.Location = new Point(702, 53);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 21);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.FlatStyle = FlatStyle.Flat;
            lblFullname.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.Teal;
            lblFullname.Location = new Point(29, 114);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(89, 21);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "Full Name";
            lblFullname.Click += lblFullname_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(244, 247, 246);
            lblName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(29, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 24);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(244, 247, 246);
            panel2.Controls.Add(lblSuccessRate);
            panel2.Controls.Add(lblMissionCompletion);
            panel2.Location = new Point(925, 68);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 287);
            panel2.TabIndex = 1;
            // 
            // lblSuccessRate
            // 
            lblSuccessRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSuccessRate.AutoSize = true;
            lblSuccessRate.FlatStyle = FlatStyle.Flat;
            lblSuccessRate.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuccessRate.Location = new Point(252, 246);
            lblSuccessRate.Name = "lblSuccessRate";
            lblSuccessRate.Size = new Size(112, 21);
            lblSuccessRate.TabIndex = 1;
            lblSuccessRate.Text = "Success Rate";
            // 
            // lblMissionCompletion
            // 
            lblMissionCompletion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMissionCompletion.AutoSize = true;
            lblMissionCompletion.FlatStyle = FlatStyle.Flat;
            lblMissionCompletion.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionCompletion.Location = new Point(24, 247);
            lblMissionCompletion.Name = "lblMissionCompletion";
            lblMissionCompletion.Size = new Size(154, 21);
            lblMissionCompletion.TabIndex = 0;
            lblMissionCompletion.Text = "Mission Completed";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(244, 247, 246);
            panel3.Controls.Add(lblXP);
            panel3.Location = new Point(925, 392);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 133);
            panel3.TabIndex = 2;
            // 
            // lblXP
            // 
            lblXP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblXP.AutoSize = true;
            lblXP.FlatStyle = FlatStyle.Flat;
            lblXP.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXP.Location = new Point(24, 48);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(31, 21);
            lblXP.TabIndex = 0;
            lblXP.Text = "XP";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(244, 247, 246);
            panel4.Controls.Add(lblCryptcoin);
            panel4.Location = new Point(1149, 392);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 133);
            panel4.TabIndex = 3;
            // 
            // lblCryptcoin
            // 
            lblCryptcoin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCryptcoin.AutoSize = true;
            lblCryptcoin.FlatStyle = FlatStyle.Flat;
            lblCryptcoin.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCryptcoin.Location = new Point(19, 48);
            lblCryptcoin.Name = "lblCryptcoin";
            lblCryptcoin.Size = new Size(80, 21);
            lblCryptcoin.TabIndex = 0;
            lblCryptcoin.Text = "Cryptocoin";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(244, 247, 246);
            panel5.Controls.Add(lblAchievements);
            panel5.Location = new Point(57, 392);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(835, 133);
            panel5.TabIndex = 4;
            // 
            // lblAchievements
            // 
            lblAchievements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAchievements.AutoSize = true;
            lblAchievements.Location = new Point(305, 59);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(202, 20);
            lblAchievements.TabIndex = 0;
            lblAchievements.Text = "Achievements : Coming Soon";
            lblAchievements.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.DarkGray;
            panel6.Controls.Add(lblGraph);
            panel6.Location = new Point(57, 564);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1283, 425);
            panel6.TabIndex = 5;
            // 
            // lblGraph
            // 
            lblGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGraph.AutoSize = true;
            lblGraph.Location = new Point(736, 227);
            lblGraph.Name = "lblGraph";
            lblGraph.Size = new Size(234, 20);
            lblGraph.TabIndex = 0;
            lblGraph.Text = "Progress Visualizaer Coming Soon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 41);
            label1.TabIndex = 6;
            label1.Text = "PROFILE";
            // 
            // AProfileContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AProfileContent";
            Size = new Size(1422, 1039);
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
            PerformLayout();
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
        private Label label1;
    }
}
