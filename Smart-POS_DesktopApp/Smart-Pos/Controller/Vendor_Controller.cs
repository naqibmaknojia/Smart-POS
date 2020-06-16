using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Pos.Class;
using System.Web.Http;
using System.Net.Http;

namespace Smart_Pos.Controller
{
    class Vendor_Controller
    {
        // GET: Vendor
        public IEnumerable<Vendor> getVendors()
        {
            IEnumerable<Vendor> vendors;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Vendors").Result;
            vendors = response.Content.ReadAsAsync<IEnumerable<Vendor>>().Result;
            return vendors;
        }

        [HttpPost]
        public string addOrEditVendor(Vendor vendor)
        {
            if (vendor.VendorId == 0)
            {
                //HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Vendors", vendor).Result;
                //response.EnsureSuccessStatusCode();
                //return ("Vendor Record Added Successfully");
                HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Vendors", vendor).Result;
                response.EnsureSuccessStatusCode();
                return (vendor.VendorName + " Record Added Successfully");
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Vendors/" + vendor.VendorId, vendor).Result;
                return ("Vendor Record Updated Successfully");
            }
        }

        public Vendor get(int id = 0)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Vendors/" + id.ToString()).Result;
            Vendor vend = response.Content.ReadAsAsync<Vendor>().Result;
            return vend;
        }

        public string deleteVendor(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Vendors/" + id.ToString()).Result;
            return ("Vendor Record Deleted Successfully");
        }
    }
}
