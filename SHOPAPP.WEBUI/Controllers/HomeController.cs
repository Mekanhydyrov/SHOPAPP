using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using SHOPAPP.DATA.Abstract;

namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {
        private IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository= productRepository;
        }
        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

         // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}