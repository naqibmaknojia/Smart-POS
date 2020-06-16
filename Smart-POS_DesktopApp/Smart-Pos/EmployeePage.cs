using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Windows.Forms;
using Smart_Pos.Controller;
using Smart_Pos.Class;

namespace Smart_Pos
{
    public partial class EmployeePage : Form
    {
        Employee_Controller c = new Employee_Controller();
        public EmployeePage()
        {
            InitializeComponent();
            dataGridView1.DataSource = c.getEmp();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            AddEmployee a = new AddEmployee(y);
            a.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            if (MessageBox.Show("You sure to delete", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                c.deleteEmp(y);
            }
        }
    }
}
