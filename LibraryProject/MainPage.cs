using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class MainPage : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainPage()
        {
            InitializeComponent();
            populate();

            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            this.MouseUp += new MouseEventHandler(Login_MouseUp);
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pengcheng\Documents\LibraryProject\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");


        //查询数据库
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

        //rest of the codes



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAutTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into BookTb1 values('" + BTitleTb.Text + "','" + BAutTb.Text + "','" + BCatCb.SelectedItem.ToString() + "', " + QtyTb.Text + "," + PriceTb.Text + ")";

                    SqlCommand cmd = new(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book information has been saved successfully");

                    Con.Close();

                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void User_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Click(object sender, MouseEventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }

        private void User_Paint_1(object sender, PaintEventArgs e)
        {

        }

        int key = 0;
        private void BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookList.SelectedRows[0].Cells[1].Value.ToString();
            BAutTb.Text = BookList.SelectedRows[0].Cells[2].Value.ToString();
            BCatCb.SelectedItem = BookList.SelectedRows[0].Cells[3].Value.ToString();
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Filter()
        {
            Con.Open();

            string query = "select * from BookTb1 where BCat = '" + CatCbSearchCb.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();

            var ds = new DataSet();
            sda.Fill(ds);
            BookList.DataSource = ds.Tables[0];

            Con.Close();
        }

        //reset 将列表设置为空
        private void Reset()
        {
            BTitleTb.Text = "";
            BAutTb.Text = "";
            BCatCb.SelectedIndex = -1;
            QtyTb.Text = "";
            PriceTb.Text = "";

        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "delete from BookTb1 where BId = " + key + " ";

                    SqlCommand cmd = new(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book information has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Con.Close();

                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAutTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "update BookTb1 set BTitle = '" + BTitleTb.Text + "', BAuthor = '" + BAutTb.Text + "', BCat = '" + BCatCb.SelectedItem.ToString() + "',BQty = " + QtyTb.Text + ", BPrice = " + PriceTb.Text + " where BId = " + key + " ";

                    SqlCommand cmd = new(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book information has been updated successfully!");

                    Con.Close();

                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BTitleTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
