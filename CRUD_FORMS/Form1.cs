using CRUD_FORMS;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_FORMS
{
    public partial class Form1 : Form
    {
        private readonly string connStr="Server=localhost;Database=school_db;User=root;Password=;";

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

            var da = new MySqlDataAdapter("SELECT Id, FirstName, LastName, Email FROM student", conn);

            var dt = new DataTable();
            da.Fill(dt);

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"INSERT INTO student (FirstName, LastName, Email) VALUES (@fn, @ln, @em)";

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

            string sql = @"UPDATE student SET FirstName=@fn, LastName=@ln, Email=@em WHERE Id=@id";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@em", txtEmail.Text);

            cmd.ExecuteNonQuery();

            LoadStudents();
            //ClearFields();
        }

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    ClearFields();
        //}

        private void ClearFields()
        {
            //txtId.Clear();
            //txtFirstName.Clear();
            //txtLastName.Clear();
            //txtEmail.Clear();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(connStr);
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}