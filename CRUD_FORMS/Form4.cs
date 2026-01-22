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
    public partial class Form4 : Form
    {
        private readonly string _connStr;


        public Form4(string connStr)
        {
            _connStr = connStr;
            InitializeComponent();
            this.Load += Form4_Load;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }


        private void LoadCustomers()
        {
            using var conn = new MySqlConnection(_connStr);
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
    }
}
