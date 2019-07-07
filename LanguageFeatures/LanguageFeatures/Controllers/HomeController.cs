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
            var products = new[]
            {
              new {Name="Kayak",Price=275M},
              new {Name="Lifejacket",Price=45.2M},
              new {Name="Soccer ball",Price=20.50M},
              new {Name="Corner flag",Price=45.95M}
          };
            //Вивід за допомогою Select. Но тут одна проблема, якщо ми змінимо
            //назву властивості то і строку, що показує юзеру інформацію,
            //також потрыбно змынювати.
            //return View(products.Select(р => $"Name: {р. Name} , Price: {р. Price} "));
            
            //Краще покласти цю роботу на компілятор за допомогою nameof()
            //Якщо ми поміняємо назву зміною то нам не треба буде змінювати строку.
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name} , {nameof(p.Price)}: {p.Price} "));
        }
    }
}