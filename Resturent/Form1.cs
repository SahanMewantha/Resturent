using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Resturent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "" || textusername.Text == null)
            {
                MessageBox.Show("username empty !");
                textusername.Focus();
                return;
            }
            if (textpassword.Text == "" || textpassword.Text == null)
            {
                MessageBox.Show("password empty !");
                textpassword.Focus();
                return;
            }

            // admin Database

            string user_name = textusername.Text.ToString();
            string Password = textpassword.Text.ToString();
            string access = "";

            DbTransactions login = new DbTransactions();
            bool status = login.loginCheck(user_name, Password);
            access = login.Access;

            if (status == false)
            {
                MessageBox.Show("Invalid Login");
                textusername.Text = "";
                textpassword.Text = "";
                textusername.Focus();
                return;
            }
            if (status == true)
            {
                if (access == "admin")
                {
                    //admin access
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();

                }
                else if (access == "user")
                {
                    // user access
                    Food food = new Food();
                    food.Show();
                    this.Hide();
                }
            }

            //employee database

            // string cus_name = textusername.Text.ToString();
            // string password = textpassword.Text.ToString();
            //Dbemploye emp = new Dbemploye();
            //bool stat = emp.cuscheack(cus_name, password);
            //if (stat == false)
            //{
            //  MessageBox.Show("Invalid Login as Employee !");
            //textusername.Text = "";
            //textpassword.Text = "";
            //textusername.Focus();
            // return;
            //}
            //if (stat == true)
            //{

            // need to connect next interface
            //  Empdashboard empd = new Empdashboard();
            //empd.Show();

            //this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
