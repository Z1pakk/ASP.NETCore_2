using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        //Розширяючий метод появляється тільки 
        //якщо в першим параметром в методі буде клас до якого посилається метод
        //із приставкой - "this"
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
