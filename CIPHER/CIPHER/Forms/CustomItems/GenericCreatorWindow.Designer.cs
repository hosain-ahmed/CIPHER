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
            txtDifficulty = new TextBox();
            lblDifficulty = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDifficulty);
            panel1.Controls.Add(txtDifficulty);
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
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(365, 341);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(46, 15);
            lblAnswer.TabIndex = 15;
            lblAnswer.Text = "Answer";
            // 
            // lblBriefing
            // 
            lblBriefing.AutoSize = true;
            lblBriefing.Location = new Point(367, 44);
            lblBriefing.Name = "lblBriefing";
            lblBriefing.Size = new Size(48, 15);
            lblBriefing.TabIndex = 14;
            lblBriefing.Text = "Briefing";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(12, 341);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(30, 15);
            lblHint.TabIndex = 13;
            lblHint.Text = "Hint";
            // 
            // lblXP
            // 
            lblXP.AutoSize = true;
            lblXP.Location = new Point(12, 282);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(21, 15);
            lblXP.TabIndex = 12;
            lblXP.Text = "XP";
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.Location = new Point(12, 223);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new Size(74, 15);
            lblCoin.TabIndex = 11;
            lblCoin.Text = "Coin Reward";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            lblCategory.Click += label2_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(518, 454);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(166, 37);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtXP
            // 
            txtXP.Location = new Point(12, 300);
            txtXP.Name = "txtXP";
            txtXP.Size = new Size(324, 23);
            txtXP.TabIndex = 7;
            // 
            // txtCoin
            // 
            txtCoin.Location = new Point(12, 241);
            txtCoin.Name = "txtCoin";
            txtCoin.Size = new Size(324, 23);
            txtCoin.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 118);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(324, 23);
            txtCategory.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(324, 23);
            txtTitle.TabIndex = 4;
            // 
            // rtbHint
            // 
            rtbHint.Location = new Point(12, 359);
            rtbHint.Name = "rtbHint";
            rtbHint.Size = new Size(324, 82);
            rtbHint.TabIndex = 3;
            rtbHint.Text = "";
            // 
            // rtbAnswer
            // 
            rtbAnswer.Location = new Point(365, 359);
            rtbAnswer.Name = "rtbAnswer";
            rtbAnswer.Size = new Size(321, 75);
            rtbAnswer.TabIndex = 2;
            rtbAnswer.Text = "";
            // 
            // rtbBriefing
            // 
            rtbBriefing.Location = new Point(363, 65);
            rtbBriefing.Name = "rtbBriefing";
            rtbBriefing.Size = new Size(321, 232);
            rtbBriefing.TabIndex = 1;
            rtbBriefing.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(609, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtDifficulty
            // 
            txtDifficulty.Location = new Point(12, 178);
            txtDifficulty.Name = "txtDifficulty";
            txtDifficulty.Size = new Size(324, 23);
            txtDifficulty.TabIndex = 16;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(12, 160);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(55, 15);
            lblDifficulty.TabIndex = 17;
            lblDifficulty.Text = "Difficulty";
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
        private TextBox txtDifficulty;
    }
}