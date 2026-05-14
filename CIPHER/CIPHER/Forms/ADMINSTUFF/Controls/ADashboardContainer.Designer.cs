namespace CIPHER.Forms.ADMINSTUFF.Controls
{
    partial class ADashboardContainer
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
            dashBoardContainer1 = new CIPHER.Forms.Controls.DashBoardContainer();
            SuspendLayout();
            // 
            // dashBoardContainer1
            // 
            dashBoardContainer1.BackColor = SystemColors.Control;
            dashBoardContainer1.Dock = DockStyle.Fill;
            dashBoardContainer1.Location = new Point(0, 0);
            dashBoardContainer1.Name = "dashBoardContainer1";
            dashBoardContainer1.Size = new Size(1280, 750);
            dashBoardContainer1.TabIndex = 0;
            // 
            // ADashboardContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dashBoardContainer1);
            Name = "ADashboardContainer";
            Size = new Size(1280, 750);
            ResumeLayout(false);
        }

        #endregion

        private Forms.Controls.DashBoardContainer dashBoardContainer1;
    }
}
