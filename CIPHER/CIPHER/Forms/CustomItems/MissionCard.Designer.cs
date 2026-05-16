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
            lblID.Location = new Point(167, 48);
            lblID.Name = "lblID";
            lblID.Size = new Size(41, 20);
            lblID.TabIndex = 1;
            lblID.Text = "lblID";
            lblID.Click += OpenMissionDetails;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Black;
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(26, 48);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            lblStatus.Click += OpenMissionDetails;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Black;
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(26, 87);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "lblTitle";
            lblTitle.Click += OpenMissionDetails;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.White;
            lblDescription.ForeColor = Color.FromArgb(4, 159, 182);
            lblDescription.Location = new Point(74, 215);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "lblDescription";
            lblDescription.Click += OpenMissionDetails;
            // 
            // lblReward
            // 
            lblReward.AutoSize = true;
            lblReward.ForeColor = Color.FromArgb(4, 159, 182);
            lblReward.Location = new Point(150, 164);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(59, 20);
            lblReward.TabIndex = 5;
            lblReward.Text = "Reward";
            lblReward.Click += OpenMissionDetails;
            // 
            // lblDDifficulty
            // 
            lblDDifficulty.AutoSize = true;
            lblDDifficulty.ForeColor = Color.Black;
            lblDDifficulty.Location = new Point(26, 132);
            lblDDifficulty.Name = "lblDDifficulty";
            lblDDifficulty.Size = new Size(69, 20);
            lblDDifficulty.TabIndex = 6;
            lblDDifficulty.Text = "Difficulty";
            // 
            // lblDReward
            // 
            lblDReward.AutoSize = true;
            lblDReward.ForeColor = Color.Black;
            lblDReward.Location = new Point(26, 164);
            lblDReward.Name = "lblDReward";
            lblDReward.Size = new Size(59, 20);
            lblDReward.TabIndex = 7;
            lblDReward.Text = "Reward";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.ForeColor = Color.FromArgb(4, 159, 182);
            lblDifficulty.Location = new Point(150, 132);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(69, 20);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "Difficulty";
            lblDifficulty.Click += lblDifficulty_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Location = new Point(7, 152);
            label1.Name = "label1";
            label1.Size = new Size(206, 1);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Location = new Point(7, 184);
            label2.Name = "label2";
            label2.Size = new Size(206, 1);
            label2.TabIndex = 10;
            // 
            // MissionCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.None;
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MissionCard";
            Size = new Size(243, 256);
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
