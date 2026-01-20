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
        private readonly string __connStr;
        public Form3(string connStr)
        {
            __connStr = connStr;
            InitializeComponent();
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }


        private void LoadStudents()
        {
            using var conn = new MySqlConnection(__connStr);
            conn.Open();

            var da = new MySqlDataAdapter("SELECT Id, FirstName, LastName, Email FROM student", conn);

            var dt = new DataTable();
            da.Fill(dt);

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = dt;
        }
    }
}
