using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SPMS_
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardAdminPanel = new System.Windows.Forms.Panel();
            this.SellersBtn = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.DashboardAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardAdminPanel
            // 
            this.DashboardAdminPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.DashboardAdminPanel.Controls.Add(this.SellersBtn);
            this.DashboardAdminPanel.Controls.Add(this.OrdersBtn);
            this.DashboardAdminPanel.Controls.Add(this.ProductsBtn);
            this.DashboardAdminPanel.Controls.Add(this.EmployeesBtn);
            this.DashboardAdminPanel.Location = new System.Drawing.Point(0, 1);
            this.DashboardAdminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardAdminPanel.Name = "DashboardAdminPanel";
            this.DashboardAdminPanel.Size = new System.Drawing.Size(344, 1077);
            this.DashboardAdminPanel.TabIndex = 0;
            // 
            // SellersBtn
            // 
            this.SellersBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SellersBtn.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.SellersBtn.Location = new System.Drawing.Point(31, 310);
            this.SellersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellersBtn.Name = "SellersBtn";
            this.SellersBtn.Size = new System.Drawing.Size(247, 59);
            this.SellersBtn.TabIndex = 3;
            this.SellersBtn.Text = "Sellers";
            this.SellersBtn.UseVisualStyleBackColor = false;
            this.SellersBtn.Click += new System.EventHandler(this.SellersBtn_Click_1);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OrdersBtn.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.OrdersBtn.Location = new System.Drawing.Point(31, 233);
            this.OrdersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(247, 62);
            this.OrdersBtn.TabIndex = 2;
            this.OrdersBtn.Text = "Orders";
            this.OrdersBtn.UseVisualStyleBackColor = false;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click_1);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProductsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.ProductsBtn.Location = new System.Drawing.Point(31, 151);
            this.ProductsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(247, 60);
            this.ProductsBtn.TabIndex = 1;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.UseVisualStyleBackColor = false;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click_1);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EmployeesBtn.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesBtn.Location = new System.Drawing.Point(31, 77);
            this.EmployeesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(247, 62);
            this.EmployeesBtn.TabIndex = 0;
            this.EmployeesBtn.Text = "Employees";
            this.EmployeesBtn.UseVisualStyleBackColor = false;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 131);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stokify";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.LogoutBtn.Font = new System.Drawing.Font("Berlin Sans FB", 20.2F);
            this.LogoutBtn.Location = new System.Drawing.Point(1338, 821);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(157, 49);
            this.LogoutBtn.TabIndex = 7;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click_1);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(381, 152);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1207, 649);
            this.panelMain.TabIndex = 8;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1670, 882);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DashboardAdminPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardAdmin_Load_1);
            this.DashboardAdminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DashboardAdminPanel;
        private Button SellersBtn;
        private Button OrdersBtn;
        private Button ProductsBtn;
        private Button EmployeesBtn;
        private Label label3;
        private Button LogoutBtn;
        private Panel panelMain;
    }
}