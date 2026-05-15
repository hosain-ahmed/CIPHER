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
            lblID = new Label();
            lblTitle = new Label();
            lblEmpty = new Label();
            lblReward = new Label();
            lblStatus = new Label();
            label1 = new Label();
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
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1199, 631);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.Firebrick;
            panel1.Location = new Point(47, 229);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 695);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.Crimson;
            panel3.Location = new Point(0, 64);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1199, 631);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.WindowText;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 64);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BurlyWood;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9363556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4291229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEmpty, 2, 0);
            tableLayoutPanel1.Controls.Add(lblReward, 3, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.DarkSlateGray;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1199, 64);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.BackColor = Color.BurlyWood;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(85, 64);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.BurlyWood;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(94, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(455, 64);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpty
            // 
            lblEmpty.BackColor = Color.BurlyWood;
            lblEmpty.Dock = DockStyle.Fill;
            lblEmpty.Location = new Point(555, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(180, 64);
            lblEmpty.TabIndex = 2;
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReward
            // 
            lblReward.BackColor = Color.BurlyWood;
            lblReward.Dock = DockStyle.Fill;
            lblReward.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReward.Location = new Point(741, 0);
            lblReward.Name = "lblReward";
            lblReward.Size = new Size(154, 64);
            lblReward.TabIndex = 3;
            lblReward.Text = "Reward";
            lblReward.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.BurlyWood;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(901, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(224, 64);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1131, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 64);
            label1.TabIndex = 5;
            label1.Text = "Action";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarketTitle
            // 
            lblMarketTitle.AutoSize = true;
            lblMarketTitle.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarketTitle.ForeColor = Color.Teal;
            lblMarketTitle.Location = new Point(54, 31);
            lblMarketTitle.Name = "lblMarketTitle";
            lblMarketTitle.Size = new Size(287, 50);
            lblMarketTitle.TabIndex = 3;
            lblMarketTitle.Text = "BLACK MARKET";
            // 
            // lblExtraStuff
            // 
            lblExtraStuff.AutoSize = true;
            lblExtraStuff.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtraStuff.ForeColor = Color.Gray;
            lblExtraStuff.Location = new Point(54, 94);
            lblExtraStuff.Name = "lblExtraStuff";
            lblExtraStuff.Size = new Size(579, 23);
            lblExtraStuff.TabIndex = 4;
            lblExtraStuff.Text = "Encrypted bounty board for high-value targets. All transactions are routed.";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 190);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 5;
            button1.Text = "ALL_JOBS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(171, 191);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 31);
            button2.TabIndex = 6;
            button2.Text = "INFLATION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(303, 191);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(122, 31);
            button3.TabIndex = 7;
            button3.Text = "DATA_HEIST";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnBounty
            // 
            btnBounty.BackColor = Color.Teal;
            btnBounty.FlatStyle = FlatStyle.Flat;
            btnBounty.ForeColor = Color.White;
            btnBounty.Location = new Point(1041, 72);
            btnBounty.Margin = new Padding(3, 4, 3, 4);
            btnBounty.Name = "btnBounty";
            btnBounty.Size = new Size(205, 65);
            btnBounty.TabIndex = 8;
            btnBounty.Text = "Create new Bounty";
            btnBounty.UseVisualStyleBackColor = false;
            btnBounty.MouseEnter += btnBounty_MouseEnter;
            btnBounty.MouseLeave += btnBounty_MouseLeave;
            btnBounty.MouseHover += btnBounty_MouseHover;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonFace;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(957, 191);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(289, 30);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(876, 191);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += btnSearch_MouseEnter;
            btnSearch.MouseLeave += btnSearch_MouseLeave;
            btnSearch.MouseHover += btnSearch_MouseHover;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(47, 31);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 133);
            panel4.TabIndex = 11;
            // 
            // btnHint
            // 
            btnHint.AutoSize = true;
            btnHint.BackColor = Color.Teal;
            btnHint.FlatStyle = FlatStyle.Flat;
            btnHint.ForeColor = Color.White;
            btnHint.Location = new Point(819, 72);
            btnHint.Margin = new Padding(3, 4, 3, 4);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(205, 65);
            btnHint.TabIndex = 12;
            btnHint.Text = "Create new Hint";
            btnHint.UseVisualStyleBackColor = false;
            btnHint.Click += btnHint_Click;
            btnHint.MouseEnter += btnHint_MouseEnter;
            btnHint.MouseLeave += btnHint_MouseLeave;
            btnHint.MouseHover += btnHint_MouseHover;
            // 
            // MarketContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MarketContent";
            Size = new Size(1303, 964);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label label1;
    }
}
