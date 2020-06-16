using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [Authorize]
        public ActionResult Index()
        {
            IEnumerable<mvcProductModel> productList;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Products").Result;
            productList = response.Content.ReadAsAsync<IEnumerable<mvcProductModel>>().Result;
            return View(productList);
        }

        [Authorize]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcProductModel());
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Products/" + id.ToString()).Result;
                mvcProductModel product = response.Content.ReadAsAsync<mvcProductModel>().Result;
                return View(product);
            }
            
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddOrEdit(mvcProductModel product)
        {
            if (product.ProdId == 0)
            {
                HttpResponseMessage request = GlobalHttp.WebApiClient.PostAsJsonAsync("Products", product).Result;
                TempData["SuccessMessage"] = product.ProdName + " Record  Added Succfully!!";
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Products/" + product.ProdId, product).Result;
                TempData["SuccessMessage"] = product.ProdName + " Record Updated Succfully!!";
            }
            
            return Redirect("Index");
        }


        [Authorize]
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Products/" + id.ToString()).Result;
           
            TempData["AlertMessage"] = "Product Record Deleted Successfully!!";
            return RedirectToAction("Index");
        }
    }
}