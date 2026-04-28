using CIPHER.Helpers;

namespace CIPHER.Forms.Content
{
    partial class MissionContent
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblMissionPage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(46, 97);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(712, 455);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMissionPage);
            panel1.Location = new Point(47, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 41);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(631, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 41);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(46, 570);
            panel3.Name = "panel3";
            panel3.Size = new Size(712, 22);
            panel3.TabIndex = 3;
            // 
            // lblMissionPage
            // 
            lblMissionPage.Anchor = AnchorStyles.Left;
            lblMissionPage.AutoSize = true;
            lblMissionPage.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissionPage.ForeColor = SystemColors.ControlLightLight;
            lblMissionPage.Location = new Point(3, 0);
            lblMissionPage.Name = "lblMissionPage";
            lblMissionPage.Size = new Size(130, 29);
            lblMissionPage.TabIndex = 0;
            lblMissionPage.Text = "MISSIONS";
            // 
            // MissionContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "MissionContent";
            Size = new Size(819, 615);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblMissionPage;
    }
}
