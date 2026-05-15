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
            pnlHeader = new Panel();
            pnlFilters = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlFooter = new Panel();
            aMarketContent1 = new CIPHER.Forms.ADMINSTUFF.Content.AMarketContent();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblSub = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            aMarketContent2 = new CIPHER.Forms.ADMINSTUFF.Content.AMarketContent();
            aMarketContent3 = new CIPHER.Forms.ADMINSTUFF.Content.AMarketContent();
            panel3 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            lblRewardLevel = new Label();
            lblPostedBy = new Label();
            btnOpen = new Button();
            pnlFilters.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarketTitle
            // 
            lblMarketTitle.AutoSize = true;
            lblMarketTitle.Location = new Point(54, 72);
            lblMarketTitle.Name = "lblMarketTitle";
            lblMarketTitle.Size = new Size(114, 20);
            lblMarketTitle.TabIndex = 3;
            lblMarketTitle.Text = "BLACK MARKET";
            // 
            // lblExtraStuff
            // 
            lblExtraStuff.AutoSize = true;
            lblExtraStuff.Location = new Point(54, 95);
            lblExtraStuff.Name = "lblExtraStuff";
            lblExtraStuff.Size = new Size(168, 20);
            lblExtraStuff.TabIndex = 4;
            lblExtraStuff.Text = "Welcome to the Market!";
            // 
            // button1
            // 
            button1.Location = new Point(44, 19);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(136, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(235, 19);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnBounty
            // 
            btnBounty.Location = new Point(957, 72);
            btnBounty.Margin = new Padding(3, 4, 3, 4);
            btnBounty.Name = "btnBounty";
            btnBounty.Size = new Size(289, 65);
            btnBounty.TabIndex = 8;
            btnBounty.Text = "Create new Bounty";
            btnBounty.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(978, 21);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(289, 27);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(893, 19);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
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
            btnHint.Location = new Point(664, 72);
            btnHint.Margin = new Padding(3, 4, 3, 4);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(286, 65);
            btnHint.TabIndex = 12;
            btnHint.Text = "Create new Hint";
            btnHint.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1303, 140);
            pnlHeader.TabIndex = 13;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(button3);
            pnlFilters.Controls.Add(button2);
            pnlFilters.Controls.Add(button1);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 140);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1303, 70);
            pnlFilters.TabIndex = 14;
            // 
            // flowBounties
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(aMarketContent1);
            flowLayoutPanel1.Controls.Add(aMarketContent2);
            flowLayoutPanel1.Controls.Add(aMarketContent3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowBounties";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(1303, 964);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // pnlFooter
            // 
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(23, 23);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1463, 60);
            pnlFooter.TabIndex = 0;
            // 
            // aMarketContent1
            // 
            aMarketContent1.Location = new Point(20, 86);
            aMarketContent1.Margin = new Padding(0, 0, 0, 10);
            aMarketContent1.Name = "aMarketContent1";
            aMarketContent1.Size = new Size(1200, 110);
            aMarketContent1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 204F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblRewardLevel, 3, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(lblPostedBy, 4, 0);
            tableLayoutPanel1.Controls.Add(btnOpen, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 209);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1463, 125);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSub);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(120, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 119);
            panel1.TabIndex = 1;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.Gray;
            lblSub.Location = new Point(63, 66);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(50, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(51, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(79, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(332, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(34, 28);
            panel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(165, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(35, 28);
            panel5.TabIndex = 0;
            // 
            // aMarketContent2
            // 
            // panel3
            // 
           // panel3.Location = new Point(23, 2356);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 100);
            panel3.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Location = new Point(27, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(39, 30);
            panel7.TabIndex = 0;
            // 
            // lblRewardLevel
            // 
            lblRewardLevel.AutoSize = true;
            lblRewardLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRewardLevel.Location = new Point(637, 0);
            lblRewardLevel.Name = "lblRewardLevel";
            lblRewardLevel.Size = new Size(158, 28);
            lblRewardLevel.TabIndex = 3;
            lblRewardLevel.Text = "REWARD LEVEL";
            // 
            // lblPostedBy
            // 
            lblPostedBy.AutoSize = true;
            lblPostedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostedBy.Location = new Point(841, 0);
            lblPostedBy.Name = "lblPostedBy";
            lblPostedBy.Size = new Size(119, 28);
            lblPostedBy.TabIndex = 4;
            lblPostedBy.Text = "POSTED BY";
            // 
            // btnOpen
            // 
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(1039, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(63, 40);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "/~>";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // MarketContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            pnlHeader.Controls.Add(btnHint);
            pnlHeader.Controls.Add(panel4);
            pnlHeader.Controls.Add(btnBounty);
            pnlHeader.Controls.Add(lblExtraStuff);
            pnlHeader.Controls.Add(lblMarketTitle);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFilters);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MarketContent";
            Size = new Size(1303, 964);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel pnlHeader;
        private Panel pnlFilters;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlFooter;
        private ADMINSTUFF.Content.AMarketContent aMarketContent1;
        private TableLayoutPanel tableLayoutPanel1;
        private ADMINSTUFF.Content.AMarketContent aMarketContent2;
        private ADMINSTUFF.Content.AMarketContent aMarketContent3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblSub;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Label lblRewardLevel;
        private Label lblPostedBy;
        private Button btnOpen;
    }
}
