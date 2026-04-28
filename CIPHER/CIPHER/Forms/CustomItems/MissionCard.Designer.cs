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
            lblDescription = new Label();
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
            lblID.BackColor = Color.Black;
            lblID.ForeColor = SystemColors.ControlLightLight;
            lblID.Location = new Point(146, 36);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 15);
            lblID.TabIndex = 1;
            lblID.Text = "lblID";
            lblID.Click += OpenMissionDetails;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Black;
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(23, 36);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            lblStatus.Click += OpenMissionDetails;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Black;
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(23, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "lblTitle";
            lblTitle.Click += OpenMissionDetails;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Black;
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(65, 161);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(80, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "lblDescription";
            lblDescription.Click += OpenMissionDetails;
            // 
            // lblReward
            // 
            lblReward.AutoSize = true;
            lblReward.BackColor = Color.Black;
            lblReward.ForeColor = SystemColors.ControlLightLight;
            lblReward.Location = new Point(131, 123);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(46, 15);
            lblReward.TabIndex = 5;
            lblReward.Text = "Reward";
            lblReward.Click += OpenMissionDetails;
            // 
            // lblDDifficulty
            // 
            lblDDifficulty.AutoSize = true;
            lblDDifficulty.ForeColor = SystemColors.ControlLightLight;
            lblDDifficulty.Location = new Point(23, 99);
            lblDDifficulty.Name = "lblDDifficulty";
            lblDDifficulty.Size = new Size(55, 15);
            lblDDifficulty.TabIndex = 6;
            lblDDifficulty.Text = "Difficulty";
            // 
            // lblDReward
            // 
            lblDReward.AutoSize = true;
            lblDReward.ForeColor = SystemColors.ControlLightLight;
            lblDReward.Location = new Point(23, 123);
            lblDReward.Name = "lblDReward";
            lblDReward.Size = new Size(46, 15);
            lblDReward.TabIndex = 7;
            lblDReward.Text = "Reward";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.ForeColor = SystemColors.ControlLightLight;
            lblDifficulty.Location = new Point(131, 99);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(55, 15);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "Difficulty";
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Location = new Point(6, 114);
            label1.Name = "label1";
            label1.Size = new Size(180, 1);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Location = new Point(6, 138);
            label2.Name = "label2";
            label2.Size = new Size(180, 1);
            label2.TabIndex = 10;
            // 
            // MissionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDifficulty);
            Controls.Add(lblDReward);
            Controls.Add(lblDDifficulty);
            Controls.Add(lblReward);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblID);
            Name = "MissionCard";
            Size = new Size(213, 192);
            Click += OpenMissionDetails;
            MouseEnter += MissionCard_MouseEnter;
            MouseLeave += MissionCard_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private Label lblStatus;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblReward;
        private Label lblDDifficulty;
        private Label lblDReward;
        private Label lblDifficulty;
        private Label label1;
        private Label label2;
    }
}
