using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_Pos.Class;
using Smart_Pos.Controller;

namespace Smart_Pos
{
    public partial class LoginPage : Form
    {
        Employee emp = new Employee();
        Employee_Controller ec = new Employee_Controller();
        public LoginPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider1.SetError(this.textBox3,"Field is required");
            }
            else
            {
                errorProvider1.Clear();
            }   
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Focus();
                errorProvider1.SetError(this.textBox4, "Field is required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Focus();
                errorProvider1.SetError(this.textBox5, "Field is required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider1.SetError(this.textBox6, "Field is required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != textBox7.Text)
            {
                //textBox7.Focus();
                errorProvider1.SetError(this.textBox7, "Password should match");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp.EmpEmail = textBox4.Text;
            emp.EmpName = textBox3.Text;
            emp.ShopId = Convert.ToInt32(textBox5.Text);
            emp.EmpPassword = textBox6.Text;
            emp.EmpUsername = textBox3.Text;
            MessageBox.Show(ec.addOrEditEmp(emp));
        }
    }
}
