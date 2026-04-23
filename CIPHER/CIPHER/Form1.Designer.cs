namespace CIPHER
{
    partial class Form1
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
            sidebarControl1 = new SidebarControl();
            panelHeader = new Panel();
            btnLogic = new Button();
            btnBinary = new Button();
            btnCrypto = new Button();
            btnAll = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = SystemColors.Control;
            sidebarControl1.Location = new Point(-2, -1);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(199, 589);
            sidebarControl1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 20, 25);
            panelHeader.Controls.Add(btnLogic);
            panelHeader.Controls.Add(btnBinary);
            panelHeader.Controls.Add(btnCrypto);
            panelHeader.Controls.Add(btnAll);
            panelHeader.Location = new Point(197, -1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(933, 125);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panel1_Paint_1;
            // 
            // btnLogic
            // 
            btnLogic.FlatStyle = FlatStyle.Flat;
            btnLogic.FlatAppearance.BorderSize = 0;
            btnLogic.ForeColor = Color.White;
            btnLogic.BackColor= Color.Transparent;
            btnLogic.Font= new Font("Segoe UI",10, FontStyle.Bold, GraphicsUnit.Point);
            btnLogic.Location = new Point(800, 15);
            btnLogic.Name = "btnLogic";
            btnLogic.Size = new Size(90, 30);
            btnLogic.TabIndex = 3;
            btnLogic.Text = "LOGIC";
            btnLogic.UseVisualStyleBackColor = true;

            // 
            // btnBinary
            // 
            btnBinary.FlatStyle = FlatStyle.Flat;
            btnBinary.FlatAppearance.BorderSize = 0;
            btnBinary.ForeColor = Color.White;
            btnBinary.BackColor= Color.Transparent;
            btnBinary.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
            btnBinary.Location = new Point(700, 15);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(90, 30);
            btnBinary.TabIndex = 2;
            btnBinary.Text = "BINARY";
            btnBinary.UseVisualStyleBackColor = true;
            // 
            // btnCrypto
            // 
            btnCrypto.FlatStyle = FlatStyle.Flat;
            btnCrypto.FlatAppearance.BorderSize = 0;
            btnCrypto.ForeColor = Color.White;
            btnCrypto.BackColor= Color.Transparent;
            btnCrypto.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
            btnCrypto.Location = new Point(600, 15);
            btnCrypto.Name = "btnCrypto";
            btnCrypto.Size = new Size(90, 30);
            btnCrypto.TabIndex = 1;
            btnCrypto.Text = "CRYPTO";
            btnCrypto.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.ForeColor = Color.White;
            btnAll.BackColor= Color.Transparent;
            btnAll.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.Location = new Point(500, 15);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(90, 30);
            btnAll.TabIndex = 0;
            btnAll.Text = "ALL";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 772);
            Controls.Add(panelHeader);
            Controls.Add(sidebarControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SidebarControl sidebarControl1;
        private Panel panelHeader;
        private Button btnLogic;
        private Button btnBinary;
        private Button btnCrypto;
        private Button btnAll;
    }
}
