using CIPHER.Helpers;

namespace CIPHER.Forms.Content
{
    partial class MarketContent
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHolder = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblID = new Label();
            lblTitle = new Label();
            lblEmpty = new Label();
            lblReward = new Label();
            lblStatus = new Label();
            label1 = new Label();
            lblMarketTitle = new Label();
            lblExtraStuff = new Label();
            btnBountyShow = new Button();
            btnExtraFeaturesShow = new Button();
            btnHitlistShow = new Button();
            btnCreate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel4 = new Panel();
            pnlContent = new Panel();
            panel8 = new Panel();
            lblBBD = new Label();
            lblBB = new Label();
            btnBBBuy = new Button();
            panel7 = new Panel();
            lblMSD = new Label();
            lblMS = new Label();
            btnMSBuy = new Button();
            panel6 = new Panel();
            lblXPD = new Label();
            lblXP = new Label();
            btnXPBuy = new Button();
            panel5 = new Panel();
            lblGPD = new Label();
            lblGP = new Label();
            btnGPBuy = new Button();
            pnlHolder.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlContent.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(244, 247, 246);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1049, 473);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnlHolder
            // 
            pnlHolder.BackColor = SystemColors.WindowFrame;
            pnlHolder.Controls.Add(panel3);
            pnlHolder.Controls.Add(panel2);
            pnlHolder.ForeColor = Color.Firebrick;
            pnlHolder.Location = new Point(41, 172);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(1049, 521);
            pnlHolder.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.Crimson;
            panel3.Location = new Point(0, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 473);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowText;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 48);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BurlyWood;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9363556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4291229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEmpty, 2, 0);
            tableLayoutPanel1.Controls.Add(lblReward, 3, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.DarkSlateGray;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1049, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.BackColor = Color.BurlyWood;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(74, 48);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.BurlyWood;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(83, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpty
            // 
            lblEmpty.BackColor = Color.BurlyWood;
            lblEmpty.Dock = DockStyle.Fill;
            lblEmpty.Location = new Point(484, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(155, 48);
            lblEmpty.TabIndex = 2;
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReward
            // 
            lblReward.BackColor = Color.BurlyWood;
            lblReward.Dock = DockStyle.Fill;
            lblReward.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReward.Location = new Point(645, 0);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(133, 48);
            lblReward.TabIndex = 3;
            lblReward.Text = "Reward";
            lblReward.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.BurlyWood;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(784, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(194, 48);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(984, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 48);
            label1.TabIndex = 5;
            label1.Text = "Action";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarketTitle
            // 
            lblMarketTitle.AutoSize = true;
            lblMarketTitle.FlatStyle = FlatStyle.Flat;
            lblMarketTitle.Font = new Font("Bahnschrift SemiBold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarketTitle.ForeColor = Color.Teal;
            lblMarketTitle.Location = new Point(44, 23);
            lblMarketTitle.Name = "lblMarketTitle";
            lblMarketTitle.Size = new Size(229, 36);
            lblMarketTitle.TabIndex = 3;
            lblMarketTitle.Text = "BLACK MARKET";
            // 
            // lblExtraStuff
            // 
            lblExtraStuff.AutoSize = true;
            lblExtraStuff.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblExtraStuff.ForeColor = Color.Gray;
            lblExtraStuff.Location = new Point(47, 70);
            lblExtraStuff.Name = "lblExtraStuff";
            lblExtraStuff.Size = new Size(554, 19);
            lblExtraStuff.TabIndex = 4;
            lblExtraStuff.Text = "Encrypted bounty board for high-value targets. All transactions are routed.";
            // 
            // btnBountyShow
            // 
            btnBountyShow.BackColor = Color.Teal;
            btnBountyShow.FlatStyle = FlatStyle.Flat;
            btnBountyShow.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBountyShow.ForeColor = Color.White;
            btnBountyShow.Location = new Point(44, 128);
            btnBountyShow.Name = "btnBountyShow";
            btnBountyShow.Size = new Size(88, 38);
            btnBountyShow.TabIndex = 5;
            btnBountyShow.Text = "BOUNTIES";
            btnBountyShow.UseVisualStyleBackColor = false;
            btnBountyShow.Click += btnBountyShow_Click;
            // 
            // btnExtraFeaturesShow
            // 
            btnExtraFeaturesShow.BackColor = Color.Teal;
            btnExtraFeaturesShow.FlatStyle = FlatStyle.Flat;
            btnExtraFeaturesShow.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtraFeaturesShow.ForeColor = Color.White;
            btnExtraFeaturesShow.Location = new Point(150, 128);
            btnExtraFeaturesShow.Name = "btnExtraFeaturesShow";
            btnExtraFeaturesShow.Size = new Size(97, 38);
            btnExtraFeaturesShow.TabIndex = 6;
            btnExtraFeaturesShow.Text = "DATA HEIST";
            btnExtraFeaturesShow.UseVisualStyleBackColor = false;
            btnExtraFeaturesShow.Click += btnExtraFeaturesShow_Click;
            // 
            // btnHitlistShow
            // 
            btnHitlistShow.BackColor = Color.Teal;
            btnHitlistShow.FlatStyle = FlatStyle.Flat;
            btnHitlistShow.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitlistShow.ForeColor = Color.White;
            btnHitlistShow.Location = new Point(265, 128);
            btnHitlistShow.Name = "btnHitlistShow";
            btnHitlistShow.Size = new Size(107, 38);
            btnHitlistShow.TabIndex = 7;
            btnHitlistShow.Text = "HITLIST";
            btnHitlistShow.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Teal;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(944, 56);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 49);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create +";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonFace;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(837, 143);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(250, 26);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(765, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 26);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(41, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 100);
            panel4.TabIndex = 11;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.WindowFrame;
            pnlContent.Controls.Add(panel8);
            pnlContent.Controls.Add(panel7);
            pnlContent.Controls.Add(panel6);
            pnlContent.Controls.Add(panel5);
            pnlContent.Location = new Point(397, 128);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(933, 312);
            pnlContent.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblBBD);
            panel8.Controls.Add(lblBB);
            panel8.Controls.Add(btnBBBuy);
            panel8.Location = new Point(702, 47);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 204);
            panel8.TabIndex = 3;
            // 
            // lblBBD
            // 
            lblBBD.AutoSize = true;
            lblBBD.Location = new Point(28, 61);
            lblBBD.Name = "lblBBD";
            lblBBD.Size = new Size(143, 15);
            lblBBD.TabIndex = 2;
            lblBBD.Text = "Bounty Bomb Description";
            // 
            // lblBB
            // 
            lblBB.AutoSize = true;
            lblBB.Location = new Point(28, 14);
            lblBB.Name = "lblBB";
            lblBB.Size = new Size(80, 15);
            lblBB.TabIndex = 1;
            lblBB.Text = "Bounty Bomb";
            // 
            // btnBBBuy
            // 
            btnBBBuy.Location = new Point(71, 181);
            btnBBBuy.Name = "btnBBBuy";
            btnBBBuy.Size = new Size(75, 23);
            btnBBBuy.TabIndex = 0;
            btnBBBuy.Text = "Buy";
            btnBBBuy.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblMSD);
            panel7.Controls.Add(lblMS);
            panel7.Controls.Add(btnMSBuy);
            panel7.Location = new Point(482, 47);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 204);
            panel7.TabIndex = 2;
            // 
            // lblMSD
            // 
            lblMSD.AutoSize = true;
            lblMSD.Location = new Point(27, 52);
            lblMSD.Name = "lblMSD";
            lblMSD.Size = new Size(111, 15);
            lblMSD.TabIndex = 2;
            lblMSD.Text = "Mission Skip Details";
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.Location = new Point(27, 15);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(73, 15);
            lblMS.TabIndex = 1;
            lblMS.Text = "Mission Skip";
            // 
            // btnMSBuy
            // 
            btnMSBuy.Location = new Point(76, 174);
            btnMSBuy.Name = "btnMSBuy";
            btnMSBuy.Size = new Size(75, 23);
            btnMSBuy.TabIndex = 0;
            btnMSBuy.Text = "Buy";
            btnMSBuy.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblXPD);
            panel6.Controls.Add(lblXP);
            panel6.Controls.Add(btnXPBuy);
            panel6.Location = new Point(256, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 204);
            panel6.TabIndex = 1;
            // 
            // lblXPD
            // 
            lblXPD.AutoSize = true;
            lblXPD.Location = new Point(16, 52);
            lblXPD.Name = "lblXPD";
            lblXPD.Size = new Size(117, 15);
            lblXPD.TabIndex = 2;
            lblXPD.Text = "XP Boost Description";
            // 
            // lblXP
            // 
            lblXP.AutoSize = true;
            lblXP.Location = new Point(16, 15);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(54, 15);
            lblXP.TabIndex = 1;
            lblXP.Text = "XP Boost";
            // 
            // btnXPBuy
            // 
            btnXPBuy.Location = new Point(71, 174);
            btnXPBuy.Name = "btnXPBuy";
            btnXPBuy.Size = new Size(75, 23);
            btnXPBuy.TabIndex = 0;
            btnXPBuy.Text = "Buy";
            btnXPBuy.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblGPD);
            panel5.Controls.Add(lblGP);
            panel5.Controls.Add(btnGPBuy);
            panel5.Location = new Point(27, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 207);
            panel5.TabIndex = 0;
            // 
            // lblGPD
            // 
            lblGPD.AutoSize = true;
            lblGPD.Location = new Point(13, 55);
            lblGPD.Name = "lblGPD";
            lblGPD.Size = new Size(149, 15);
            lblGPD.TabIndex = 2;
            lblGPD.Text = "Ghost protocol Description";
            // 
            // lblGP
            // 
            lblGP.AutoSize = true;
            lblGP.Location = new Point(13, 18);
            lblGP.Name = "lblGP";
            lblGP.Size = new Size(86, 15);
            lblGP.TabIndex = 1;
            lblGP.Text = "Ghost Protocol";
            // 
            // btnGPBuy
            // 
            btnGPBuy.Location = new Point(64, 165);
            btnGPBuy.Name = "btnGPBuy";
            btnGPBuy.Size = new Size(75, 23);
            btnGPBuy.TabIndex = 0;
            btnGPBuy.Text = "Buy";
            btnGPBuy.UseVisualStyleBackColor = true;
            // 
            // MarketContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContent);
            Controls.Add(panel4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnCreate);
            Controls.Add(btnHitlistShow);
            Controls.Add(btnExtraFeaturesShow);
            Controls.Add(btnBountyShow);
            Controls.Add(lblExtraStuff);
            Controls.Add(lblMarketTitle);
            Controls.Add(pnlHolder);
            Name = "MarketContent";
            Size = new Size(1140, 723);
            pnlHolder.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlContent.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlHolder;
        private Panel panel3;
        private Panel panel2;
        private Label lblMarketTitle;
        private Label lblExtraStuff;
        private Button btnBountyShow;
        private Button btnExtraFeaturesShow;
        private Button btnHitlistShow;
        private Button btnCreate;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblID;
        private Label lblTitle;
        private Label lblEmpty;
        private Label lblReward;
        private Label lblStatus;
        private Label label1;
        private Panel pnlContent;
        private Panel panel8;
        private Label lblBBD;
        private Label lblBB;
        private Button btnBBBuy;
        private Panel panel7;
        private Label lblMSD;
        private Label lblMS;
        private Button btnMSBuy;
        private Panel panel6;
        private Label lblXPD;
        private Label lblXP;
        private Button btnXPBuy;
        private Panel panel5;
        private Label lblGPD;
        private Label lblGP;
        private Button btnGPBuy;
    }
}
