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
            new Product {Name = "Soccer ball" , Price = 19.4M}
            };
            decimal priceFilterTotal = productArray.Filter(p=>((p?.Price ?? 0)>=20)).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p=>(p?.Name?[0]=='S')).TotalPrices();
            return View("Index", new string[] {
                $"Price total:{priceFilterTotal:C2}",
                $"Name total:{nameFilterTotal:C2}"});
        }
    }
}