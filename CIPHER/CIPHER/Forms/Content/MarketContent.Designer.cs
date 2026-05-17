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
            pnlHolder.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            btnHitlistShow.Click += btnHitlistShow_Click;
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
            btnCreate.Click += btnCreate_Click;
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
            // MarketContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
    }
}
