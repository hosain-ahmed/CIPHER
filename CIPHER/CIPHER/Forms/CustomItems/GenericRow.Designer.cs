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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblSInfo, 2, 0);
            tableLayoutPanel1.Controls.Add(lblInfo, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(130, 48);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 48);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += Row_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(22, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TItle";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += Row_Click;
            // 
            // lblSInfo
            // 
            lblSInfo.Dock = DockStyle.Fill;
            lblSInfo.Location = new Point(93, 0);
            lblSInfo.Name = "lblSInfo";
            lblSInfo.Size = new Size(13, 48);
            lblSInfo.TabIndex = 3;
            lblSInfo.Text = "Status";
            lblSInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblSInfo.Click += Row_Click;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Location = new Point(112, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(15, 48);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Info";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Click += Row_Click;
            // 
            // GenericRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0, 0, 0, 1);
            Name = "GenericRow";
            Padding = new Padding(10, 0, 10, 0);
            Size = new Size(150, 48);
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
    }
}
