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
            cardPanel = new Panel();
            lblID = new Label();
            lblStatus = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblExtraInfo = new Label();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.Lime;
            cardPanel.Dock = DockStyle.Left;
            cardPanel.Location = new Point(0, 0);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(5, 350);
            cardPanel.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Black;
            lblID.ForeColor = SystemColors.ControlLightLight;
            lblID.Location = new Point(32, 32);
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
            lblStatus.Location = new Point(170, 32);
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
            lblTitle.Location = new Point(32, 96);
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
            lblDescription.Location = new Point(32, 139);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(80, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "lblDescription";
            lblDescription.Click += OpenMissionDetails;
            // 
            // lblExtraInfo
            // 
            lblExtraInfo.AutoSize = true;
            lblExtraInfo.BackColor = Color.Black;
            lblExtraInfo.ForeColor = SystemColors.ControlLightLight;
            lblExtraInfo.Location = new Point(49, 232);
            lblExtraInfo.Name = "lblExtraInfo";
            lblExtraInfo.Size = new Size(66, 15);
            lblExtraInfo.TabIndex = 5;
            lblExtraInfo.Text = "lblExtraInfo";
            lblExtraInfo.Click += OpenMissionDetails;
            // 
            // MissionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lblExtraInfo);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblID);
            Controls.Add(cardPanel);
            Name = "MissionCard";
            Size = new Size(250, 350);
            Click += OpenMissionDetails;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel cardPanel;
        private Label lblID;
        private Label lblStatus;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblExtraInfo;
    }
}
