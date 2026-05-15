namespace CIPHER.Forms.CustomItems
{
    partial class GenericRow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblID = new Label();
            lblTitle = new Label();
            lblSInfo = new Label();
            lblInfo = new Label();
            lblMInfo = new Label();
            btnDo = new Button();
            accent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2653065F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9591827F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2176876F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblSInfo, 2, 0);
            tableLayoutPanel1.Controls.Add(lblInfo, 3, 0);
            tableLayoutPanel1.Controls.Add(lblMInfo, 4, 0);
            tableLayoutPanel1.Controls.Add(btnDo, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(21, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1099, 64);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(244, 64);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += Row_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(253, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 64);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TItle";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += Row_Click;
            // 
            // lblSInfo
            // 
            lblSInfo.Dock = DockStyle.Fill;
            lblSInfo.Location = new Point(596, 0);
            lblSInfo.Name = "lblSInfo";
            lblSInfo.Padding = new Padding(7, 3, 7, 3);
            lblSInfo.Size = new Size(96, 64);
            lblSInfo.TabIndex = 3;
            lblSInfo.Text = "Extra Info1";
            lblSInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblSInfo.Click += Row_Click;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Location = new Point(698, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(171, 64);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Extra Info 2";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Click += Row_Click;
            // 
            // lblMInfo
            // 
            lblMInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMInfo.Location = new Point(875, 0);
            lblMInfo.Name = "lblMInfo";
            lblMInfo.Size = new Size(142, 64);
            lblMInfo.TabIndex = 4;
            lblMInfo.Text = "Extra Info 3";
            lblMInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDo
            // 
            btnDo.Dock = DockStyle.Fill;
            btnDo.Location = new Point(1023, 4);
            btnDo.Margin = new Padding(3, 4, 3, 4);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(73, 56);
            btnDo.TabIndex = 5;
            btnDo.Text = "Action";
            btnDo.UseVisualStyleBackColor = true;
            // 
            // accent
            // 
            accent.BackColor = Color.Cyan;
            accent.Dock = DockStyle.Left;
            accent.Location = new Point(11, 0);
            accent.Margin = new Padding(3, 4, 3, 4);
            accent.Name = "accent";
            accent.Size = new Size(10, 64);
            accent.TabIndex = 1;
            accent.Paint += accent_Paint;
            // 
            // GenericRow
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(accent);
            Margin = new Padding(0, 0, 0, 1);
            Name = "GenericRow";
            Padding = new Padding(11, 0, 11, 0);
            Size = new Size(1131, 64);
            Click += Row_Click;
            MouseEnter += GenericRow_MouseEnter;
            MouseLeave += GenericRow_MouseLeave;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblID;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblSInfo;
        private Panel accent;
        private Label lblMInfo;
        private Button btnDo;
    }
}
