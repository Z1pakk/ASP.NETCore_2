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
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        //Розширяючий метод із фільтрацією
        public static IEnumerable<Product> FilterByPrice(
            this IEnumerable<Product> productEnum,
            decimal minimalPrice)
        {
            foreach (Product product in productEnum)
            {
                if((product?.Price??0)>= minimalPrice)
                {
                    //yield - створює свій ліст у який добавляє 
                    //кожний елемент який вернули
                    //В кінці верне ліст із елементами.
                    yield return product;
                }
            }
        }
    }
}
