using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SPMS_
{
    partial class DashboardUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellersBtn1 = new System.Windows.Forms.Button();
            this.OrdersBtn1 = new System.Windows.Forms.Button();
            this.ProductsBtn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMain1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.SellersBtn1);
            this.panel1.Controls.Add(this.OrdersBtn1);
            this.panel1.Controls.Add(this.ProductsBtn1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 1123);
            this.panel1.TabIndex = 0;
            // 
            // SellersBtn1
            // 
            this.SellersBtn1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SellersBtn1.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.SellersBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SellersBtn1.Location = new System.Drawing.Point(44, 283);
            this.SellersBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellersBtn1.Name = "SellersBtn1";
            this.SellersBtn1.Size = new System.Drawing.Size(247, 62);
            this.SellersBtn1.TabIndex = 2;
            this.SellersBtn1.Text = "Sellers";
            this.SellersBtn1.UseVisualStyleBackColor = false;
            this.SellersBtn1.Click += new System.EventHandler(this.SellersBtn1_Click);
            // 
            // OrdersBtn1
            // 
            this.OrdersBtn1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OrdersBtn1.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.OrdersBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrdersBtn1.Location = new System.Drawing.Point(44, 199);
            this.OrdersBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersBtn1.Name = "OrdersBtn1";
            this.OrdersBtn1.Size = new System.Drawing.Size(247, 60);
            this.OrdersBtn1.TabIndex = 1;
            this.OrdersBtn1.Text = "Orders";
            this.OrdersBtn1.UseVisualStyleBackColor = false;
            this.OrdersBtn1.Click += new System.EventHandler(this.OrdersBtn1_Click);
            // 
            // ProductsBtn1
            // 
            this.ProductsBtn1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProductsBtn1.Font = new System.Drawing.Font("Berlin Sans FB", 28.2F);
            this.ProductsBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductsBtn1.Location = new System.Drawing.Point(44, 118);
            this.ProductsBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsBtn1.Name = "ProductsBtn1";
            this.ProductsBtn1.Size = new System.Drawing.Size(247, 61);
            this.ProductsBtn1.TabIndex = 0;
            this.ProductsBtn1.Text = "Products";
            this.ProductsBtn1.UseVisualStyleBackColor = false;
            this.ProductsBtn1.Click += new System.EventHandler(this.ProductsBtn1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(698, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 137);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stokify";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1294, 860);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMain1
            // 
            this.panelMain1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMain1.Location = new System.Drawing.Point(369, 148);
            this.panelMain1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain1.Name = "panelMain1";
            this.panelMain1.Size = new System.Drawing.Size(1082, 696);
            this.panelMain1.TabIndex = 9;
            this.panelMain1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain1_Paint);
            // 
            // DashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 917);
            this.Controls.Add(this.panelMain1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardUser_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button SellersBtn1;
        private Button OrdersBtn1;
        private Button ProductsBtn1;
        private Label label3;
        private Button button1;
        private Panel panelMain1;
    }
}