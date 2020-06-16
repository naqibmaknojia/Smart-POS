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
    public partial class VendorPage : Form
    {
        Vendor_Controller c = new Vendor_Controller();
        public VendorPage()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = c.getVendors();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddVendor a = new AddVendor();
            a.ShowDialog();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            AddVendor a = new AddVendor(y);
            a.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            int y = Convert.ToInt32(x);
            if (MessageBox.Show("You sure to delete", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                c.deleteVendor(y);
            }
        }
    }
}
