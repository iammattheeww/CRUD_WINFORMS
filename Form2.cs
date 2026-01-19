using System;
using System.Windows.Forms;

namespace CRUD_FORMS
{
    public partial class Form2 : Form
    {
        private readonly string connStr;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string connStr) : this()
        {
            this.connStr = connStr ?? throw new ArgumentNullException(nameof(connStr));
        }

        public string ConnectionString => connStr;

        private void InitializeComponent()
        {
            this.Text = "Form2";
            this.ClientSize = new System.Drawing.Size(600, 400);
        }
    }
}