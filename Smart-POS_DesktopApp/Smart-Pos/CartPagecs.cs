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
    public partial class CartPagecs : Form
    {
        IEnumerable<Cart> productlist;
        Cart_Controller cc = new Cart_Controller();
        Image_Controller ic = new Image_Controller();
        Product_Controller pc = new Product_Controller();
        public CartPagecs()
        {
            InitializeComponent();
            productlist = cc.index();
            foreach (var product in productlist)
            {
                Product curr = pc.get(product.ProductID);
                CartItem item = new CartItem();
                item.itemName = product.ProductName;
                item.itemPrice = curr.ProductPrice.ToString();
                item.itemQuantity = curr.ProdQuantity.ToString();
                if(product.ImageId != 0) {
                    string path = ic.ImagePath(curr.ImageId);
                    string newpath = path.Substring(1);
                    item.img = System.Drawing.Image.FromFile(newpath);
                }
                
                flowLayoutPanel1.Controls.Add(item);
            }

            flowLayoutPanel1.AutoScroll = true;
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Checkout successfully", "Success");
        }
    }
}
