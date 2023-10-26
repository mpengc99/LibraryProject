namespace LibraryProject
{
    partial class User
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel2 = new Panel();
            Refresh = new Button();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            UserList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Minimize = new Label();
            PassTb = new TextBox();
            Close = new Label();
            AddTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            PhoneTb = new TextBox();
            UnameTb = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            panel9 = new Panel();
            pictureBox7 = new PictureBox();
            label12 = new Label();
            panel10 = new Panel();
            pictureBox8 = new PictureBox();
            label13 = new Label();
            Book = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
            pictureBox10 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserList).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(Refresh);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(UserList);
            panel2.Controls.Add(Minimize);
            panel2.Controls.Add(PassTb);
            panel2.Controls.Add(Close);
            panel2.Controls.Add(AddTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PhoneTb);
            panel2.Controls.Add(UnameTb);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(186, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 629);
            panel2.TabIndex = 3;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.FromArgb(255, 128, 0);
            Refresh.FlatAppearance.BorderSize = 0;
            Refresh.Location = new Point(460, 256);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(133, 41);
            Refresh.TabIndex = 32;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(255, 128, 0);
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.Location = new Point(641, 195);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(133, 41);
            ResetBtn.TabIndex = 31;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(255, 128, 0);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.Location = new Point(424, 195);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(133, 41);
            DeleteBtn.TabIndex = 30;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.Location = new Point(225, 195);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(133, 41);
            EditBtn.TabIndex = 29;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.Location = new Point(20, 195);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(133, 41);
            SaveBtn.TabIndex = 28;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UserList
            // 
            UserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserList.BackgroundColor = SystemColors.Control;
            UserList.BorderStyle = BorderStyle.None;
            UserList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            UserList.EnableHeadersVisualStyles = false;
            UserList.Location = new Point(20, 300);
            UserList.Name = "UserList";
            UserList.ReadOnly = true;
            UserList.RowHeadersVisible = false;
            UserList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            UserList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            UserList.RowTemplate.Height = 29;
            UserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserList.Size = new Size(754, 326);
            UserList.TabIndex = 27;
            UserList.CellContentClick += UserList_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UId";
            Column1.HeaderText = "User ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UName";
            Column2.HeaderText = "User";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "UPhone";
            Column3.HeaderText = "Phone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "UAdd";
            Column4.HeaderText = "Address";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "UPassword";
            Column5.HeaderText = "Password";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Minimize
            // 
            Minimize.AutoSize = true;
            Minimize.BackColor = Color.Transparent;
            Minimize.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Minimize.Location = new Point(710, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(35, 45);
            Minimize.TabIndex = 26;
            Minimize.Text = "-";
            Minimize.Click += Minimize_Click;
            // 
            // PassTb
            // 
            PassTb.Location = new Point(583, 133);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(125, 27);
            PassTb.TabIndex = 23;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Transparent;
            Close.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Close.Location = new Point(739, 0);
            Close.Name = "Close";
            Close.Size = new Size(45, 45);
            Close.TabIndex = 25;
            Close.Text = "×";
            Close.Click += Close_Click;
            // 
            // AddTb
            // 
            AddTb.Location = new Point(409, 133);
            AddTb.Name = "AddTb";
            AddTb.Size = new Size(125, 27);
            AddTb.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(330, 261);
            label7.Name = "label7";
            label7.Size = new Size(92, 27);
            label7.TabIndex = 20;
            label7.Text = "User List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 99);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 99);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 100);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 100);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "User";
            label2.Click += label2_Click;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(233, 133);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(125, 27);
            PhoneTb.TabIndex = 2;
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(56, 133);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(125, 27);
            UnameTb.TabIndex = 1;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 40);
            label1.Name = "label1";
            label1.Size = new Size(81, 39);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(Book);
            panel7.Controls.Add(pictureBox10);
            panel7.Location = new Point(12, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 629);
            panel7.TabIndex = 24;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(18, 511);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 77);
            panel8.TabIndex = 28;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 26);
            label4.Name = "label4";
            label4.Size = new Size(45, 27);
            label4.TabIndex = 22;
            label4.Text = "Exit";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(18, 404);
            panel9.Name = "panel9";
            panel9.Size = new Size(130, 77);
            panel9.TabIndex = 27;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(50, 28);
            label12.Name = "label12";
            label12.Size = new Size(72, 24);
            label12.TabIndex = 22;
            label12.Text = "Setting";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(label13);
            panel10.Location = new Point(18, 300);
            panel10.Name = "panel10";
            panel10.Size = new Size(130, 77);
            panel10.TabIndex = 24;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 19);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(60, 29);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 22;
            label13.Text = "User";
            // 
            // Book
            // 
            Book.BackColor = Color.White;
            Book.Controls.Add(pictureBox9);
            Book.Controls.Add(label14);
            Book.Location = new Point(18, 195);
            Book.Name = "Book";
            Book.Size = new Size(130, 77);
            Book.TabIndex = 23;
            Book.Paint += panel11_Paint;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(3, 16);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 43);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(55, 25);
            label14.Name = "label14";
            label14.Size = new Size(53, 24);
            label14.TabIndex = 22;
            label14.Text = "Book";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(18, 40);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(130, 130);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 2;
            pictureBox10.TabStop = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel7);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preference";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserList).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            Book.ResumeLayout(false);
            Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox PhoneTb;
        private TextBox UnameTb;
        private Label label1;
        private TextBox PassTb;
        private TextBox AddTb;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pictureBox6;
        private Label label4;
        private Panel panel9;
        private PictureBox pictureBox7;
        private Label label12;
        private Panel panel10;
        private PictureBox pictureBox8;
        private Label label13;
        private Panel Book;
        private PictureBox pictureBox9;
        private Label label14;
        private PictureBox pictureBox10;
        private Label Minimize;
        private Label Close;
        private DataGridView UserList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Button Refresh;
    }
}