using Microsoft.AspNetCore.Mvc;
using SHOPAPP.WEBUI.Models;
using SHOPAPP.WEBUI.ViewModels;
using System.Collections.Generic;

namespace SHOPAPP.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product{Name="Iphone 8", price=3000, Description="İyi Telefon"},
                new Product { Name = "Iphone x", price = 12.000, Description = "Çok İyi Telefon" },
                new Product { Name = "Iphone 12 Min", price = 10.000, Description = "Mini Telefon" },
                new Product { Name = "Iphone 13 Pro", price = 19.000, Description = "Mükemmel Telefon" }
            };
        
            var productViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(productViewModel);
        }
        public IActionResult Details(int id)
        {
            var p = new Product();
            p.Name = "Samsun S6";
            p.price = 6000;
            p.Description = "İyi Telefon";
            return View(p);
        }
    }
}
