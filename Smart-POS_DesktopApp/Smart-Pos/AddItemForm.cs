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
    public partial class AddItemForm : Form
    {
        Product p = new Product();
        Product_Controller pc = new Product_Controller();
        int id = 0;
        public AddItemForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public AddItemForm(int x)
        {
            InitializeComponent();
            this.id = x;
            Product prod = new Product(); 
                prod = pc.get(x);
            textBox1.Text = prod.ProdName;
            textBox4.Text = prod.ProdCatageory;
            textBox2.Text = prod.ProdQuantity.ToString();
            textBox3.Text = prod.ProductPrice.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            p.ProdId = this.id;
            p.ProdName = textBox1.Text;
            p.ProdCatageory = textBox4.Text;
            p.ProdQuantity = Convert.ToInt32(textBox2.Text);
            p.ProductPrice = Convert.ToInt32(textBox3.Text);
            p.ShopId = Convert.ToInt32(textBox5.Text);
            MessageBox.Show(pc.addOrEditProduct(p));
        }
    }
}
