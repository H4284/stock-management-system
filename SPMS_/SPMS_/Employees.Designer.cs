using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SPMS_
{
    partial class Employees
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
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPME_SDataSet = new SPMS_.SPME_SDataSet();
            this.employeesTableAdapter = new SPMS_.SPME_SDataSetTableAdapters.EmployeesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Lavender;
            this.add.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.add.Location = new System.Drawing.Point(106, 560);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 42);
            this.add.TabIndex = 1;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Lavender;
            this.update.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.update.Location = new System.Drawing.Point(274, 560);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(132, 42);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Lavender;
            this.delete.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.delete.Location = new System.Drawing.Point(433, 560);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 42);
            this.delete.TabIndex = 3;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.roleeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(358, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 221);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleeDataGridViewTextBoxColumn
            // 
            this.roleeDataGridViewTextBoxColumn.DataPropertyName = "Rolee";
            this.roleeDataGridViewTextBoxColumn.HeaderText = "Rolee";
            this.roleeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleeDataGridViewTextBoxColumn.Name = "roleeDataGridViewTextBoxColumn";
            this.roleeDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.sPME_SDataSet;
            // 
            // sPME_SDataSet
            // 
            this.sPME_SDataSet.DataSetName = "SPME_SDataSet";
            this.sPME_SDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "First Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Second Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 377);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Phone Number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 440);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(214, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Role";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 632);
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
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPME_SDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button add;
        private Button update;
        private Button delete;
        private BindingSource profileBindingSource;
     
        private BindingSource employeesBindingSource;
        private DataGridView dataGridView1;
        private SPME_SDataSet sPME_SDataSet;
        private BindingSource employeesBindingSource1;
        private SPME_SDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleeDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}