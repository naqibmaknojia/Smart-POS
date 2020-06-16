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
    public partial class InventoryPage : Form
    {
        Product p = new Product();
        Product_Controller pc = new Product_Controller();
        
        public InventoryPage()
        {
            InitializeComponent();
            dataGridView1.DataSource = pc.getProduct();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            if (MessageBox.Show("You sure to delete", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pc.Delete(y);
            }
        }

       
        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddItemForm a = new AddItemForm();
            a.ShowDialog();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            AddItemForm a = new AddItemForm(y);
            a.ShowDialog();
        }
    }
}
