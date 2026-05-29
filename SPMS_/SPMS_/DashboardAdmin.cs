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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E3F9");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7E84CE");
        }

       
        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void LoadFormInPanel(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void EmployeesBtn_Click_1(object sender, EventArgs e)
        {
            Employees empForm = new Employees();
            LoadFormInPanel(empForm);
        }

        private void ProductsBtn_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new Products());
        }

        private void OrdersBtn_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new Orders());
        }

        private void SellersBtn_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new Sellers());
        }

        private void DashboardAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
