namespace CIPHER
{
    partial class MainShell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login1 = new CIPHER.Forms.Controls.Login();
            SuspendLayout();
            // 
            // login1
            // 
            login1.Dock = DockStyle.Fill;
            login1.Location = new Point(0, 0);
            login1.Name = "login1";
            login1.Size = new Size(990, 579);
            login1.TabIndex = 0;
            // 
            // MainShell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 579);
            Controls.Add(login1);
            Name = "MainShell";
            Text = "CIPHER";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Forms.Controls.Login login1;
    }
}
