namespace CIPHER.Forms.Controls
{
    partial class DashBoardContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardContainer));
            pnlSideBar = new Panel();
            btnTerminal = new Button();
            btnMission = new Button();
            btnProfile = new Button();
            btnLog = new Button();
            btnMarket = new Button();
            pnlContent = new Panel();
            label1 = new Label();
            pnlSideBar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = SystemColors.ActiveCaptionText;
            pnlSideBar.Controls.Add(btnTerminal);
            pnlSideBar.Controls.Add(btnMission);
            pnlSideBar.Controls.Add(btnProfile);
            pnlSideBar.Controls.Add(btnLog);
            pnlSideBar.Controls.Add(btnMarket);
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(34, 618);
            pnlSideBar.TabIndex = 0;
            pnlSideBar.Paint += pnlSideBar_Paint;
            // 
            // btnTerminal
            // 
            btnTerminal.FlatAppearance.BorderSize = 0;
            btnTerminal.FlatStyle = FlatStyle.Flat;
            btnTerminal.Image = Properties.Resources.SSCMD;
            btnTerminal.Location = new Point(0, 548);
            btnTerminal.Name = "btnTerminal";
            btnTerminal.Size = new Size(31, 23);
            btnTerminal.TabIndex = 9;
            btnTerminal.UseVisualStyleBackColor = true;
            // 
            // btnMission
            // 
            btnMission.AccessibleName = "btnmissionnew";
            btnMission.Anchor = AnchorStyles.Top;
            btnMission.FlatAppearance.BorderSize = 0;
            btnMission.FlatStyle = FlatStyle.Flat;
            btnMission.Image = (Image)resources.GetObject("btnMission.Image");
            btnMission.Location = new Point(3, 37);
            btnMission.Name = "btnMission";
            btnMission.Size = new Size(25, 29);
            btnMission.TabIndex = 0;
            btnMission.UseVisualStyleBackColor = false;
            btnMission.Click += button1_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = Properties.Resources.SSMale;
            btnProfile.Location = new Point(6, 577);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(22, 23);
            btnProfile.TabIndex = 8;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLog
            // 
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Image = Properties.Resources.SSLog;
            btnLog.Location = new Point(7, 106);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(21, 23);
            btnLog.TabIndex = 7;
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnMarket
            // 
            btnMarket.FlatAppearance.BorderSize = 0;
            btnMarket.FlatStyle = FlatStyle.Flat;
            btnMarket.Image = Properties.Resources.SSMarket;
            btnMarket.Location = new Point(3, 72);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new Size(29, 28);
            btnMarket.TabIndex = 6;
            btnMarket.UseVisualStyleBackColor = false;
            btnMarket.Click += btnMarket_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(30, 30, 30);
            pnlContent.Controls.Add(label1);
            pnlContent.Location = new Point(34, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(833, 618);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 110);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // DashBoardContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlSideBar);
            Controls.Add(pnlContent);
            Name = "DashBoardContainer";
            Size = new Size(867, 618);
            Load += sdbControl_Load;
            pnlSideBar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlContent;
        private Label label1;
        private Button btnMission;
        private Button btnProfile;
        private Button btnLog;
        private Button btnMarket;
        private Button btnTerminal;
    }
}
