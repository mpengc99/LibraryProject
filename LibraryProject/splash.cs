namespace LibraryProject
{
    public partial class splash : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public splash()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            this.MouseUp += new MouseEventHandler(Login_MouseUp);
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        int startpos = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            startpos += 1;
            Myprogress.Value = startpos;

            Percentage.Text = startpos + "%";

            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }

        }
    }
}