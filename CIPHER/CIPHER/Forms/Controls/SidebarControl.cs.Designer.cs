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
            label2 = new Label();
            label1 = new Label();
            btnTerminal = new Button();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 353);
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
            btnLogs.Location = new Point(3, 274);
            btnLogs.Margin = new Padding(3, 2, 3, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(158, 30);
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
            btnNetwork.Location = new Point(3, 190);
            btnNetwork.Margin = new Padding(3, 2, 3, 2);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(158, 30);
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
            btnMissions.Location = new Point(3, 112);
            btnMissions.Margin = new Padding(3, 2, 3, 2);
            btnMissions.Name = "btnMissions";
            btnMissions.Size = new Size(158, 30);
            btnMissions.TabIndex = 3;
            btnMissions.Text = "MISSIONS";
            btnMissions.UseVisualStyleBackColor = true;
            btnMissions.MouseEnter += btnMissions_MouseEnter;
            btnMissions.MouseLeave += btnMissions_MouseLeave;
            btnMissions.MouseHover += btnMissions_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(36, 39);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 1;
            label2.Text = "v2.0.4-STABLE";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "CIPHER";
            label1.Click += label1_Click;
            // 
            // btnTerminal
            // 
            btnTerminal.Location = new Point(237, 112);
            btnTerminal.Margin = new Padding(3, 2, 3, 2);
            btnTerminal.Name = "btnTerminal";
            btnTerminal.Size = new Size(66, 17);
            btnTerminal.TabIndex = 6;
            // 
            // SidebarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Controls.Add(btnTerminal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SidebarControl";
            Size = new Size(504, 353);
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
