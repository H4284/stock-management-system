using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMS_
{
 
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();

            
        }

      private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
               SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
            this.ordersTableAdapter.Fill(this.sPME_SDataSet.Orders);
           

            LoadOrders();


        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "INSERT INTO Orders ( Id, OrderDate, Status, UserId, ProductId, Quantity) VALUES ( @Id, @OrderDate, @Status, @UserId, @ProductId, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Status", textBox1.Text);
                    cmd.Parameters.AddWithValue("@UserId", textBox4.Text);
                    cmd.Parameters.AddWithValue("@ProductId", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully.");
                    con.Close();
                }
            }
            LoadOrders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "UPDATE Orders SET OrderDate = @OrderDate, Status = @Status, UserId = @UserId, ProductId = @ProductId, Quantity = @Quantity WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Status", textBox1.Text);
                    cmd.Parameters.AddWithValue("@UserId", textBox4.Text);
                    cmd.Parameters.AddWithValue("@ProductId", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order updated successfully.");
                    con.Close();
                }
            }
            LoadOrders();
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(textBox5.Text);
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=SPME_S;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "DELETE FROM Orders WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order deleted successfully.");
                    con.Close();
                }
            }
            LoadOrders();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

