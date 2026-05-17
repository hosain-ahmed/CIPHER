namespace CIPHER.Forms.ADMINSTUFF.Content
{
    partial class ASummaryContent
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
            components = new System.ComponentModel.Container();
            pnlContent = new Panel();
            dgvUsers = new DataGridView();
            userBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btnLock = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            pnlUserDetails = new Panel();
            lblFactionID = new Label();
            lblXP = new Label();
            lblRole = new Label();
            lblCryptcoin = new Label();
            lblRank = new Label();
            lblStatus = new Label();
            lblUserID = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblCodeName = new Label();
            btnPromote = new Button();
            btnCreateUser = new Button();
            lblActiveRegistry = new Label();
            lblCurrentUser = new Label();
            panel4 = new Panel();
            lblMissionSolved = new Label();
            lblMS = new Label();
            lblLockedAccounts = new Label();
            lblActiveSessions = new Label();
            lblTotalUsers = new Label();
            lblLA = new Label();
            lblAS = new Label();
            lblTUS = new Label();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel2.SuspendLayout();
            pnlUserDetails.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ControlDark;
            pnlContent.Controls.Add(dgvUsers);
            pnlContent.Location = new Point(38, 189);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 509);
            pnlContent.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(700, 509);
            dgvUsers.TabIndex = 0;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnLock);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(pnlUserDetails);
            panel2.Controls.Add(btnPromote);
            panel2.Location = new Point(760, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 509);
            panel2.TabIndex = 2;
            // 
            // btnLock
            // 
            btnLock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLock.Location = new Point(16, 397);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(245, 23);
            btnLock.TabIndex = 4;
            btnLock.Text = "Unlock/Lock User";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Location = new Point(16, 465);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(245, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Location = new Point(141, 426);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 33);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset Progress";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // pnlUserDetails
            // 
            pnlUserDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUserDetails.BackColor = SystemColors.AppWorkspace;
            pnlUserDetails.Controls.Add(lblFactionID);
            pnlUserDetails.Controls.Add(lblXP);
            pnlUserDetails.Controls.Add(lblRole);
            pnlUserDetails.Controls.Add(lblCryptcoin);
            pnlUserDetails.Controls.Add(lblRank);
            pnlUserDetails.Controls.Add(lblStatus);
            pnlUserDetails.Controls.Add(lblUserID);
            pnlUserDetails.Controls.Add(lblEmail);
            pnlUserDetails.Controls.Add(lblFullName);
            pnlUserDetails.Controls.Add(lblCodeName);
            pnlUserDetails.Location = new Point(0, 0);
            pnlUserDetails.Name = "pnlUserDetails";
            pnlUserDetails.Size = new Size(278, 386);
            pnlUserDetails.TabIndex = 0;
            // 
            // lblFactionID
            // 
            lblFactionID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFactionID.AutoSize = true;
            lblFactionID.Location = new Point(16, 256);
            lblFactionID.Name = "lblFactionID";
            lblFactionID.Size = new Size(57, 15);
            lblFactionID.TabIndex = 9;
            lblFactionID.Text = "FactionID";
            // 
            // lblXP
            // 
            lblXP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblXP.AutoSize = true;
            lblXP.Location = new Point(16, 217);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(21, 15);
            lblXP.TabIndex = 8;
            lblXP.Text = "XP";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 138);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // lblCryptcoin
            // 
            lblCryptcoin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCryptcoin.AutoSize = true;
            lblCryptcoin.Location = new Point(16, 171);
            lblCryptcoin.Name = "lblCryptcoin";
            lblCryptcoin.Size = new Size(61, 15);
            lblCryptcoin.TabIndex = 6;
            lblCryptcoin.Text = "CryptCoin";
            // 
            // lblRank
            // 
            lblRank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRank.AutoSize = true;
            lblRank.Location = new Point(213, 14);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(33, 15);
            lblRank.TabIndex = 5;
            lblRank.Text = "Rank";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(169, 13);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblUserID
            // 
            lblUserID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(16, 13);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(41, 15);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "UserID";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(16, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(56, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Fullname";
            // 
            // lblCodeName
            // 
            lblCodeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCodeName.AutoSize = true;
            lblCodeName.Location = new Point(16, 43);
            lblCodeName.Name = "lblCodeName";
            lblCodeName.Size = new Size(65, 15);
            lblCodeName.TabIndex = 0;
            lblCodeName.Text = "Codename";
            // 
            // btnPromote
            // 
            btnPromote.Location = new Point(16, 426);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(119, 33);
            btnPromote.TabIndex = 2;
            btnPromote.Text = "Promote";
            btnPromote.UseVisualStyleBackColor = true;
            btnPromote.Click += btnPromote_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.None;
            btnCreateUser.Location = new Point(828, 10);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(170, 47);
            btnCreateUser.TabIndex = 0;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // lblActiveRegistry
            // 
            lblActiveRegistry.AutoSize = true;
            lblActiveRegistry.Location = new Point(35, 155);
            lblActiveRegistry.Name = "lblActiveRegistry";
            lblActiveRegistry.Size = new Size(85, 15);
            lblActiveRegistry.TabIndex = 3;
            lblActiveRegistry.Text = "Active Registry";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new Point(757, 143);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(73, 15);
            lblCurrentUser.TabIndex = 4;
            lblCurrentUser.Text = "Current User";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(lblMissionSolved);
            panel4.Controls.Add(lblMS);
            panel4.Controls.Add(lblLockedAccounts);
            panel4.Controls.Add(lblActiveSessions);
            panel4.Controls.Add(lblTotalUsers);
            panel4.Controls.Add(lblLA);
            panel4.Controls.Add(lblAS);
            panel4.Controls.Add(lblTUS);
            panel4.Controls.Add(btnCreateUser);
            panel4.Location = new Point(35, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(1003, 66);
            panel4.TabIndex = 5;
            // 
            // lblMissionSolved
            // 
            lblMissionSolved.AutoSize = true;
            lblMissionSolved.Location = new Point(646, 26);
            lblMissionSolved.Name = "lblMissionSolved";
            lblMissionSolved.Size = new Size(44, 15);
            lblMissionSolved.TabIndex = 8;
            lblMissionSolved.Text = "label10";
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.Location = new Point(554, 26);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(86, 15);
            lblMS.TabIndex = 7;
            lblMS.Text = "Mission Solved";
            // 
            // lblLockedAccounts
            // 
            lblLockedAccounts.AutoSize = true;
            lblLockedAccounts.Location = new Point(400, 26);
            lblLockedAccounts.Name = "lblLockedAccounts";
            lblLockedAccounts.Size = new Size(38, 15);
            lblLockedAccounts.TabIndex = 6;
            lblLockedAccounts.Text = "label8";
            // 
            // lblActiveSessions
            // 
            lblActiveSessions.AutoSize = true;
            lblActiveSessions.Location = new Point(237, 26);
            lblActiveSessions.Name = "lblActiveSessions";
            lblActiveSessions.Size = new Size(38, 15);
            lblActiveSessions.TabIndex = 5;
            lblActiveSessions.Text = "label7";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Location = new Point(80, 26);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(38, 15);
            lblTotalUsers.TabIndex = 4;
            lblTotalUsers.Text = "label6";
            // 
            // lblLA
            // 
            lblLA.AutoSize = true;
            lblLA.Location = new Point(296, 26);
            lblLA.Name = "lblLA";
            lblLA.Size = new Size(98, 15);
            lblLA.TabIndex = 3;
            lblLA.Text = "Locked Accounts";
            // 
            // lblAS
            // 
            lblAS.AutoSize = true;
            lblAS.Location = new Point(153, 26);
            lblAS.Name = "lblAS";
            lblAS.Size = new Size(87, 15);
            lblAS.TabIndex = 2;
            lblAS.Text = "Active Sessions";
            // 
            // lblTUS
            // 
            lblTUS.AutoSize = true;
            lblTUS.Location = new Point(25, 26);
            lblTUS.Name = "lblTUS";
            lblTUS.Size = new Size(64, 15);
            lblTUS.TabIndex = 1;
            lblTUS.Text = "Total Users";
            // 
            // ASummaryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(lblCurrentUser);
            Controls.Add(lblActiveRegistry);
            Controls.Add(panel2);
            Controls.Add(pnlContent);
            Name = "ASummaryContent";
            Size = new Size(1082, 750);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel2.ResumeLayout(false);
            pnlUserDetails.ResumeLayout(false);
            pnlUserDetails.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlContent;
        private Panel panel2;
        private Button btnCreateUser;
        private Button btnPromote;
        private Button btnReset;
        private Panel pnlUserDetails;
        private Label lblActiveRegistry;
        private Label lblCurrentUser;
        private Panel panel4;
        private Label lblAS;
        private Label lblTUS;
        private Label lblLockedAccounts;
        private Label lblActiveSessions;
        private Label lblTotalUsers;
        private Label lblLA;
        private Label lblMissionSolved;
        private Label lblMS;
        private Button btnDelete;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Label lblXP;
        private Label lblRole;
        private Label lblCryptcoin;
        private Label lblRank;
        private Label lblStatus;
        private Label lblUserID;
        private Label lblEmail;
        private Label lblFullName;
        private Label lblCodeName;
        private Label lblFactionID;
        private Button btnLock;
    }
}
