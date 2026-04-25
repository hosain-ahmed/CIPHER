namespace CIPHER.Forms.Controls
{
    partial class Login
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Desktop;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.MenuBar;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1028, 637);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Name = "Login";
            Size = new Size(1028, 637);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}
