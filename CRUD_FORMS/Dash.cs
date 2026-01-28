using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_FORMS
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.ShowDialog();
        }
    }
}
