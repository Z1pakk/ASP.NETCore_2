using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };
            Product[] productArray = {
            new Product {Name = "Kayak" , Price = 275M},
            new Product {Name = "Lifejacket" , Price = 48.95M},
            new Product {Name = "Kayak" , Price = 10.7M},
            new Product {Name = "Lifejacket" , Price = 19.4M}
            };
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            return View("Index", new string[] {
                $"Products total:{arrayTotal}" });
        }
    }
}