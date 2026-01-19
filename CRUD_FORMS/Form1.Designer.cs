namespace CRUD_FORMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /* 
         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         */


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvStudents = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtId = new Label();
            txtLastName = new Label();
            txtFirstName = new Label();
            txtEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(87, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 275);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 275);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(387, 275);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(487, 275);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Manage";
            button5.UseVisualStyleBackColor = true;
            // button5.Click += this.button5_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(87, 331);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(494, 188);
            dgvStudents.TabIndex = 5;
            // dgvStudents.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(131, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(24, 20);
            txtId.TabIndex = 10;
            txtId.Text = "ID";
            txtId.Click += label1_Click;
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Location = new Point(104, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(79, 20);
            txtLastName.TabIndex = 11;
            txtLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.AutoSize = true;
            txtFirstName.Location = new Point(103, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(80, 20);
            txtFirstName.TabIndex = 12;
            txtFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(120, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 20);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "Email";
            // 
            // Form1
            // 
            ClientSize = new Size(1021, 531);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtId);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvStudents);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
            // Form1
            // 
            /* 
             AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 558);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
             */
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvStudents;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label txtId;
        private Label txtLastName;
        private Label txtFirstName;
        private Label txtEmail;

        #endregion

        //private DataGridView dataGridView1;
        //private Label label1;
        //private Button button1;
        //private Button button2;
        //private Button button3;
        //private Button button4;
        //private Button button5;
        //private TextBox textBox1;
        //private Label label2;
        //private Label label3;
        //private Label label4;
        //private TextBox textBox2;
        //private TextBox textBox3;
        //private TextBox textBox4;
        // private Button button6;
    }
}
