using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Billing : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Billing()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            this.MouseUp += new MouseEventHandler(Login_MouseUp);

            populate();
        }
        int key = 0;
        //achieve mouse drag window
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //connect to your database, change to your database file path

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pengcheng\Documents\LibraryProject\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();

            string query = "select * from BookTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();

            var ds = new DataSet();
            sda.Fill(ds);
            BookList.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";

        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to terminate this program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to terminate this program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookList.SelectedRows[0].Cells[1].Value.ToString();
            QtyTb.Text = BookList.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookList.SelectedRows[0].Cells[5].Value.ToString();

            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
