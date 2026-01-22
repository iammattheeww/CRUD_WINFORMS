using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CRUD_FORMS
{
    partial class Form3
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
            customerName = new Label();
            customerEmail = new Label();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCustomers = new DataGridView();
            customerId = new Label();
            btnManage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(33, 99);
            customerName.Name = "customerName";
            customerName.Size = new Size(49, 20);
            customerName.TabIndex = 1;
            customerName.Text = "Name";
            // 
            // customerEmail
            // 
            customerEmail.AutoSize = true;
            customerEmail.Location = new Point(33, 148);
            customerEmail.Name = "customerEmail";
            customerEmail.Size = new Size(46, 20);
            customerEmail.TabIndex = 2;
            customerEmail.Text = "Email";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(163, 48);
            txtCustomerId.Margin = new Padding(3, 4, 3, 4);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(165, 27);
            txtCustomerId.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(163, 97);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(165, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(163, 147);
            txtCustomerEmail.Margin = new Padding(3, 4, 3, 4);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(165, 27);
            txtCustomerEmail.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 272);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 272);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(238, 272);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(338, 272);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(33, 339);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(623, 316);
            dgvCustomers.TabIndex = 12;
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Location = new Point(33, 49);
            customerId.Name = "customerId";
            customerId.Size = new Size(91, 20);
            customerId.TabIndex = 13;
            customerId.Text = "Customer ID";
            // 
            // btnManage
            // 
            btnManage.Location = new Point(438, 272);
            btnManage.Margin = new Padding(3, 4, 3, 4);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(86, 31);
            btnManage.TabIndex = 14;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 695);
            Controls.Add(btnManage);
            Controls.Add(customerId);
            Controls.Add(dgvCustomers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(customerEmail);
            Controls.Add(customerName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label customerName;
        private Label customerEmail;
        private TextBox txtCustomerId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCustomers;
        private Label customerId;
        private Button btnManage;
    }
}