using SPMS_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMS_
{
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void LoadFormInPanel(Form form)
        {
            panelMain1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain1.Controls.Add(form);
            form.Show();
        }

        private void ProductsBtn1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Products());
        }

        private void OrdersBtn1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Orders());
        }

        private void SellersBtn1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Sellers());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void DashboardUser_Load(object sender, EventArgs e)
        {

        }
        private void panelMain1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
