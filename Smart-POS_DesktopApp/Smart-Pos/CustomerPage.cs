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
    public partial class CustomerPage : Form
    {
        Customer_Controller c = new Customer_Controller();
        public CustomerPage()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = c.getCust();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            AddCustomer a = new AddCustomer(y);
            a.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            if (MessageBox.Show("You sure to delete", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                c.Delete(y);
            }
        }
    }
}
