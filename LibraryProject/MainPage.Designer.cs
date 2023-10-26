namespace LibraryProject
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel2 = new Panel();
            Minimize = new Label();
            Close = new Label();
            Refresh = new Button();
            label7 = new Label();
            CatCbSearchCb = new ComboBox();
            BookList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            PriceTb = new TextBox();
            label6 = new Label();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            QtyTb = new TextBox();
            label5 = new Label();
            BCatCb = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BAutTb = new TextBox();
            BTitleTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            User = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookList).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(Minimize);
            panel2.Controls.Add(Close);
            panel2.Controls.Add(Refresh);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(CatCbSearchCb);
            panel2.Controls.Add(BookList);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BCatCb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BAutTb);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(186, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 629);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // Minimize
            // 
            Minimize.AutoSize = true;
            Minimize.BackColor = Color.Transparent;
            Minimize.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Minimize.Location = new Point(710, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(35, 45);
            Minimize.TabIndex = 23;
            Minimize.Text = "-";
            Minimize.Click += Minimize_Click;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Transparent;
            Close.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Close.Location = new Point(739, 0);
            Close.Name = "Close";
            Close.Size = new Size(45, 45);
            Close.TabIndex = 22;
            Close.Text = "×";
            Close.Click += label12_Click;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.FromArgb(255, 128, 0);
            Refresh.FlatAppearance.BorderSize = 0;
            Refresh.Location = new Point(641, 415);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(133, 41);
            Refresh.TabIndex = 21;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(684, 460);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 20;
            label7.Text = "List";
            // 
            // CatCbSearchCb
            // 
            CatCbSearchCb.FormattingEnabled = true;
            CatCbSearchCb.Items.AddRange(new object[] { "Children", "Literature & Art", "History", "Life", "Business Management", "Science & Tech" });
            CatCbSearchCb.Location = new Point(641, 483);
            CatCbSearchCb.Name = "CatCbSearchCb";
            CatCbSearchCb.Size = new Size(133, 28);
            CatCbSearchCb.TabIndex = 19;
            CatCbSearchCb.Text = "No select";
            CatCbSearchCb.SelectionChangeCommitted += CatCbSearchCb_SelectionChangeCommitted;
            // 
            // BookList
            // 
            BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookList.BackgroundColor = SystemColors.Control;
            BookList.BorderStyle = BorderStyle.None;
            BookList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            BookList.EnableHeadersVisualStyles = false;
            BookList.Location = new Point(20, 289);
            BookList.Name = "BookList";
            BookList.ReadOnly = true;
            BookList.RowHeadersVisible = false;
            BookList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            BookList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            BookList.RowTemplate.Height = 29;
            BookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookList.Size = new Size(615, 326);
            BookList.TabIndex = 18;
            BookList.CellContentClick += BookList_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BId";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BTitle";
            Column2.HeaderText = "Title";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BAuthor";
            Column3.HeaderText = "Author";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "BCat";
            Column4.HeaderText = "Category";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BQty";
            Column5.HeaderText = "Amount";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "BPrice";
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(706, 119);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(70, 27);
            PriceTb.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(706, 88);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 16;
            label6.Text = "Price";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(255, 128, 0);
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.Location = new Point(641, 231);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(133, 41);
            ResetBtn.TabIndex = 15;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(255, 128, 0);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.Location = new Point(424, 231);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(133, 41);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.Location = new Point(225, 231);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(133, 41);
            EditBtn.TabIndex = 13;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.Location = new Point(20, 231);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(133, 41);
            SaveBtn.TabIndex = 12;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += Save_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(619, 119);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(70, 27);
            QtyTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 88);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Amount";
            // 
            // BCatCb
            // 
            BCatCb.FormattingEnabled = true;
            BCatCb.Items.AddRange(new object[] { "Children", "Literature & Art", "History", "Life", "Business Management", "Science & Tech" });
            BCatCb.Location = new Point(459, 118);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(143, 28);
            BCatCb.TabIndex = 9;
            BCatCb.Text = "No Select";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 88);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Book name";
            // 
            // BAutTb
            // 
            BAutTb.Location = new Point(269, 120);
            BAutTb.Name = "BAutTb";
            BAutTb.Size = new Size(170, 27);
            BAutTb.TabIndex = 2;
            BAutTb.TextChanged += Author_TextChanged;
            // 
            // BTitleTb
            // 
            BTitleTb.Location = new Point(35, 121);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(218, 27);
            BTitleTb.TabIndex = 1;
            BTitleTb.TextChanged += BTitleTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(349, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 39);
            label1.TabIndex = 0;
            label1.Text = "Book";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(User);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 629);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(18, 511);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 77);
            panel6.TabIndex = 28;
            panel6.Paint += panel6_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(60, 26);
            label11.Name = "label11";
            label11.Size = new Size(45, 27);
            label11.TabIndex = 22;
            label11.Text = "Exit";
            label11.Click += label11_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(18, 404);
            panel5.Name = "panel5";
            panel5.Size = new Size(130, 77);
            panel5.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(54, 28);
            label10.Name = "label10";
            label10.Size = new Size(72, 24);
            label10.TabIndex = 22;
            label10.Text = "Setting";
            label10.Click += label10_Click;
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.Controls.Add(pictureBox3);
            User.Controls.Add(label9);
            User.Location = new Point(18, 300);
            User.Name = "User";
            User.Size = new Size(130, 77);
            User.TabIndex = 24;
            User.Paint += User_Paint_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(60, 29);
            label9.Name = "label9";
            label9.Size = new Size(48, 24);
            label9.TabIndex = 22;
            label9.Text = "User";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(18, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 77);
            panel3.TabIndex = 23;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(55, 25);
            label8.Name = "label8";
            label8.Size = new Size(53, 24);
            label8.TabIndex = 22;
            label8.Text = "Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookList).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            User.ResumeLayout(false);
            User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button Refresh;
        private Label label7;
        private ComboBox CatCbSearchCb;
        private TextBox PriceTb;
        private Label label6;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private TextBox QtyTb;
        private Label label5;
        private ComboBox BCatCb;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox BAutTb;
        private TextBox BTitleTb;
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label11;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Label label10;
        private Panel User;
        private PictureBox pictureBox3;
        private Label label9;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private Label Close;
        private Label Minimize;
        private DataGridView BookList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}