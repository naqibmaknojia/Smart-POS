using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pos.Class
{
    class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProductPrice { get; set; }
        public string ProdCatageory { get; set; }
        public Nullable<int> ProdQuantity { get; set; }
        public Nullable<System.DateTime> ProdDate { get; set; }
        public Nullable<int> ShopId { get; set; }
        public int ImageId { get; set; }
    }
}
