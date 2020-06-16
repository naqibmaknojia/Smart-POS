using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pos.Class
{
    class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }
        public string ShopEmail { get; set; }
        public Nullable<int> ShopEmployee { get; set; }
        public string ShopCategory { get; set; }
        public string UserId { get; set; }
    }
}
