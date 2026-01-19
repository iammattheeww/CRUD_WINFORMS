using CRUD_FORMS;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentSched
{
    public partial class Form1 : Form
    {
        private readonly string connStr =
            "Server=localhost;Database=school_db;User=root;Password=;";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            LoadStudents();
        }


        private void LoadStudents()
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            var da = new MySqlDataAdapter(
                "SELECT Id, FirstName, LastName, Email FROM Student", conn);

            var dt = new DataTable();
            da.Fill(dt);

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"INSERT INTO Student (FirstName, LastName, Email)
                           VALUES (@fn, @ln, @em)";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@em", txtEmail.Text);

            cmd.ExecuteNonQuery();

            LoadStudents();   // ✅ correct
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"UPDATE Student
                           SET FirstName=@fn, LastName=@ln, Email=@em
                           WHERE Id=@id";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@em", txtEmail.Text);

            cmd.ExecuteNonQuery();

            LoadStudents();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(connStr);
            form2.ShowDialog();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 246);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(179, 246);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(291, 246);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(403, 246);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(515, 246);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Manage";
            button5.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(66, 296);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(542, 188);
            dgvStudents.TabIndex = 5;
            dgvStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 31);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 86);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 140);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 197);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(197, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(197, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(197, 137);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 13;
            // 
            // Form1
            // 
            ClientSize = new Size(1045, 555);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
    }
}