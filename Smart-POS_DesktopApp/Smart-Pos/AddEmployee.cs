using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_Pos.Controller;
using Smart_Pos.Class;

namespace Smart_Pos
{
    public partial class AddEmployee : Form
    {
        Employee_Controller c = new Employee_Controller();
        int id = 0;
        public AddEmployee(int x)
        {
            InitializeComponent();
            Employee emp = c.get(x);
            textBox1.Text = emp.EmpName;
            textBox2.Text = emp.EmpEmail;
            textBox4.Text = emp.EmpUsername;
            this.id = emp.EmpId;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpEmail = textBox2.Text;
            emp.EmpUsername =textBox4.Text;
            emp.EmpName =textBox1.Text;
            emp.EmpId = id;
            string msg= c.addOrEditEmp(emp);
            MessageBox.Show(msg);
            
        }
    }
}
