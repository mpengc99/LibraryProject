namespace LibraryProject
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel2 = new Panel();
            BillList = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            RefreshBtn = new Button();
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
            AddToBillBtn = new Button();
            QtyTb = new TextBox();
            label5 = new Label();
            label8 = new Label();
            BTitleTb = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookList).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(BillList);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(BookList);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(AddToBillBtn);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(186, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 629);
            panel2.TabIndex = 29;
            panel2.Paint += panel2_Paint;
            // 
            // BillList
            // 
            BillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillList.BackgroundColor = SystemColors.Control;
            BillList.BorderStyle = BorderStyle.None;
            BillList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillList.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11 });
            BillList.EnableHeadersVisualStyles = false;
            BillList.Location = new Point(340, 127);
            BillList.Name = "BillList";
            BillList.ReadOnly = true;
            BillList.RowHeadersVisible = false;
            BillList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            BillList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            BillList.RowTemplate.Height = 29;
            BillList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillList.Size = new Size(430, 207);
            BillList.TabIndex = 24;
            // 
            // Column7
            // 
            Column7.HeaderText = "Order ID";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Title";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Price";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Amount";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Total Price";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(710, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 45);
            label1.TabIndex = 23;
            label1.Text = "-";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(739, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 45);
            label2.TabIndex = 22;
            label2.Text = "×";
            label2.Click += label2_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.FromArgb(255, 128, 0);
            RefreshBtn.FlatAppearance.BorderSize = 0;
            RefreshBtn.Location = new Point(150, 283);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(133, 41);
            RefreshBtn.TabIndex = 21;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += Refresh_Click;
            // 
            // BookList
            // 
            BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookList.BackgroundColor = SystemColors.Control;
            BookList.BorderStyle = BorderStyle.None;
            BookList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            BookList.EnableHeadersVisualStyles = false;
            BookList.Location = new Point(20, 348);
            BookList.Name = "BookList";
            BookList.ReadOnly = true;
            BookList.RowHeadersVisible = false;
            BookList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            BookList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            BookList.RowTemplate.Height = 29;
            BookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookList.Size = new Size(501, 267);
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
            PriceTb.Enabled = false;
            PriceTb.Location = new Point(54, 188);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(70, 27);
            PriceTb.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 165);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 16;
            label6.Text = "Price";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(255, 128, 0);
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.Location = new Point(150, 236);
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
            DeleteBtn.Location = new Point(546, 511);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(133, 41);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.Location = new Point(546, 464);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(133, 41);
            EditBtn.TabIndex = 13;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.FromArgb(255, 128, 0);
            AddToBillBtn.FlatAppearance.BorderSize = 0;
            AddToBillBtn.Location = new Point(150, 189);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(133, 41);
            AddToBillBtn.TabIndex = 12;
            AddToBillBtn.Text = "Add to Cart";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(54, 250);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(70, 27);
            QtyTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 227);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 104);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 5;
            label8.Text = "Book name";
            // 
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Location = new Point(54, 127);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(218, 27);
            BTitleTb.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(349, 40);
            label9.Name = "label9";
            label9.Size = new Size(105, 39);
            label9.TabIndex = 0;
            label9.Text = "Billing";
            label9.Click += label9_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 629);
            panel1.TabIndex = 28;
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
            // Billing
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillList).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookList).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button RefreshBtn;
        private DataGridView BookList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox PriceTb;
        private Label label6;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddToBillBtn;
        private TextBox QtyTb;
        private Label label5;
        private Label label8;
        private TextBox BTitleTb;
        private Label label9;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label11;
        private PictureBox pictureBox1;
        private DataGridView BillList;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}