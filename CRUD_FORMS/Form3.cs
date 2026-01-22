using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_FORMS
{
    public partial class Form3 : Form
    {
        private readonly string connStr = "Server=localhost;Database=pracjoin;User=root;Password=;";
        //private readonly string __connStr;


        public Form3()
        {
            //__connStr = connStr;
            InitializeComponent();
            this.Load += Form3_Load;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }


        private void LoadCustomers()
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            //var da = new MySqlDataAdapter("SELECT Id, FirstName, LastName, Email FROM student", conn);

            //var dt = new DataTable();
            //da.Fill(dt);

            //dgvStudents.AutoGenerateColumns = true;
            //dgvStudents.DataSource = dt;

            var da = new MySqlDataAdapter("SELECT customer_id, name, email FROM customers", conn);

            var dt = new DataTable();
            da.Fill(dt);

            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = dt;

        }
        private void ClearFields()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"INSERT INTO customers (name, email) VALUES (@name, @email)";

            using var cmd = new MySqlCommand(sql, conn);

            //cmd.Parameters.AddWithValue("@customer_id", txtCustomerId.Text.Trim());
            cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtCustomerEmail.Text.Trim());

            cmd.ExecuteNonQuery();

            LoadCustomers();   // ✅ correct
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"UPDATE customers SET name=@customerName email=@customerEmail WHERE customer_id=@customerId";
            
            // string sql = @"UPDATE student SET FirstName=@fn, LastName=@ln, Email=@em WHERE Id=@id";


            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            cmd.Parameters.AddWithValue("@customerName", txtCustomerName.Text.Trim());
            cmd.Parameters.AddWithValue("@customerEmail", txtCustomerEmail.Text.Trim());

            cmd.ExecuteNonQuery();

            LoadCustomers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"DELETE FROM customers WHERE customer_id=@customerId;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

            cmd.ExecuteNonQuery();

            LoadCustomers();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(connStr);
            form4.ShowDialog();
        }

        /* 
         private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"INSERT INTO student (FirstName, LastName, Email) VALUES (@fn, @ln, @em)";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());

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
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DELETE FROM table_name WHERE condition;
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = @"DELETE FROM student WHERE Id=@id;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();

            LoadStudents();
            ClearFields();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(connStr);
            form2.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }
    }
         */
    }
}
