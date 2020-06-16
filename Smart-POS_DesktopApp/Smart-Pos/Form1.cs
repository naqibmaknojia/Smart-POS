using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void leftExpand_Click(object sender, EventArgs e)
        {
            if (MenuVerticle.Width == 220)
            {
                MenuVerticle.Width = 47;
            }
            else MenuVerticle.Width = 220;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addform(object FormToShow)
        {
            if(this.container.Controls.Count > 0)
            {
                this.container.Controls.RemoveAt(0);
            }
            Form fh = FormToShow as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.container.Controls.Add(fh);
            this.container.Tag = fh;
            fh.Show();
        }
        private void Productsbtn_Click(object sender, EventArgs e)
        {
            Addform(new ProductsPage());
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            Addform(new InventoryPage());
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            Addform(new EmployeePage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addform(new VendorPage());
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            Addform(new CustomerPage());
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            Addform(new CartPagecs());
        }
    }
}
