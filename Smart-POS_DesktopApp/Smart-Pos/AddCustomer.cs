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
    public partial class AddCustomer : Form
    {
        Customer cust = new Customer();
        Customer_Controller c = new Customer_Controller();
        int id = 0;
        
        public AddCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public AddCustomer(int x)
        {
            InitializeComponent();
            Customer customer = c.get(x);
            this.id = customer.CustId;
            textBox1.Text = customer.CustName;
            textBox2.Text = customer.CustEmail;
            textBox4.Text = customer.CustCategory;
            textBox5.Text = customer.ShopId.ToString();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            cust.CustId = this.id;
            cust.CustName =textBox1.Text;
            cust.CustEmail =textBox2.Text;
            cust.CustCategory =textBox4.Text;
            int shopid = 0;
            int.TryParse(textBox5.Text, out shopid);
            cust.ShopId = shopid;
            MessageBox.Show(c.addOrEditCust(cust));
            
        }
    }
}
