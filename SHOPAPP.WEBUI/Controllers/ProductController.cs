using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            var product = new Product {Name="Iphone X",Price=6000,Description="güzel telefon"};

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
        // product/list => tüm ürünleri (sayfalama)
        // product/list/2 => 2 numaralı kategoriye ait ürünler
        public IActionResult list(int? id, string q) 
        {
            var products = ProductRepository.Products;
            //Category
            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }
            //Search
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
        //Add Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(p);
        }
        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("List");
        }
        //Delete
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("List");
        }
    }
}