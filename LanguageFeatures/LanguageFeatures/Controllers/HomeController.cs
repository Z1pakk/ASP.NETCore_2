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
            //Розширяючий метод
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total:{cartTotal}" });
        }
    }
}