using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_FORMS
{
    public partial class maindash : Form
    {
        private string loggedInUser; // Store the logged-in username

        public maindash(string username)
        {
            InitializeComponent();
            loggedInUser = username; 
        }
    }
}
