using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_FORMS
{
    public partial class FrmLogin : Form
    {
        private Form parentForm;

        // Event to notify parent form of successful login
        public event Action<string> LoginSuccess;

        public FrmLogin(Form parent)
        {
            InitializeComponent();

            parentForm = parent; // store the parent form reference

            // Set the password character to *
            txtPassword.PasswordChar = '*';
        }

        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                MessageBox.Show("Please enter username and password",

                                "Login",

                                MessageBoxButtons.OK,

                                MessageBoxIcon.Warning);

                return;

            }



            string connStr = "server=localhost;database=pracjoin;uid=root;pwd=;";

            string sql = @"SELECT password_hash, salt

                           FROM users

                           WHERE username = @username

                           AND is_active = 1";



            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbHash = reader.GetString("password_hash");

                        string dbSalt = reader.GetString("salt");

                        if (PasswordHelper.VerifyPassword(password, dbHash, dbSalt))

                        {

                            // Notify parent form about successful login
                            LoginSuccess?.Invoke(username);

                            // Hide login form
                            this.Hide();
                            parentForm?.Hide();

                            // Optional: you can remove direct maindash opening
                            // The parent form (Dash) or ApplicationContext will                  
                            //open maindash; 
                        }

                        else

                        {

                            ShowLoginError();

                        }

                    }

                    else

                    {

                        ShowLoginError();

                    }

                }

            }
        }



        // Helper method for invalid login

        private void ShowLoginError()
        {

            MessageBox.Show("Invalid username or password",

                            "Error",

                            MessageBoxButtons.OK,

                            MessageBoxIcon.Error);
            txtPassword.Clear();

            txtPassword.Focus();

        }

        // CANCEL
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
