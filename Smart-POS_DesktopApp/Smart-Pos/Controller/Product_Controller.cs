using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Smart_Pos.Class;
using System.Web.Http;

namespace Smart_Pos.Controller
{
    class Product_Controller
    {
        public IEnumerable<Product> getProduct()
        {
            IEnumerable<Product> productList;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Products").Result;
            productList = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            return productList;
        }

        [HttpPost]
        public string addOrEditProduct(Product product)
        {
            if (product.ProdId == 0)
            {
                HttpResponseMessage request = GlobalHttp.WebApiClient.PostAsJsonAsync("Products", product).Result;
                return(product.ProdName + " Record  Added Succfully!!");
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Products/" + product.ProdId, product).Result;
                return( product.ProdName + " Record Updated Succfully!!");
            }

        }
        public Product get(int id = 0)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Products/" + id.ToString()).Result;
            Product prod = response.Content.ReadAsAsync<Product>().Result;
            return prod;
        }
        public string Delete(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Products/" + id.ToString()).Result;
            return ("Product Record Deleted Successfully!!");
        }
    }
}
