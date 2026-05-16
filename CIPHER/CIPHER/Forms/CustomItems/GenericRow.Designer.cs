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
            accent = new Panel();
            lblMInfo = new Label();
            lblInfo = new Label();
            lblSInfo = new Label();
            lblTitle = new Label();
            lblID = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // accent
            // 
            accent.BackColor = Color.Cyan;
            accent.Dock = DockStyle.Left;
            accent.Location = new Point(9, 0);
            accent.Margin = new Padding(2, 3, 2, 3);
            accent.Name = "accent";
            accent.Size = new Size(8, 51);
            accent.TabIndex = 1;
            accent.Paint += accent_Paint;
            // 
            // lblMInfo
            // 
            lblMInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMInfo.Location = new Point(751, 0);
            lblMInfo.Margin = new Padding(2, 0, 2, 0);
            lblMInfo.Name = "lblMInfo";
            lblMInfo.Size = new Size(126, 51);
            lblMInfo.TabIndex = 4;
            lblMInfo.Text = "Extra Info 3";
            lblMInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Location = new Point(598, 0);
            lblInfo.Margin = new Padding(2, 0, 2, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(149, 51);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Extra Info 2";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Click += Row_Click;
            // 
            // lblSInfo
            // 
            lblSInfo.Dock = DockStyle.Fill;
            lblSInfo.Location = new Point(498, 0);
            lblSInfo.Margin = new Padding(2, 0, 2, 0);
            lblSInfo.Name = "lblSInfo";
            lblSInfo.Padding = new Padding(6, 2, 6, 2);
            lblSInfo.Size = new Size(96, 51);
            lblSInfo.TabIndex = 3;
            lblSInfo.Text = "Extra Info1";
            lblSInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblSInfo.Click += Row_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(202, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 51);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TItle";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += Row_Click;
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(2, 0);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(196, 51);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += Row_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.7353554F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7606831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.59288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91108F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblSInfo, 2, 0);
            tableLayoutPanel1.Controls.Add(lblInfo, 3, 0);
            tableLayoutPanel1.Controls.Add(lblMInfo, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(17, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(879, 51);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // GenericRow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(accent);
            Margin = new Padding(0, 0, 0, 1);
            Name = "GenericRow";
            Padding = new Padding(9, 0, 9, 0);
            Size = new Size(905, 51);
            Click += Row_Click;
            MouseEnter += GenericRow_MouseEnter;
            MouseLeave += GenericRow_MouseLeave;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel accent;
        private Label lblMInfo;
        private Label lblInfo;
        private Label lblSInfo;
        private Label lblTitle;
        private Label lblID;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
