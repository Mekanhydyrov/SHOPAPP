using Microsoft.AspNetCore.Mvc;
using SHOPAPP.WEBUI.Controllers;
using System.Collections.Generic;

namespace SHOPAPP.WEBUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
               new Category { Name = "Telefon", Description = "Telefon Kategorisi" },
               new Category { Name="Bilgisayar", Description="Bilgisayar Kategorisi" },
               new Category { Name="Elektronik", Description="Elektronik Kategorisi" },
            };
            return View(categories);
        }
    }
}
