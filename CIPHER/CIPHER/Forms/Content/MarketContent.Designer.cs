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
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMarketTitle = new Label();
            lblExtraStuff = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnBounty = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel4 = new Panel();
            btnHint = new Button();
            lblID = new Label();
            lblTitle = new Label();
            lblEmpty = new Label();
            lblReward = new Label();
            lblStatus = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1049, 473);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.Firebrick;
            panel1.Location = new Point(41, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 521);
            panel1.TabIndex = 2;
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
            tableLayoutPanel1.BackColor = Color.Wheat;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEmpty, 2, 0);
            tableLayoutPanel1.Controls.Add(lblReward, 3, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.DarkSlateGray;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1049, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMarketTitle
            // 
            lblMarketTitle.AutoSize = true;
            lblMarketTitle.Location = new Point(47, 54);
            lblMarketTitle.Name = "lblMarketTitle";
            lblMarketTitle.Size = new Size(92, 15);
            lblMarketTitle.TabIndex = 3;
            lblMarketTitle.Text = "BLACK MARKET";
            // 
            // lblExtraStuff
            // 
            lblExtraStuff.AutoSize = true;
            lblExtraStuff.Location = new Point(47, 71);
            lblExtraStuff.Name = "lblExtraStuff";
            lblExtraStuff.Size = new Size(134, 15);
            lblExtraStuff.TabIndex = 4;
            lblExtraStuff.Text = "Welcome to the Market!";
            // 
            // button1
            // 
            button1.Location = new Point(41, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(122, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(203, 143);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnBounty
            // 
            btnBounty.Location = new Point(837, 54);
            btnBounty.Name = "btnBounty";
            btnBounty.Size = new Size(253, 49);
            btnBounty.TabIndex = 8;
            btnBounty.Text = "Create new Bounty";
            btnBounty.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(837, 143);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(253, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(780, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(41, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 100);
            panel4.TabIndex = 11;
            // 
            // btnHint
            // 
            btnHint.Location = new Point(581, 54);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(250, 49);
            btnHint.TabIndex = 12;
            btnHint.Text = "Create new Hint";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(74, 48);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(83, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpty
            // 
            lblEmpty.Dock = DockStyle.Fill;
            lblEmpty.Location = new Point(487, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(145, 48);
            lblEmpty.TabIndex = 2;
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReward
            // 
            lblReward.Dock = DockStyle.Fill;
            lblReward.Location = new Point(638, 0);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(145, 48);
            lblReward.TabIndex = 3;
            lblReward.Text = "Reward";
            lblReward.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(789, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(196, 48);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MarketContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnHint);
            Controls.Add(panel4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnBounty);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblExtraStuff);
            Controls.Add(lblMarketTitle);
            Controls.Add(panel1);
            Name = "MarketContent";
            Size = new Size(1140, 723);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblMarketTitle;
        private Label lblExtraStuff;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnBounty;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel4;
        private Button btnHint;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblID;
        private Label lblTitle;
        private Label lblEmpty;
        private Label lblReward;
        private Label lblStatus;
    }
}
