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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(22, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BountyTitle";
            // 
            // rtbQuestion
            // 
            rtbQuestion.Location = new Point(12, 102);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.Size = new Size(408, 519);
            rtbQuestion.TabIndex = 1;
            rtbQuestion.Text = "";
            // 
            // rtbAnswer
            // 
            rtbAnswer.Location = new Point(441, 238);
            rtbAnswer.Name = "rtbAnswer";
            rtbAnswer.Size = new Size(219, 235);
            rtbAnswer.TabIndex = 2;
            rtbAnswer.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(510, 503);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BackColor = Color.Black;
            lblAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.ForeColor = SystemColors.ControlLightLight;
            lblAnswer.Location = new Point(441, 210);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(178, 21);
            lblAnswer.TabIndex = 4;
            lblAnswer.Text = "Write your Answer here:";
            // 
            // lblMissionID
            // 
            lblMissionID.AutoSize = true;
            lblMissionID.ForeColor = SystemColors.ControlLightLight;
            lblMissionID.Location = new Point(560, 37);
            lblMissionID.Name = "lblMissionID";
            lblMissionID.Size = new Size(56, 15);
            lblMissionID.TabIndex = 5;
            lblMissionID.Text = "BountyID";
            // 
            // lblcReward
            // 
            lblcReward.AutoSize = true;
            lblcReward.ForeColor = SystemColors.ControlLightLight;
            lblcReward.Location = new Point(441, 606);
            lblcReward.Name = "lblcReward";
            lblcReward.Size = new Size(71, 15);
            lblcReward.TabIndex = 6;
            lblcReward.Text = "CoinReward";
            // 
            // PoPBountySolve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(689, 655);
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
    }
}