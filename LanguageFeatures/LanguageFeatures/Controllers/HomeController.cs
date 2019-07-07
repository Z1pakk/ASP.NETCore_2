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
            //Традиционно работа со значениями null требовала явных 
            //проверок, которые могли становиться
            //утомительными и подверженными ошибкам, когда требовалось
            //инспектировать и объект, и его свойства.За счет 
            //применения null - условной операции такие проверки
            //будут намного легче и компактнее
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                //Если значение р равно
                //null, то переменная name также будет установлена в 
                //null.Если значение р не равно null, тогда переменной 
                //name будет присвоено значение свойства Person.Name
                string name = p?.Name;
                decimal? price = p?.Price;
                string relatedName = p?.Related?.Name;
                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", 
                    name, price, relatedName));
            }
            return View(results);

            //return View(new string[] {"C#","Language","Features" });
        }
    }
}