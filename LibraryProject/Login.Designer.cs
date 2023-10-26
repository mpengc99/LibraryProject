namespace LibraryProject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            Close = new Label();
            Cancel = new Label();
            AdminLoginBtn = new Button();
            OkBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            PasswordText = new TextBox();
            UsernameText = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Close);
            panel2.Controls.Add(Cancel);
            panel2.Controls.Add(AdminLoginBtn);
            panel2.Controls.Add(OkBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(PasswordText);
            panel2.Controls.Add(UsernameText);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 429);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Transparent;
            Close.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Close.Location = new Point(662, 0);
            Close.Name = "Close";
            Close.Size = new Size(35, 45);
            Close.TabIndex = 23;
            Close.Text = "-";
            Close.Click += Close_Click;
            // 
            // Cancel
            // 
            Cancel.AutoSize = true;
            Cancel.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel.Location = new Point(713, 0);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(45, 45);
            Cancel.TabIndex = 9;
            Cancel.Text = "×";
            Cancel.Click += label4_Click;
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.BackColor = SystemColors.ButtonFace;
            AdminLoginBtn.FlatAppearance.BorderSize = 0;
            AdminLoginBtn.Location = new Point(465, 340);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(133, 41);
            AdminLoginBtn.TabIndex = 8;
            AdminLoginBtn.Text = "Admin Login";
            AdminLoginBtn.UseVisualStyleBackColor = false;
            AdminLoginBtn.Click += button2_Click;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(255, 128, 0);
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.Location = new Point(465, 269);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(133, 41);
            OkBtn.TabIndex = 7;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(311, 202);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(311, 133);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(465, 204);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(220, 27);
            PasswordText.TabIndex = 3;
            PasswordText.TextChanged += textBox2_TextChanged;
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(465, 133);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(220, 27);
            UsernameText.TabIndex = 2;
            UsernameText.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(465, 48);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 1;
            label1.Text = "Login Panel";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox PasswordText;
        private TextBox UsernameText;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button OkBtn;
        private Button AdminLoginBtn;
        private Label Cancel;
        private Label Close;
    }
}