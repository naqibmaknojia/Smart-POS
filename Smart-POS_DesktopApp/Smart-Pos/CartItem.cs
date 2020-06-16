using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Pos
{
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        private string _itemName;
        private string _itemPrice;
        private string _itemQuantity;
        private Image _img;

        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; label1.Text = value; }
        }
        public string itemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; label3.Text = value; }
        }

        
        public string itemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; label2.Text = value; }
        }

        public Image img
        {
            get { return _img; }
            set { _img = value; pictureBox1.Image = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure to delete", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //pc.Delete(y);
            }
        }

    }
}
