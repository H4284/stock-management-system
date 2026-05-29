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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
           
            this.productsTableAdapter.Fill(this.sPME_SDataSet.Products);
            

            LoadProducts();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "INSERT INTO Products (Id, NameOfProduct, Price, Quantity, SellerId) VALUES (@Id, @NameOfProduct, @Price, @Quantity, @SellerId)";
               using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@NameOfProduct", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@SellerId", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully.");
                    con.Close();
                }
            }
            LoadProducts();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "UPDATE Products SET NameOfProduct = @NameOfProduct, Price = @Price, Quantity = @Quantity, SellerId = @SellerId WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NameOfProduct", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@SellerId", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully.");
                    con.Close();
                }
            }
            LoadProducts();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "DELETE FROM Products WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully.");
                    con.Close();
                }
            }
            LoadProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
