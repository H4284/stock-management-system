using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SPMS_
{
    partial class Sellers
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
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfSellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPME_SDataSet = new SPMS_.SPME_SDataSet();
            this.sellersTableAdapter = new SPMS_.SPME_SDataSetTableAdapters.SellersTableAdapter();
            this.spmE_SDataSet1 = new SPMS_.SPME_SDataSet();
            this.spmE_SDataSet2 = new SPMS_.SPME_SDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sellers";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Lavender;
            this.delete.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.delete.Location = new System.Drawing.Point(402, 500);
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
            this.update.Location = new System.Drawing.Point(253, 500);
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
            this.add.Location = new System.Drawing.Point(99, 500);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 42);
            this.add.TabIndex = 5;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfSellerDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(359, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 238);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameOfSellerDataGridViewTextBoxColumn
            // 
            this.nameOfSellerDataGridViewTextBoxColumn.DataPropertyName = "NameOfSeller";
            this.nameOfSellerDataGridViewTextBoxColumn.HeaderText = "NameOfSeller";
            this.nameOfSellerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameOfSellerDataGridViewTextBoxColumn.Name = "nameOfSellerDataGridViewTextBoxColumn";
            this.nameOfSellerDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellersBindingSource1
            // 
            this.sellersBindingSource1.DataMember = "Sellers";
            this.sellersBindingSource1.DataSource = this.sPME_SDataSet;
            // 
            // sPME_SDataSet
            // 
            this.sPME_SDataSet.DataSetName = "SPME_SDataSet";
            this.sPME_SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // spmE_SDataSet1
            // 
            this.spmE_SDataSet1.DataSetName = "SPME_SDataSet";
            this.spmE_SDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmE_SDataSet2
            // 
            this.spmE_SDataSet2.DataSetName = "SPME_SDataSet";
            this.spmE_SDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Name Of Seller";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Location";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 336);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Phone Number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Id";
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 582);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sellers";
            this.Text = "Sellers";
            this.Load += new System.EventHandler(this.Sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmE_SDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button delete;
        private Button update;
        private Button add;
       
        private BindingSource sellersBindingSource;
        private DataGridView dataGridView1;
        private SPME_SDataSet sPME_SDataSet;
        private BindingSource sellersBindingSource1;
        private SPME_SDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOfSellerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private SPME_SDataSet spmE_SDataSet1;
        private SPME_SDataSet spmE_SDataSet2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}