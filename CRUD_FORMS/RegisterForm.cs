using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_FORMS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            // Set the password character to *
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Basic validation

            if (txtUsername.Text == "" ||

                txtPassword.Text == "" ||

                txtConfirmPassword.Text == "")

            {

                MessageBox.Show("Please fill all required fields");

                return;

            }



            if (txtPassword.Text != txtConfirmPassword.Text)

            {

                MessageBox.Show("Passwords do not match");

                return;

            }

            // Create hash + salt
            PasswordHelper.CreatePasswordHash(txtPassword.Text, out string passwordHash, out string salt);

            string connStr = "server=localhost;database=pracjoin;uid=root;pwd=;";
            string sql = @"INSERT INTO users(username, password_hash, salt, full_name, email) VALUES (@u, @ph, @s, @fn, @em)";
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connStr))

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@ph", passwordHash);
                    cmd.Parameters.AddWithValue("@s", salt);
                    cmd.Parameters.AddWithValue("@fn", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate username
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}