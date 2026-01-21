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
    public partial class Form2 : Form
    {
        private readonly string _connStr;
        public Form2(string connStr)
        {
            _connStr = connStr;
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }


        private void LoadStudents()
        {
            using var conn = new MySqlConnection(_connStr);
            conn.Open();

            var da = new MySqlDataAdapter("SELECT Id, FirstName, LastName, Email FROM student", conn);

            var dt = new DataTable();
            da.Fill(dt);

            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = dt;
        }
        //private void btnManage_Click(object sender, EventArgs e)
        //{
        //    Form3 form3 = new Form3(_connStr);
        //    form3.ShowDialog();
        //}
    }
}
