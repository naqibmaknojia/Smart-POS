using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Pos.Class;
using System.Net.Http;
using System.Web.Http;

namespace Smart_Pos.Controller
{
    class Customer_Controller
    {
        public IEnumerable<Customer> getCust()
        {
            IEnumerable<Customer> customerList;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Customers").Result;
            customerList = response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
            return customerList;
        }

        [HttpPost]
        public string addOrEditCust(Customer customer)
        {
            if (customer.CustId == 0)
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Customers", customer).Result;
                return (customer.CustName + " Record Added Successfully");
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Customers/" + customer.CustId, customer).Result;
                return(customer.CustName + " Record Updated Successfully");
            }
        }

        public Customer get(int id = 0)
        {
                HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Customers/" + id.ToString()).Result;
                Customer customer = response.Content.ReadAsAsync<Customer>().Result;
                return customer;
        }
        public string Delete(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Customers/" + id.ToString()).Result;
            return ("Customer Record Deleted Successfully");
        }
    }
}
