using CIPHER.Helpers;

namespace CIPHER.Forms.Content
{
    partial class LogContent
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
            panel1 = new Panel();
            dgvLogs = new DataGridView();
            panel2 = new Panel();
            lblLogTitle = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            cmbFilter = new ComboBox();
            lblFilter = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(dgvLogs);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(40, 176);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 776);
            panel1.TabIndex = 2;
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvLogs.BackgroundColor = Color.FromArgb(244, 247, 246);
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(0, 0);
            dgvLogs.Margin = new Padding(3, 4, 3, 4);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(1178, 776);
            dgvLogs.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.BurlyWood;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1178, 79);
            panel2.TabIndex = 2;
            // 
            // lblLogTitle
            // 
            lblLogTitle.AutoSize = true;
            lblLogTitle.BackColor = Color.FromArgb(244, 247, 246);
            lblLogTitle.Font = new Font("Bahnschrift SemiBold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogTitle.ForeColor = Color.Teal;
            lblLogTitle.Location = new Point(40, 35);
            lblLogTitle.Name = "lblLogTitle";
            lblLogTitle.Size = new Size(254, 45);
            lblLogTitle.TabIndex = 3;
            lblLogTitle.Text = "SYSTEM LOGS";
            lblLogTitle.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(244, 247, 246);
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(40, 93);
            label2.Name = "label2";
            label2.Size = new Size(311, 28);
            label2.TabIndex = 4;
            label2.Text = "Real time Activity Monitoring";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(910, 137);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by codename";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(308, 27);
            textBox1.TabIndex = 5;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(817, 137);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = SystemColors.Window;
            cmbFilter.FlatStyle = FlatStyle.Flat;
            cmbFilter.ForeColor = Color.White;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(111, 139);
            cmbFilter.Margin = new Padding(3, 4, 3, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(181, 28);
            cmbFilter.TabIndex = 7;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.Teal;
            lblFilter.FlatStyle = FlatStyle.Flat;
            lblFilter.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(40, 141);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(59, 24);
            lblFilter.TabIndex = 8;
            lblFilter.Text = "Filter";
            // 
            // LogContent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            Controls.Add(lblFilter);
            Controls.Add(cmbFilter);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblLogTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogContent";
            Size = new Size(1262, 1023);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lblLogTitle;
        private Label label2;
        private TextBox textBox1;
        private Button btnSearch;
        private DataGridView dgvLogs;
        private ComboBox cmbFilter;
        private Label lblFilter;
    }
}
