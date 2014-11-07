using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace KatanaWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Redirect(@"/Home/ImageGrabber");
            
            return View();
        }

        public ActionResult About()
        {
            Response.Redirect(@"/Home/ImageGrabber");

            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ImageGrabber()
        {
            var model = new KatanaWebAPI.Models.ImagesModel();
            var client = new HttpClient();
            var imageUrisJson = client.GetAsync("http://localhost:8080/api/images").Result.Content.ReadAsStringAsync().Result;
            var imageUris = JsonConvert.DeserializeObject<IEnumerable<string>>(imageUrisJson);
            
            model.Images.AddRange(imageUris);

            return View(model);
        }
    }
}