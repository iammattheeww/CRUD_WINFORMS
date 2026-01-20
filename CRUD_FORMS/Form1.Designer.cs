namespace CRUD_FORMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /* 
         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         */


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnManage = new Button();
            dgvStudents = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtId = new Label();
            txtLastName = new Label();
            txtFirstName = new Label();
            txtEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(187, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(287, 275);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(387, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(487, 275);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(94, 29);
            btnManage.TabIndex = 4;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(87, 331);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(494, 188);
            dgvStudents.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(131, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(24, 20);
            txtId.TabIndex = 10;
            txtId.Text = "ID";
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Location = new Point(104, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(79, 20);
            txtLastName.TabIndex = 11;
            txtLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.AutoSize = true;
            txtFirstName.Location = new Point(103, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(80, 20);
            txtFirstName.TabIndex = 12;
            txtFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(120, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 20);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "Email";
            // 
            // Form1
            // 
            ClientSize = new Size(1021, 531);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtId);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvStudents);
            Controls.Add(btnManage);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
            // Form1
            // 
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnManage;
        private DataGridView dgvStudents;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label txtId;
        private Label txtLastName;
        private Label txtFirstName;
        private Label txtEmail;
    }
}
