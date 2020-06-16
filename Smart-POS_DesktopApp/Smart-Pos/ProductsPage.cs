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
using System.Collections.ObjectModel;

namespace Smart_Pos
{
    

    public partial class ProductsPage : Form
    {
        IEnumerable<Product> productlist;
        Product_Controller pc = new Product_Controller();
        Image_Controller ic = new Image_Controller();
        public ProductsPage()
        { 
            InitializeComponent();
            productlist = pc.getProduct();
            foreach (var product in productlist)
            {
                Listitem item = new Listitem();
                item.itemName = product.ProdName;
                item.itemPrice = product.ProductPrice.ToString();
                item.itemQuantity = product.ProdQuantity.ToString();
                item.imageId = product.ImageId;
                item.itemId = product.ProdId;
                if (product.ImageId != 0)
                {
                    string path = ic.ImagePath(product.ImageId);
                    string newpath = path.Substring(1);
                    item.img = System.Drawing.Image.FromFile(newpath);
                }
                flowLayoutPanel1.Controls.Add(item);
            }

            flowLayoutPanel1.AutoScroll = true;
        }
 
    }
}
