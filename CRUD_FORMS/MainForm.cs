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
    public partial class MainForm : Form
    {
        public event Action<string> LoginSucceeded;

        public MainForm()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);

            // This "subscribes" the Dash to the Login window's success
            loginForm.LoginSuccess += (username) =>
            {
                this.LoginSucceeded?.Invoke(username); // Pass the message to Program.cs
            };

            loginForm.ShowDialog();
        }
    }
}
