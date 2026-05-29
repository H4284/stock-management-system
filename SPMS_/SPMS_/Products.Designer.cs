using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SPMS_
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPME_SDataSet = new SPMS_.SPME_SDataSet();
            this.productsTableAdapter = new SPMS_.SPME_SDataSetTableAdapters.ProductsTableAdapter();
            this.spmE_SDataSet1 = new SPMS_.SPME_SDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Lavender;
            this.delete.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.delete.Location = new System.Drawing.Point(347, 491);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 42);
            this.delete.TabIndex = 7;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Lavender;
            this.update.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.update.Location = new System.Drawing.Point(199, 491);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(132, 42);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Lavender;
            this.add.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.add.Location = new System.Drawing.Point(50, 491);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 42);
            this.add.TabIndex = 9;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfProductDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sellerIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(321, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 230);
            this.dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameOfProductDataGridViewTextBoxColumn
            // 
            this.nameOfProductDataGridViewTextBoxColumn.DataPropertyName = "NameOfProduct";
            this.nameOfProductDataGridViewTextBoxColumn.HeaderText = "NameOfProduct";
            this.nameOfProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameOfProductDataGridViewTextBoxColumn.Name = "nameOfProductDataGridViewTextBoxColumn";
            this.nameOfProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellerIdDataGridViewTextBoxColumn
            // 
            this.sellerIdDataGridViewTextBoxColumn.DataPropertyName = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.HeaderText = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerIdDataGridViewTextBoxColumn.Name = "sellerIdDataGridViewTextBoxColumn";
            this.sellerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.sPME_SDataSet;
            // 
            // sPME_SDataSet
            // 
            this.sPME_SDataSet.DataSetName = "SPME_SDataSet";
            this.sPME_SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // spmE_SDataSet1
            // 
            this.spmE_SDataSet1.DataSetName = "SPME_SDataSet";
            this.spmE_SDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Name Of Product";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Quantity";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(81, 352);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 22);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "SellerId";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(81, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Id";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 546);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button delete;
        private Button update;
        private Button add;
        
        private BindingSource productsBindingSource;
        private DataGridView dataGridView1;
        private SPME_SDataSet sPME_SDataSet;
        private BindingSource productsBindingSource1;
        private SPME_SDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOfProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerIdDataGridViewTextBoxColumn;
        private SPME_SDataSet spmE_SDataSet1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}