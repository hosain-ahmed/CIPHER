namespace CIPHER.Forms.Content
{
    partial class PoPBountySolve
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
            lblTitle = new Label();
            rtbQuestion = new RichTextBox();
            rtbAnswer = new RichTextBox();
            btnSubmit = new Button();
            lblAnswer = new Label();
            lblMissionID = new Label();
            lblcReward = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(244, 247, 246);
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(22, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BountyTitle";
            // 
            // rtbQuestion
            // 
            rtbQuestion.BackColor = Color.FromArgb(244, 247, 246);
            rtbQuestion.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbQuestion.Location = new Point(22, 80);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.ReadOnly = true;
            rtbQuestion.Size = new Size(303, 319);
            rtbQuestion.TabIndex = 1;
            rtbQuestion.Text = "";
            // 
            // rtbAnswer
            // 
            rtbAnswer.BackColor = Color.FromArgb(244, 247, 246);
            rtbAnswer.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbAnswer.Location = new Point(359, 126);
            rtbAnswer.Name = "rtbAnswer";
            rtbAnswer.Size = new Size(188, 207);
            rtbAnswer.TabIndex = 2;
            rtbAnswer.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(417, 339);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 30);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BackColor = Color.White;
            lblAnswer.Font = new Font("Bahnschrift SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.ForeColor = Color.Black;
            lblAnswer.Location = new Point(359, 92);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(194, 21);
            lblAnswer.TabIndex = 4;
            lblAnswer.Text = "Write your Answer here:";
            // 
            // lblMissionID
            // 
            lblMissionID.AutoSize = true;
            lblMissionID.BackColor = Color.FromArgb(244, 247, 246);
            lblMissionID.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionID.ForeColor = Color.Black;
            lblMissionID.Location = new Point(359, 37);
            lblMissionID.Name = "lblMissionID";
            lblMissionID.Size = new Size(74, 19);
            lblMissionID.TabIndex = 5;
            lblMissionID.Text = "BountyID";
            // 
            // lblcReward
            // 
            lblcReward.AutoSize = true;
            lblcReward.BackColor = Color.White;
            lblcReward.FlatStyle = FlatStyle.Flat;
            lblcReward.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcReward.ForeColor = Color.Teal;
            lblcReward.Location = new Point(359, 381);
            lblcReward.Name = "lblcReward";
            lblcReward.Size = new Size(89, 18);
            lblcReward.TabIndex = 6;
            lblcReward.Text = "CoinReward";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(523, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // PoPBountySolve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 444);
            Controls.Add(btnExit);
            Controls.Add(lblcReward);
            Controls.Add(lblMissionID);
            Controls.Add(lblAnswer);
            Controls.Add(btnSubmit);
            Controls.Add(rtbAnswer);
            Controls.Add(rtbQuestion);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "PoPBountySolve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PoPMissionSolve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtbQuestion;
        private RichTextBox rtbAnswer;
        private Button btnSubmit;
        private Label lblAnswer;
        private Label lblMissionID;
        private Label lblcReward;
        private Button btnExit;
    }
}