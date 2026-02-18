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
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin(this);

            // Subscribe to FrmLogin event
            loginForm.LoginSuccess += (username) =>
            {
                // Raise Dash's event
                LoginSucceeded?.Invoke(username);
            };
            loginForm.ShowDialog();
        }
    }
}
