namespace CIPHER
{
    partial class SidebarControl
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
            panel1 = new Panel();
            btnLogs = new Button();
            btnNetwork = new Button();
            btnMissions = new Button();
            btnTerminal = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 10, 15);
            panel1.Controls.Add(btnLogs);
            panel1.Controls.Add(btnNetwork);
            panel1.Controls.Add(btnMissions);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 471);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogs
            // 
            btnLogs.AccessibleName = "";
            btnLogs.BackColor = Color.Transparent;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.ForeColor = SystemColors.ButtonHighlight;
            btnLogs.Location = new Point(3, 366);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(180, 40);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "LOGS";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.MouseEnter += btnLogs_MouseEnter;
            btnLogs.MouseLeave += btnLogs_MouseLeave;
            btnLogs.MouseHover += btnLogs_MouseHover;
            // 
            // btnNetwork
            // 
            btnNetwork.AccessibleName = "";
            btnNetwork.BackColor = Color.Transparent;
            btnNetwork.FlatAppearance.BorderSize = 0;
            btnNetwork.FlatStyle = FlatStyle.Flat;
            btnNetwork.ForeColor = SystemColors.ButtonHighlight;
            btnNetwork.Location = new Point(3, 253);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(180, 40);
            btnNetwork.TabIndex = 4;
            btnNetwork.Text = "NETWORK";
            btnNetwork.UseVisualStyleBackColor = true;
            btnNetwork.MouseEnter += btnNetwork_MouseEnter;
            btnNetwork.MouseLeave += btnNetwork_MouseLeave;
            btnNetwork.MouseHover += btnNetwork_MouseHover;
            // 
            // btnMissions
            // 
            btnMissions.AccessibleName = "";
            btnMissions.BackColor = Color.Transparent;
            btnMissions.FlatAppearance.BorderSize = 0;
            btnMissions.FlatStyle = FlatStyle.Flat;
            btnMissions.ForeColor = SystemColors.ButtonHighlight;
            btnMissions.Location = new Point(3, 149);
            btnMissions.Name = "btnMissions";
            btnMissions.Size = new Size(180, 40);
            btnMissions.TabIndex = 3;
            btnMissions.Text = "MISSIONS";
            btnMissions.UseVisualStyleBackColor = true;
            btnMissions.MouseEnter += btnMissions_MouseEnter;
            btnMissions.MouseLeave += btnMissions_MouseLeave;
            btnMissions.MouseHover += btnMissions_MouseHover;
            // 
            // btnTerminal
            // 
            btnTerminal.Location = new Point(271, 149);
            btnTerminal.Name = "btnTerminal";
            btnTerminal.Size = new Size(75, 23);
            btnTerminal.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(41, 52);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 1;
            label2.Text = "v2.0.4-STABLE";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "CIPHER";
            label1.Click += label1_Click;
            // 
            // SidebarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Controls.Add(btnTerminal);
            Name = "SidebarControl";
            Size = new Size(576, 471);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnLogs;
        private Button btnNetwork;
        private Button btnMissions;
        private Button btnTerminal;
    }
}
