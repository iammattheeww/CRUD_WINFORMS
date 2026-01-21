using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CRUD_FORMS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_customer_id = new Label();
            lbl_order_date = new Label();
            lbl_total = new Label();
            txt_order_id = new TextBox();
            txt_customer_id = new TextBox();
            txt_order_date = new TextBox();
            txt_total = new TextBox();
            add_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            clear_button = new Button();
            dgvOrder = new DataGridView();
            lbl_order_id = new Label();
            form4_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            //
            // lbl_customer_id
            //
            lbl_customer_id.AutoSize = true;
            //lbl_customer_id.Font = new Font("Segoe UI", 10F);
            lbl_customer_id.Location = new Point(29, 74);
            lbl_customer_id.Name = "lbl_customer_id";
            lbl_customer_id.Size = new Size(87, 19);
            lbl_customer_id.TabIndex = 1;
            lbl_customer_id.Text = "Customer ID";
            //
            // lbl_order_date
            //
            lbl_order_date.AutoSize = true;
            //lbl_order_date.Font = new Font("Segoe UI", 10F);
            lbl_order_date.Location = new Point(29, 111);
            lbl_order_date.Name = "lbl_order_date";
            lbl_order_date.Size = new Size(78, 19);
            lbl_order_date.TabIndex = 2;
            lbl_order_date.Text = "Order Date";
            //
            // lbl_total
            //
            lbl_total.AutoSize = true;
            //lbl_total.Font = new Font("Segoe UI", 10F);
            lbl_total.Location = new Point(29, 148);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(38, 19);
            lbl_total.TabIndex = 3;
            lbl_total.Text = "Total";
            //
            // txt_order_id
            //
            txt_order_id.Location = new Point(143, 36);
            txt_order_id.Name = "txt_order_id";
            txt_order_id.Size = new Size(145, 23);
            txt_order_id.TabIndex = 4;
            //
            // txt_customer_id
            //
            txt_customer_id.Location = new Point(143, 73);
            txt_customer_id.Name = "txt_customer_id";
            txt_customer_id.Size = new Size(145, 23);
            txt_customer_id.TabIndex = 5;
            //
            // txt_order_date
            //
            txt_order_date.Location = new Point(143, 110);
            txt_order_date.Name = "txt_order_date";
            txt_order_date.Size = new Size(145, 23);
            txt_order_date.TabIndex = 6;
            //
            // txt_total
            //
            txt_total.Location = new Point(143, 147);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(145, 23);
            txt_total.TabIndex = 7;
            //
            // add_button
            //
            add_button.Location = new Point(32, 204);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 8;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            //add_button.Click += add_button_Click;
            //
            // update_button
            //
            update_button.Location = new Point(120, 204);
            update_button.Name = "update_button";
            update_button.Size = new Size(75, 23);
            update_button.TabIndex = 9;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            //update_button.Click += update_button_Click;
            //
            // delete_button
            //
            delete_button.Location = new Point(208, 204);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 10;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            //
            // clear_button
            //
            clear_button.Location = new Point(296, 204);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 11;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            //clear_button.Click += clear_button_Click;
            //
            // dgvOrder
            //
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(29, 254);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.Size = new Size(545, 237);
            dgvOrder.TabIndex = 12;
            //
            // lbl_order_id
            //
            lbl_order_id.AutoSize = true;
            //lbl_order_id.Font = new Font("Segoe UI", 10F);
            lbl_order_id.Location = new Point(29, 37);
            lbl_order_id.Name = "lbl_order_id";
            lbl_order_id.Size = new Size(63, 19);
            lbl_order_id.TabIndex = 13;
            lbl_order_id.Text = "Order ID";
            //
            // form4_button
            //
            form4_button.Location = new Point(383, 204);
            form4_button.Name = "form4_button";
            form4_button.Size = new Size(75, 23);
            form4_button.TabIndex = 14;
            form4_button.Text = "Manage";
            form4_button.UseVisualStyleBackColor = true;
            //form4_button.Click += form4_button_Click;
            //
            // Form3
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(form4_button);
            Controls.Add(lbl_order_id);
            Controls.Add(dgvOrder);
            Controls.Add(clear_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(add_button);
            Controls.Add(txt_total);
            Controls.Add(txt_order_date);
            Controls.Add(txt_customer_id);
            Controls.Add(txt_order_id);
            Controls.Add(lbl_total);
            Controls.Add(lbl_order_date);
            Controls.Add(lbl_customer_id);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_customer_id;
        private Label lbl_order_date;
        private Label lbl_total;
        private TextBox txt_order_id;
        private TextBox txt_customer_id;
        private TextBox txt_order_date;
        private TextBox txt_total;
        private Button add_button;
        private Button update_button;
        private Button delete_button;
        private Button clear_button;
        private DataGridView dgvOrder;
        private Label lbl_order_id;
        private Button form4_button;
    }
}