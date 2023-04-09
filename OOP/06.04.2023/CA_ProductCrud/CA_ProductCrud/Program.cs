using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CA_ProductCrud.Classes;
using CA_ProductCrud.Data;

namespace CA_ProductCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            categories.Add(category1);
            categories.Add(category2);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            
            foreach (var category in categories)
            {
                Console.WriteLine("Category Id: " + category.Id);
            }

            foreach (var product in products)
            {
                Console.WriteLine("Product Id: " + product.Id);
            }


        }
    }
}
