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
    public partial class AddVendor : Form
    {
        Vendor_Controller vc = new Vendor_Controller();
        Vendor vend = new Vendor();
        int id = 0;
        public AddVendor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public AddVendor(int x)
        {
            InitializeComponent();
            Vendor v = vc.get(x);
            textBox1.Text = v.VendorName;
            textBox2.Text = v.VendorEmail;
            this.id = v.VendorId;
            textBox4.Text = v.ShopId.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            vend.VendorId = this.id;
            vend.VendorName = textBox1.Text;
            vend.VendorEmail = textBox2.Text;
            int shopid = 0;
            int.TryParse(textBox4.Text,out shopid);
            vend.ShopId = shopid;
            string msg = vc.addOrEditVendor(vend);
            MessageBox.Show(msg);    
        }
    }
}
