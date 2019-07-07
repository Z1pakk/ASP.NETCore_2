using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
            Product kozak = new Product
            {
                Name = "Kozak",
                Price = 200M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 50.98M
            };
            return new Product[] { kozak, lifejacket, null };
        }
    }
}
