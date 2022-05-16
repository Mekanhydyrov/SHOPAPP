using Microsoft.AspNetCore.Mvc;
using System;

namespace SHOPAPP.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Mekan Hydyrov";
            return View();
        }
        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
