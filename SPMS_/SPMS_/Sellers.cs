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

namespace SPMS_
{
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
        }

       private void LoadSellers()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sellers", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
           
            this.sellersTableAdapter.Fill(this.sPME_SDataSet.Sellers);
            

            LoadSellers();

        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "INSERT INTO Sellers (Id, NameOfSeller, Email, PhoneNumber, Location) VALUES (@Id, @NameOfSeller, @Email, @PhoneNumber, @Location)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@NameOfSeller", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Location", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller added successfully");
                    con.Close();
                }
            }
            LoadSellers();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "UPDATE Sellers SET NameOfSeller = @NameOfSeller, Email = @Email, PhoneNumber = @PhoneNumber, Location = @Location WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NameOfSeller", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Location", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller updated successfully");
                    con.Close();
                }
            }
            LoadSellers();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "DELETE FROM Sellers WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted successfully");
                    con.Close();
                }
            }
            LoadSellers();
        }
    }
}
