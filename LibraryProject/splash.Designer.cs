﻿namespace LibraryProject
{
    partial class splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Percentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(121, 35);
            label1.Name = "label1";
            label1.Size = new Size(558, 90);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(60, 412);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(659, 29);
            Myprogress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(351, 372);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 3;
            label2.Text = "Loading...";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Location = new Point(445, 374);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(22, 20);
            Percentage.TabIndex = 4;
            Percentage.Text = "%";
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(782, 453);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
    }
}