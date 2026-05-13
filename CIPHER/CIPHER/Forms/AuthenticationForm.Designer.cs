namespace CIPHER.Forms
{
    partial class AuthenticationForm
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
            rtbLogin = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rtbLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 711);
            panel1.TabIndex = 0;
            // 
            // rtbLogin
            // 
            rtbLogin.BackColor = Color.FromArgb(253, 246, 227);
            rtbLogin.Dock = DockStyle.Fill;
            rtbLogin.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLogin.Location = new Point(0, 0);
            rtbLogin.Name = "rtbLogin";
            rtbLogin.Size = new Size(1264, 711);
            rtbLogin.TabIndex = 0;
            rtbLogin.Text = "";
            rtbLogin.KeyDown += rtbLogin_KeyDown;
            rtbLogin.KeyPress += rtbLogin_KeyPress;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 711);
            Controls.Add(panel1);
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CIPHER";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbLogin;
    }
}