namespace CIPHER.Forms.Controls
{
    partial class DashBoardContainer
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
            pnlSideBar = new Panel();
            pnlContent = new Panel();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = SystemColors.ActiveCaption;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(28, 618);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.WindowFrame;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(867, 618);
            pnlContent.TabIndex = 1;
            // 
            // DashBoardContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlSideBar);
            Controls.Add(pnlContent);
            Name = "DashBoardContainer";
            Size = new Size(867, 618);
            Load += sdbControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlContent;
    }
}
