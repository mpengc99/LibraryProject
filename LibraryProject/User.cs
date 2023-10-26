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
    public partial class User : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public User()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            this.MouseUp += new MouseEventHandler(Login_MouseUp);
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

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pengcheng\Documents\LibraryProject\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            Con.Open();

            string query = "select * from UserTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();

            var ds = new DataSet();
            sda.Fill(ds);
            UserList.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into UserTb1 values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "', " + PassTb.Text + ")";

                    SqlCommand cmd = new(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User information has been saved successfully");

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

        private void Refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "update UserTb1 set UName = '" + UnameTb.Text + "', UPhone = '" + PhoneTb.Text + "', UAdd = '" + AddTb.Text + "',UPassword = '" + PassTb.Text + "' where UId = "+key+"";

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

        int key = 0;
        private void UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = UserList.SelectedRows[0].Cells[2].Value.ToString();
            AddTb.Text = UserList.SelectedRows[0].Cells[3].Value.ToString();
            PassTb.Text = UserList.SelectedRows[0].Cells[4].Value.ToString();


            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserList.SelectedRows[0].Cells[0].Value.ToString());
            }
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

                    string query = "delete from UserTb1 where UId = " + key + " ";

                    SqlCommand cmd = new(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User information has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Reset()
        {
            UnameTb.Text = "";
            PhoneTb.Text = "";

            AddTb.Text = "";
            PassTb.Text = "";

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
