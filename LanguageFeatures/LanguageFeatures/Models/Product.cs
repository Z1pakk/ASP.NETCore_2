using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        //Тільки в конструкторі можна переопреділити читаєму властивість.
        public Product(bool stock=true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        //У властивість по стандарту буде значення - "Watersports"
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        //Властивість тільки для повернення значень.
        public bool InStock { get; } = true;
        public bool NameBeginsWithS => this.Name?[0] == 'S';


        public static Product[] GetProducts()
        {
            Product kozak = new Product
            {
                Name = "Kozak",
                Category="Water kozak",
                Price = 200M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 50.98M
            };
            kozak.Related = lifejacket;
            return new Product[] { kozak, lifejacket, null };
        }
    }
}
