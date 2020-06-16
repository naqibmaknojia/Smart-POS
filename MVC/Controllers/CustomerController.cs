using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Net.Http;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        [Authorize]
        public ActionResult Index()
        {
            IEnumerable<mvcCustomerModel> customerList;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Customers").Result;
            customerList = response.Content.ReadAsAsync<IEnumerable<mvcCustomerModel>>().Result;
            return View(customerList);
        }
        [Authorize]
        public ActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new mvcCustomerModel());
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Customers/" + id.ToString()).Result;
                mvcCustomerModel customer = response.Content.ReadAsAsync<mvcCustomerModel>().Result;
                return View(customer);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddOrEdit(mvcCustomerModel customer)
        {
            if (customer.CustId == 0)
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Customers", customer).Result;
                
                TempData["SuccessMessage"] = customer.CustName + " Record Added Successfully";
                
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Customers/" + customer.CustId, customer).Result;
                TempData["SuccessMessage"] = customer.CustName +" Record Updated Successfully";
               
                
            }
            return RedirectToAction("Index");
        }

        [Authorize]

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Customers/" + id.ToString()).Result;
            
            TempData["AlertMessage"] = "Customer Record Deleted Successfully";
           
            return RedirectToAction("Index");
        }
    }
}