namespace CIPHER.Forms.Controls
{
    partial class LoginControl
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
            loginTerminal = new RichTextBox();
            SuspendLayout();
            // 
            // loginTerminal
            // 
            loginTerminal.BackColor = SystemColors.ControlLight;
            loginTerminal.Dock = DockStyle.Fill;
            loginTerminal.ForeColor = SystemColors.Window;
            loginTerminal.Location = new Point(0, 0);
            loginTerminal.Margin = new Padding(3, 4, 3, 4);
            loginTerminal.Name = "loginTerminal";
            loginTerminal.Size = new Size(1053, 847);
            loginTerminal.TabIndex = 0;
            loginTerminal.Text = "";
            loginTerminal.SelectionChanged += loginTerminal_SelectionChanged;
            loginTerminal.TextChanged += loginTerminal_TextChanged;
            loginTerminal.KeyDown += loginTerminal_KeyDown;
            loginTerminal.KeyPress += loginTerminal_KeyPress;
            loginTerminal.KeyUp += loginTerminal_KeyUp;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(loginTerminal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginControl";
            Size = new Size(1053, 847);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox loginTerminal;
    }
}
