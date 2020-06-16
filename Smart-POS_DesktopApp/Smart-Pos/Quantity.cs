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
    public partial class Quantity : Form
    {
        Cart_Controller cc = new Cart_Controller();
        int total, prodId, quantity, imageId;
        public Quantity(int total, int prodId, int imageId)
        {
            InitializeComponent();
            this.total = total;
            this.prodId = prodId;
            //this.quantity = quantity;
            this.imageId = imageId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.quantity = Convert.ToInt32(textBox1.Text);
            cc.Add(total, prodId, quantity, imageId);
            MessageBox.Show("Item Added to cart");
            this.Close();
        }
    }
}
