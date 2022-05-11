using Microsoft.AspNetCore.Mvc;

namespace SHOPAPP.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home/index";
        }
    }
}
