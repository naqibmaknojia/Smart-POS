using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pos.Class
{
    class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustCategory { get; set; }
        public Nullable<int> ShopId { get; set; }
    }
}
