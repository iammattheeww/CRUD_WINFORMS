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
        private readonly string __connStr;


        public Form3()
        {
            __connStr = connStr;
            InitializeComponent();
            this.Load += Form3_Load;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }


        private void LoadOrders()
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            //var da = new MySqlDataAdapter("SELECT Id, FirstName, LastName, Email FROM student", conn);

            //var dt = new DataTable();
            //da.Fill(dt);

            //dgvStudents.AutoGenerateColumns = true;
            //dgvStudents.DataSource = dt;

            var da = new MySqlDataAdapter("SELECT order_id, customer_id, order_date, total FROM orders", conn);
            
            var dt = new DataTable();
            da.Fill(dt);

            dgvOrder.AutoGenerateColumns = true;
            dgvOrder.DataSource = dt;

        }

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
