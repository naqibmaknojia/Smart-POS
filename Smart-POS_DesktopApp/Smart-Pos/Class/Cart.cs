using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pos.Class
{
    class Cart
    {

        public int CartId { get; set; }
        public int CartDetailId { get; set; }
        public Nullable<int> CartQuantity { get; set; }
        public Nullable<int> CartTotal { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ImageId { get; set; }
    }
}
