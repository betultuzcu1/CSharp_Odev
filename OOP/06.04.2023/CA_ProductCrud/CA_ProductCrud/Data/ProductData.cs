using CA_ProductCrud.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Data
{
    internal class ProductData
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { ProductName = "Laptop", UnitPrice = 5000, UnitsInStock = 10},
            new Product { ProductName = "Telefon", UnitPrice = 3000, UnitsInStock = 20, },
            new Product { ProductName = "Roman", UnitPrice = 50, UnitsInStock = 30 },
            new Product { ProductName = "Bilim Kitabı", UnitPrice = 100, UnitsInStock = 40 }
        };

    }
}
