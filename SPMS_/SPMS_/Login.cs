using System.Drawing;
using System.Windows.Forms;
using System;

namespace SPMS_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void loginPanel(object sender, PaintEventArgs e)
        {

        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" && txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Username" && txtUsername.ForeColor == Color.Gray)
            {
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }


        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Hava Jusufi" && password == "admin123")
            {
                DashboardAdmin adminDashboard = new DashboardAdmin();
                adminDashboard.Show();
                this.Hide();
            }
            else if (username == "Arbnor Jusufi" && password == "user123")
            {
                DashboardUser userDashboard = new DashboardUser();
                userDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username ose password i gabuar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
