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
            pnlContent.Location = new Point(43, 252);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 679);
            pnlContent.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvUsers.BackgroundColor = Color.FromArgb(244, 247, 246);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(800, 679);
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
            panel2.Location = new Point(869, 252);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 679);
            panel2.TabIndex = 2;
            // 
            // btnLock
            // 
            btnLock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLock.BackColor = Color.Teal;
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLock.ForeColor = Color.White;
            btnLock.Location = new Point(18, 525);
            btnLock.Margin = new Padding(3, 4, 3, 4);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(280, 31);
            btnLock.TabIndex = 4;
            btnLock.Text = "Unlock/Lock User";
            btnLock.UseVisualStyleBackColor = false;
            btnLock.Click += btnLock_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Teal;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(18, 620);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = Color.Teal;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(161, 564);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 48);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset Progress";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // pnlUserDetails
            // 
            pnlUserDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUserDetails.BackColor = Color.FromArgb(244, 247, 246);
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
            pnlUserDetails.Margin = new Padding(3, 4, 3, 4);
            pnlUserDetails.Name = "pnlUserDetails";
            pnlUserDetails.Size = new Size(318, 515);
            pnlUserDetails.TabIndex = 0;
            // 
            // lblFactionID
            // 
            lblFactionID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFactionID.AutoSize = true;
            lblFactionID.FlatStyle = FlatStyle.Flat;
            lblFactionID.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFactionID.ForeColor = Color.DimGray;
            lblFactionID.Location = new Point(18, 313);
            lblFactionID.Name = "lblFactionID";
            lblFactionID.Size = new Size(70, 18);
            lblFactionID.TabIndex = 9;
            lblFactionID.Text = "FactionID";
            // 
            // lblXP
            // 
            lblXP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblXP.AutoSize = true;
            lblXP.FlatStyle = FlatStyle.Flat;
            lblXP.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXP.ForeColor = Color.DimGray;
            lblXP.Location = new Point(18, 267);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(26, 18);
            lblXP.TabIndex = 8;
            lblXP.Text = "XP";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.FlatStyle = FlatStyle.Flat;
            lblRole.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.DimGray;
            lblRole.Location = new Point(18, 179);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 18);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // lblCryptcoin
            // 
            lblCryptcoin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCryptcoin.AutoSize = true;
            lblCryptcoin.FlatStyle = FlatStyle.Flat;
            lblCryptcoin.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCryptcoin.ForeColor = Color.DimGray;
            lblCryptcoin.Location = new Point(18, 223);
            lblCryptcoin.Name = "lblCryptcoin";
            lblCryptcoin.Size = new Size(72, 18);
            lblCryptcoin.TabIndex = 6;
            lblCryptcoin.Text = "CryptCoin";
            lblCryptcoin.Click += lblCryptcoin_Click;
            // 
            // lblRank
            // 
            lblRank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRank.AutoSize = true;
            lblRank.FlatStyle = FlatStyle.Flat;
            lblRank.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRank.ForeColor = Color.DimGray;
            lblRank.Location = new Point(226, 55);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(42, 18);
            lblRank.TabIndex = 5;
            lblRank.Text = "Rank";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(226, 16);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(51, 18);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblUserID
            // 
            lblUserID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUserID.AutoSize = true;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.DimGray;
            lblUserID.Location = new Point(18, 17);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(61, 18);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User_ID";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(18, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 18);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFullName.AutoSize = true;
            lblFullName.FlatStyle = FlatStyle.Flat;
            lblFullName.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.DimGray;
            lblFullName.Location = new Point(18, 100);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(69, 18);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Fullname";
            // 
            // lblCodeName
            // 
            lblCodeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCodeName.AutoSize = true;
            lblCodeName.FlatStyle = FlatStyle.Flat;
            lblCodeName.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodeName.ForeColor = Color.DimGray;
            lblCodeName.Location = new Point(18, 57);
            lblCodeName.Name = "lblCodeName";
            lblCodeName.Size = new Size(78, 18);
            lblCodeName.TabIndex = 0;
            lblCodeName.Text = "Codename";
            // 
            // btnPromote
            // 
            btnPromote.BackColor = Color.Teal;
            btnPromote.FlatStyle = FlatStyle.Flat;
            btnPromote.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromote.ForeColor = Color.White;
            btnPromote.Location = new Point(18, 564);
            btnPromote.Margin = new Padding(3, 4, 3, 4);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(136, 48);
            btnPromote.TabIndex = 2;
            btnPromote.Text = "Promote";
            btnPromote.UseVisualStyleBackColor = false;
            btnPromote.Click += btnPromote_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateUser.BackColor = Color.Teal;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(946, 13);
            btnCreateUser.Margin = new Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(194, 63);
            btnCreateUser.TabIndex = 0;
            btnCreateUser.Text = "Create User+";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // lblActiveRegistry
            // 
            lblActiveRegistry.AutoSize = true;
            lblActiveRegistry.FlatStyle = FlatStyle.Flat;
            lblActiveRegistry.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveRegistry.ForeColor = Color.Teal;
            lblActiveRegistry.Location = new Point(40, 207);
            lblActiveRegistry.Name = "lblActiveRegistry";
            lblActiveRegistry.Size = new Size(168, 28);
            lblActiveRegistry.TabIndex = 3;
            lblActiveRegistry.Text = "Active Registry";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.Teal;
            lblCurrentUser.Location = new Point(869, 207);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(147, 28);
            lblCurrentUser.TabIndex = 4;
            lblCurrentUser.Text = "Current User";
            lblCurrentUser.Click += lblCurrentUser_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblMissionSolved);
            panel4.Controls.Add(lblMS);
            panel4.Controls.Add(lblLockedAccounts);
            panel4.Controls.Add(lblActiveSessions);
            panel4.Controls.Add(lblTotalUsers);
            panel4.Controls.Add(lblLA);
            panel4.Controls.Add(lblAS);
            panel4.Controls.Add(lblTUS);
            panel4.Controls.Add(btnCreateUser);
            panel4.Location = new Point(40, 47);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1146, 88);
            panel4.TabIndex = 5;
            // 
            // lblMissionSolved
            // 
            lblMissionSolved.AutoSize = true;
            lblMissionSolved.FlatStyle = FlatStyle.Flat;
            lblMissionSolved.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionSolved.Location = new Point(660, 32);
            lblMissionSolved.Name = "lblMissionSolved";
            lblMissionSolved.Size = new Size(28, 24);
            lblMissionSolved.TabIndex = 8;
            lblMissionSolved.Text = "10";
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.FlatStyle = FlatStyle.Flat;
            lblMS.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMS.ForeColor = Color.Gray;
            lblMS.Location = new Point(544, 36);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(109, 18);
            lblMS.TabIndex = 7;
            lblMS.Text = "Mission Solved";
            // 
            // lblLockedAccounts
            // 
            lblLockedAccounts.AutoSize = true;
            lblLockedAccounts.FlatStyle = FlatStyle.Flat;
            lblLockedAccounts.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLockedAccounts.Location = new Point(475, 31);
            lblLockedAccounts.Name = "lblLockedAccounts";
            lblLockedAccounts.Size = new Size(27, 24);
            lblLockedAccounts.TabIndex = 6;
            lblLockedAccounts.Text = "12";
            // 
            // lblActiveSessions
            // 
            lblActiveSessions.AutoSize = true;
            lblActiveSessions.FlatStyle = FlatStyle.Flat;
            lblActiveSessions.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveSessions.Location = new Point(280, 30);
            lblActiveSessions.Name = "lblActiveSessions";
            lblActiveSessions.Size = new Size(42, 24);
            lblActiveSessions.TabIndex = 5;
            lblActiveSessions.Text = "650";
            lblActiveSessions.Click += lblActiveSessions_Click;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.FlatStyle = FlatStyle.Flat;
            lblTotalUsers.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.Location = new Point(96, 30);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(60, 24);
            lblTotalUsers.TabIndex = 4;
            lblTotalUsers.Text = "12000";
            // 
            // lblLA
            // 
            lblLA.AutoSize = true;
            lblLA.FlatStyle = FlatStyle.Flat;
            lblLA.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLA.ForeColor = Color.Gray;
            lblLA.Location = new Point(351, 34);
            lblLA.Name = "lblLA";
            lblLA.Size = new Size(121, 18);
            lblLA.TabIndex = 3;
            lblLA.Text = "Locked Accounts";
            // 
            // lblAS
            // 
            lblAS.AutoSize = true;
            lblAS.FlatStyle = FlatStyle.Flat;
            lblAS.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAS.ForeColor = Color.Gray;
            lblAS.Location = new Point(165, 34);
            lblAS.Name = "lblAS";
            lblAS.Size = new Size(115, 18);
            lblAS.TabIndex = 2;
            lblAS.Text = "Active Sessions";
            // 
            // lblTUS
            // 
            lblTUS.AutoSize = true;
            lblTUS.FlatStyle = FlatStyle.Flat;
            lblTUS.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTUS.ForeColor = Color.Gray;
            lblTUS.Location = new Point(14, 35);
            lblTUS.Name = "lblTUS";
            lblTUS.Size = new Size(83, 18);
            lblTUS.TabIndex = 1;
            lblTUS.Text = "Total Users";
            // 
            // ASummaryContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Controls.Add(lblCurrentUser);
            Controls.Add(lblActiveRegistry);
            Controls.Add(panel2);
            Controls.Add(pnlContent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ASummaryContent";
            Size = new Size(1237, 1000);
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
