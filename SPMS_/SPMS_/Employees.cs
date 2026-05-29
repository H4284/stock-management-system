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
using System.Xml.Linq;

namespace SPMS_
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void LoadEmployees()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            
            this.employeesTableAdapter.Fill(this.sPME_SDataSet.Employees);
          
            LoadEmployees();
        }

        private void add_Click(object sender, EventArgs e)
        {
           using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "INSERT INTO Employees (Id, FirstName, SecondName, PhoneNumber, Rolee) VALUES (@Id, @FirstName, @SecondName, @PhoneNumber, @Rolee)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@SecondName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Rolee", textBox5.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadEmployees();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "UPDATE Employees SET FirstName = @FirstName, SecondName = @SecondName, PhoneNumber = @PhoneNumber, Rolee = @Rolee WHERE Id = @Id"; //@ parametra te sigurt, shmag sql injection
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@SecondName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Rolee", textBox5.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully.");
                    con.Close();
                }
            }
            LoadEmployees();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "DELETE FROM Employees WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully.");
                    con.Close();
                }
            }
            LoadEmployees();
        }
    }
}
