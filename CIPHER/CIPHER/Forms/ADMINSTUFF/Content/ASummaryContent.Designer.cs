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
            lblFailedMissions = new Label();
            lblTopAgent = new Label();
            lblTotalUsers = new Label();
            lblMF = new Label();
            lblTA = new Label();
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
            dgvUsers.BackgroundColor = Color.FromArgb(244, 247, 246);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
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
            btnLock.BackColor = Color.Teal;
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLock.ForeColor = Color.White;
            btnLock.Location = new Point(16, 394);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(245, 23);
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
            btnDelete.Location = new Point(16, 465);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(245, 32);
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
            btnReset.Location = new Point(141, 423);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 36);
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
            pnlUserDetails.Name = "pnlUserDetails";
            pnlUserDetails.Size = new Size(278, 386);
            pnlUserDetails.TabIndex = 0;
            // 
            // lblFactionID
            // 
            lblFactionID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFactionID.AutoSize = true;
            lblFactionID.FlatStyle = FlatStyle.Flat;
            lblFactionID.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFactionID.ForeColor = Color.DimGray;
            lblFactionID.Location = new Point(16, 235);
            lblFactionID.Name = "lblFactionID";
            lblFactionID.Size = new Size(58, 14);
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
            lblXP.Location = new Point(16, 200);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(21, 14);
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
            lblRole.Location = new Point(16, 134);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(31, 14);
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
            lblCryptcoin.Location = new Point(16, 167);
            lblCryptcoin.Name = "lblCryptcoin";
            lblCryptcoin.Size = new Size(60, 14);
            lblCryptcoin.TabIndex = 6;
            lblCryptcoin.Text = "CryptCoin";
            // 
            // lblRank
            // 
            lblRank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRank.AutoSize = true;
            lblRank.FlatStyle = FlatStyle.Flat;
            lblRank.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRank.ForeColor = Color.DimGray;
            lblRank.Location = new Point(198, 41);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(34, 14);
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
            lblStatus.Location = new Point(198, 12);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(41, 14);
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
            lblUserID.Location = new Point(16, 13);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 14);
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
            lblEmail.Location = new Point(16, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 14);
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
            lblFullName.Location = new Point(16, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(56, 14);
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
            lblCodeName.Location = new Point(16, 43);
            lblCodeName.Name = "lblCodeName";
            lblCodeName.Size = new Size(62, 14);
            lblCodeName.TabIndex = 0;
            lblCodeName.Text = "Codename";
            // 
            // btnPromote
            // 
            btnPromote.BackColor = Color.Teal;
            btnPromote.FlatStyle = FlatStyle.Flat;
            btnPromote.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromote.ForeColor = Color.White;
            btnPromote.Location = new Point(16, 423);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(119, 36);
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
            btnCreateUser.Location = new Point(816, 8);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(170, 47);
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
            lblActiveRegistry.Location = new Point(35, 155);
            lblActiveRegistry.Name = "lblActiveRegistry";
            lblActiveRegistry.Size = new Size(137, 23);
            lblActiveRegistry.TabIndex = 3;
            lblActiveRegistry.Text = "Active Registry";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.Teal;
            lblCurrentUser.Location = new Point(760, 155);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(121, 23);
            lblCurrentUser.TabIndex = 4;
            lblCurrentUser.Text = "Current User";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblMissionSolved);
            panel4.Controls.Add(lblMS);
            panel4.Controls.Add(lblFailedMissions);
            panel4.Controls.Add(lblTopAgent);
            panel4.Controls.Add(lblTotalUsers);
            panel4.Controls.Add(lblMF);
            panel4.Controls.Add(lblTA);
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
            lblMissionSolved.FlatStyle = FlatStyle.Flat;
            lblMissionSolved.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionSolved.Location = new Point(578, 24);
            lblMissionSolved.Name = "lblMissionSolved";
            lblMissionSolved.Size = new Size(0, 19);
            lblMissionSolved.TabIndex = 8;
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.FlatStyle = FlatStyle.Flat;
            lblMS.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMS.ForeColor = Color.Gray;
            lblMS.Location = new Point(476, 27);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(86, 14);
            lblMS.TabIndex = 7;
            lblMS.Text = "Mission Solved";
            // 
            // lblFailedMissions
            // 
            lblFailedMissions.AutoSize = true;
            lblFailedMissions.FlatStyle = FlatStyle.Flat;
            lblFailedMissions.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFailedMissions.Location = new Point(416, 23);
            lblFailedMissions.Name = "lblFailedMissions";
            lblFailedMissions.Size = new Size(0, 19);
            lblFailedMissions.TabIndex = 6;
            // 
            // lblTopAgent
            // 
            lblTopAgent.AutoSize = true;
            lblTopAgent.FlatStyle = FlatStyle.Flat;
            lblTopAgent.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopAgent.Location = new Point(245, 22);
            lblTopAgent.Name = "lblTopAgent";
            lblTopAgent.Size = new Size(0, 19);
            lblTopAgent.TabIndex = 5;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.FlatStyle = FlatStyle.Flat;
            lblTotalUsers.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.Location = new Point(84, 22);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(0, 19);
            lblTotalUsers.TabIndex = 4;
            // 
            // lblMF
            // 
            lblMF.AutoSize = true;
            lblMF.FlatStyle = FlatStyle.Flat;
            lblMF.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMF.ForeColor = Color.Gray;
            lblMF.Location = new Point(284, 26);
            lblMF.Name = "lblMF";
            lblMF.Size = new Size(117, 14);
            lblMF.TabIndex = 3;
            lblMF.Text = "Most Failed Missions";
            // 
            // lblTA
            // 
            lblTA.AutoSize = true;
            lblTA.FlatStyle = FlatStyle.Flat;
            lblTA.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTA.ForeColor = Color.Gray;
            lblTA.Location = new Point(144, 26);
            lblTA.Name = "lblTA";
            lblTA.Size = new Size(60, 14);
            lblTA.TabIndex = 2;
            lblTA.Text = "Top Agent";
            // 
            // lblTUS
            // 
            lblTUS.AutoSize = true;
            lblTUS.FlatStyle = FlatStyle.Flat;
            lblTUS.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTUS.ForeColor = Color.Gray;
            lblTUS.Location = new Point(12, 26);
            lblTUS.Name = "lblTUS";
            lblTUS.Size = new Size(66, 14);
            lblTUS.TabIndex = 1;
            lblTUS.Text = "Total Users";
            // 
            // ASummaryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private Label lblTA;
        private Label lblTUS;
        private Label lblFailedMissions;
        private Label lblTopAgent;
        private Label lblTotalUsers;
        private Label lblMF;
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
