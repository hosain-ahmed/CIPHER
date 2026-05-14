namespace CIPHER.Forms.ADMINSTUFF.Content
{
    partial class AMissionContent
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
            pnlHeader = new Panel();
            btnCreateMission = new Button();
            pnlCoin = new Panel();
            pnlSuccess = new Panel();
            pnlTime = new Panel();
            pnlUsers = new Panel();
            tbSearch = new MaskedTextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = SystemColors.ControlDark;
            pnlHeader.Location = new Point(15, 12);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(577, 54);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += panel1_Paint;
            // 
            // btnCreateMission
            // 
            btnCreateMission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateMission.Location = new Point(598, 12);
            btnCreateMission.Name = "btnCreateMission";
            btnCreateMission.Size = new Size(223, 54);
            btnCreateMission.TabIndex = 1;
            btnCreateMission.Text = "Create new Mission";
            btnCreateMission.UseVisualStyleBackColor = true;
            btnCreateMission.Click += btnCreateMission_Click;
            // 
            // pnlCoin
            // 
            pnlCoin.Anchor = AnchorStyles.Left;
            pnlCoin.BackColor = SystemColors.ControlDark;
            pnlCoin.Location = new Point(15, 102);
            pnlCoin.Name = "pnlCoin";
            pnlCoin.Size = new Size(170, 100);
            pnlCoin.TabIndex = 2;
            pnlCoin.Paint += panel2_Paint;
            // 
            // pnlSuccess
            // 
            pnlSuccess.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlSuccess.BackColor = SystemColors.ControlDark;
            pnlSuccess.Location = new Point(226, 102);
            pnlSuccess.Name = "pnlSuccess";
            pnlSuccess.Size = new Size(170, 100);
            pnlSuccess.TabIndex = 3;
            // 
            // pnlTime
            // 
            pnlTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlTime.BackColor = SystemColors.ControlDark;
            pnlTime.Location = new Point(441, 102);
            pnlTime.Name = "pnlTime";
            pnlTime.Size = new Size(170, 100);
            pnlTime.TabIndex = 4;
            // 
            // pnlUsers
            // 
            pnlUsers.Anchor = AnchorStyles.Right;
            pnlUsers.BackColor = SystemColors.ControlDark;
            pnlUsers.Location = new Point(651, 102);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(170, 100);
            pnlUsers.TabIndex = 5;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbSearch.Location = new Point(598, 230);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(223, 23);
            tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(548, 230);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(44, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "button2";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 387);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 356);
            panel3.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(806, 356);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 31);
            panel2.TabIndex = 9;
            // 
            // AMissionContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(pnlUsers);
            Controls.Add(pnlTime);
            Controls.Add(pnlSuccess);
            Controls.Add(pnlCoin);
            Controls.Add(btnCreateMission);
            Controls.Add(pnlHeader);
            Name = "AMissionContent";
            Size = new Size(839, 662);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnCreateMission;
        private Panel pnlCoin;
        private Panel pnlSuccess;
        private Panel pnlTime;
        private Panel pnlUsers;
        private MaskedTextBox tbSearch;
        private Button btnSearch;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
