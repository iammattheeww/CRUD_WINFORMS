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
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            ID = new Label();
            LastName = new Label();
            FirstName = new Label();
            Email = new Label();
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
            btnDelete.Click += btnDelete_Click;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(487, 275);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(94, 29);
            btnManage.TabIndex = 4;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
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
            // txtId
            // 
            txtId.Location = new Point(211, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(211, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 7;
            txtFirstName.TextChanged += textBox2_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(211, 161);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 8;
            txtLastName.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(131, 50);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 10;
            ID.Text = "ID";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(104, 164);
            LastName.Name = "LastName";
            LastName.Size = new Size(79, 20);
            LastName.TabIndex = 11;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(103, 108);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 12;
            FirstName.Text = "First Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(120, 220);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 13;
            Email.Text = "Email";
            // 
            // Form1
            // 
            ClientSize = new Size(1021, 531);
            Controls.Add(Email);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(ID);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
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
        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Label ID;
        private Label LastName;
        private Label FirstName;
        private Label Email;
    }
}
