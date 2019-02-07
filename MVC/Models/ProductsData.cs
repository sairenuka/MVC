using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    class ProductsData
    {
        public IEnumerable<Product> ProductsList
        {
            get {
                List<Product> products = new List<Product>() {
                new Product {ProductId = 1,Name = "oneplus 6T",Price = 40000.00 },

                 new Product {ProductId = 2,Name = "mi max",Price = 15000.00 }


                };
                return products;
            }
        }
    }
}
