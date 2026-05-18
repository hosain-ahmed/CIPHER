namespace CIPHER.Forms.CustomItems
{
    partial class MissionCard
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
            lblID = new Label();
            lblStatus = new Label();
            lblTitle = new Label();
            lblReward = new Label();
            lblDDifficulty = new Label();
            lblDReward = new Label();
            lblDifficulty = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.White;
            lblID.FlatStyle = FlatStyle.Flat;
            lblID.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblID.ForeColor = Color.Teal;
            lblID.Location = new Point(146, 29);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 19);
            lblID.TabIndex = 1;
            lblID.Text = "lblID";
            lblID.Click += OpenMissionDetails;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Teal;
            lblStatus.Location = new Point(23, 28);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(87, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            lblStatus.Click += OpenMissionDetails;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(23, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 19);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "lblTitle";
            lblTitle.Click += OpenMissionDetails;
            // 
            // lblReward
            // 
            lblReward.AutoSize = true;
            lblReward.BackColor = Color.White;
            lblReward.FlatStyle = FlatStyle.Flat;
            lblReward.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblReward.ForeColor = Color.Teal;
            lblReward.Location = new Point(131, 119);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(65, 19);
            lblReward.TabIndex = 5;
            lblReward.Text = "Reward";
            lblReward.Click += OpenMissionDetails;
            // 
            // lblDDifficulty
            // 
            lblDDifficulty.AutoSize = true;
            lblDDifficulty.BackColor = Color.White;
            lblDDifficulty.FlatStyle = FlatStyle.Flat;
            lblDDifficulty.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblDDifficulty.ForeColor = Color.Teal;
            lblDDifficulty.Location = new Point(23, 95);
            lblDDifficulty.Name = "lblDDifficulty";
            lblDDifficulty.Size = new Size(73, 19);
            lblDDifficulty.TabIndex = 6;
            lblDDifficulty.Text = "Difficulty";
            // 
            // lblDReward
            // 
            lblDReward.AutoSize = true;
            lblDReward.BackColor = Color.White;
            lblDReward.FlatStyle = FlatStyle.Flat;
            lblDReward.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblDReward.ForeColor = Color.Teal;
            lblDReward.Location = new Point(23, 119);
            lblDReward.Name = "lblDReward";
            lblDReward.Size = new Size(65, 19);
            lblDReward.TabIndex = 7;
            lblDReward.Text = "Reward";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.BackColor = Color.White;
            lblDifficulty.FlatStyle = FlatStyle.Flat;
            lblDifficulty.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblDifficulty.ForeColor = Color.Teal;
            lblDifficulty.Location = new Point(128, 95);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(73, 19);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "Difficulty";
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Location = new Point(14, 114);
            label1.Name = "label1";
            label1.Size = new Size(180, 1);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Location = new Point(15, 138);
            label2.Name = "label2";
            label2.Size = new Size(180, 1);
            label2.TabIndex = 10;
            // 
            // MissionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDifficulty);
            Controls.Add(lblDReward);
            Controls.Add(lblDDifficulty);
            Controls.Add(lblReward);
            Controls.Add(lblTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblID);
            Name = "MissionCard";
            Size = new Size(213, 192);
            Click += OpenMissionDetails;
            MouseEnter += MissionCard_MouseEnter;
            MouseLeave += MissionCard_MouseLeave;
            MouseHover += MissionCard_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private Label lblStatus;
        private Label lblTitle;
        private Label lblReward;
        private Label lblDDifficulty;
        private Label lblDReward;
        private Label lblDifficulty;
        private Label label1;
        private Label label2;
    }
}
