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
        }
    }
}
