using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Pos.Class;
using System.Net.Http;
using Smart_Pos.Controller;

namespace Smart_Pos.Controller
{
    class Cart_Controller
    {
        public IEnumerable<Cart> index()
        {
            IEnumerable<Cart> carts;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Carts").Result;
            carts = response.Content.ReadAsAsync<IEnumerable<Cart>>().Result;

            return carts;
        }

        public string Add(int total, int prodId, int quantity, int imageId)
        {
            HttpResponseMessage prodresponse = GlobalHttp.WebApiClient.GetAsync("Products/" + prodId.ToString()).Result;
            Product product = prodresponse.Content.ReadAsAsync<Product>().Result;

            Cart cart = new Cart();
            cart.CartDetailId = 1;
            cart.CartQuantity = quantity;
            cart.CartTotal = total;
            cart.ProductID = prodId;
            cart.ImageId = imageId;
            cart.ProductName = product.ProdName;
            HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Carts", cart).Result;

            return "Item Added in cart";
        }

        public string Delete(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Carts/" + id.ToString()).Result;
            return "Item Deleted from the cart";
        }
    }
}
