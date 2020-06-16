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
    public partial class Listitem : UserControl
    {
        public Listitem()
        {
            InitializeComponent();
        }

        private int _itemId;
        private int _ImageId;
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

        public Image img
        {
            get { return _img; }
            set { _img = value; pictureBox1.Image = value; }
        }

        public string itemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; label4.Text = value; }
        }

        public int imageId
        {
            get { return _ImageId; }
            set { _ImageId = value; }
        }
         public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Addbtn.Text = "Added";
            Quantity q = new Quantity(Convert.ToInt32(itemQuantity), itemId, imageId);
            q.Show();
            Addbtn.BackColor = Color.SpringGreen;     
        }
    }
}
