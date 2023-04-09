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
            new Product
            {
                ProductName="Chai",
                UnitPrice=15,
                UnitsInStock=200
            },
            new Product
            {
                ProductName="Chang",
                UnitPrice=18,
                UnitsInStock=250
            }

        };
    }
}
