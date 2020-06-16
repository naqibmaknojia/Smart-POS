using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pos.Class
{
    class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorEmail { get; set; }
        public Nullable<int> ShopId { get; set; }
    }
}
