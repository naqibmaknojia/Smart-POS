using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Smart_Pos.Class;

namespace Smart_Pos.Controller
{
    class Image_Controller
    {
        public string ImagePath(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Images/" + id.ToString()).Result;
            Image image = response.Content.ReadAsAsync<Image>().Result;
            return image.ImagePath;
            
        }
    }
}
