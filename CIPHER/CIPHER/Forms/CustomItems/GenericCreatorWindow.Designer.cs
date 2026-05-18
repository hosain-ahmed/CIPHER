namespace CIPHER.Forms.CustomItems
{
    partial class GenericCreatorWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtDifficulty = new ComboBox();
            lblDifficulty = new Label();
            lblAnswer = new Label();
            lblBriefing = new Label();
            lblHint = new Label();
            lblXP = new Label();
            lblCoin = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            btnSubmit = new Button();
            txtXP = new TextBox();
            txtCoin = new TextBox();
            txtCategory = new TextBox();
            txtTitle = new TextBox();
            rtbHint = new RichTextBox();
            rtbAnswer = new RichTextBox();
            rtbBriefing = new RichTextBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 247, 246);
            panel1.Controls.Add(txtDifficulty);
            panel1.Controls.Add(lblDifficulty);
            panel1.Controls.Add(lblAnswer);
            panel1.Controls.Add(lblBriefing);
            panel1.Controls.Add(lblHint);
            panel1.Controls.Add(lblXP);
            panel1.Controls.Add(lblCoin);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtXP);
            panel1.Controls.Add(txtCoin);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(rtbHint);
            panel1.Controls.Add(rtbAnswer);
            panel1.Controls.Add(rtbBriefing);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 503);
            panel1.TabIndex = 0;
            // 
            // txtDifficulty
            // 
            txtDifficulty.FlatStyle = FlatStyle.Flat;
            txtDifficulty.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            txtDifficulty.FormattingEnabled = true;
            txtDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Expert" });
            txtDifficulty.Location = new Point(15, 190);
            txtDifficulty.Name = "txtDifficulty";
            txtDifficulty.Size = new Size(324, 27);
            txtDifficulty.TabIndex = 18;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.FlatStyle = FlatStyle.Flat;
            lblDifficulty.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblDifficulty.ForeColor = Color.Teal;
            lblDifficulty.Location = new Point(12, 160);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(73, 19);
            lblDifficulty.TabIndex = 17;
            lblDifficulty.Text = "Difficulty";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.FlatStyle = FlatStyle.Flat;
            lblAnswer.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            lblAnswer.ForeColor = Color.Teal;
            lblAnswer.Location = new Point(365, 326);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(76, 23);
            lblAnswer.TabIndex = 15;
            lblAnswer.Text = "Answer";
            // 
            // lblBriefing
            // 
            lblBriefing.AutoSize = true;
            lblBriefing.FlatStyle = FlatStyle.Flat;
            lblBriefing.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblBriefing.ForeColor = Color.Teal;
            lblBriefing.Location = new Point(363, 39);
            lblBriefing.Name = "lblBriefing";
            lblBriefing.Size = new Size(66, 19);
            lblBriefing.TabIndex = 14;
            lblBriefing.Text = "Briefing";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.FlatStyle = FlatStyle.Flat;
            lblHint.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            lblHint.ForeColor = Color.Teal;
            lblHint.Location = new Point(12, 326);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(45, 23);
            lblHint.TabIndex = 13;
            lblHint.Text = "Hint";
            // 
            // lblXP
            // 
            lblXP.AutoSize = true;
            lblXP.FlatStyle = FlatStyle.Flat;
            lblXP.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblXP.ForeColor = Color.Teal;
            lblXP.Location = new Point(12, 282);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(28, 19);
            lblXP.TabIndex = 12;
            lblXP.Text = "XP";
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.FlatStyle = FlatStyle.Flat;
            lblCoin.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblCoin.ForeColor = Color.Teal;
            lblCoin.Location = new Point(12, 223);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new Size(101, 19);
            lblCoin.TabIndex = 11;
            lblCoin.Text = "Coin Reward";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.White;
            lblCategory.FlatStyle = FlatStyle.Flat;
            lblCategory.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Teal;
            lblCategory.Location = new Point(12, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 19);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(12, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 19);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(520, 440);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(166, 51);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtXP
            // 
            txtXP.BackColor = Color.White;
            txtXP.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            txtXP.Location = new Point(12, 300);
            txtXP.Name = "txtXP";
            txtXP.Size = new Size(324, 27);
            txtXP.TabIndex = 7;
            // 
            // txtCoin
            // 
            txtCoin.BackColor = Color.White;
            txtCoin.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            txtCoin.Location = new Point(12, 241);
            txtCoin.Name = "txtCoin";
            txtCoin.Size = new Size(324, 27);
            txtCoin.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            txtCategory.Location = new Point(12, 118);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(324, 27);
            txtCategory.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            txtTitle.Location = new Point(12, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(324, 27);
            txtTitle.TabIndex = 4;
            // 
            // rtbHint
            // 
            rtbHint.BackColor = Color.White;
            rtbHint.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            rtbHint.Location = new Point(12, 359);
            rtbHint.Name = "rtbHint";
            rtbHint.Size = new Size(324, 82);
            rtbHint.TabIndex = 3;
            rtbHint.Text = "";
            // 
            // rtbAnswer
            // 
            rtbAnswer.BackColor = Color.White;
            rtbAnswer.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            rtbAnswer.Location = new Point(365, 359);
            rtbAnswer.Name = "rtbAnswer";
            rtbAnswer.Size = new Size(321, 75);
            rtbAnswer.TabIndex = 2;
            rtbAnswer.Text = "";
            // 
            // rtbBriefing
            // 
            rtbBriefing.BackColor = Color.White;
            rtbBriefing.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            rtbBriefing.Location = new Point(363, 65);
            rtbBriefing.Name = "rtbBriefing";
            rtbBriefing.Size = new Size(321, 232);
            rtbBriefing.TabIndex = 1;
            rtbBriefing.Text = "";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(609, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // GenericCreatorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 503);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GenericCreatorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenericCreatorWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSubmit;
        private TextBox txtXP;
        private TextBox txtCoin;
        private TextBox txtCategory;
        private TextBox txtTitle;
        private RichTextBox rtbHint;
        private RichTextBox rtbAnswer;
        private RichTextBox rtbBriefing;
        private Button btnExit;
        private Label lblAnswer;
        private Label lblBriefing;
        private Label lblHint;
        private Label lblXP;
        private Label lblCoin;
        private Label lblCategory;
        private Label lblTitle;
        private Label lblDifficulty;
        private ComboBox txtDifficulty;
    }
}