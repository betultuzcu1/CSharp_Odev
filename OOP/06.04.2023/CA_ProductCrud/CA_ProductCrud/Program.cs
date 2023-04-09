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
            Category category1 = new Category { CategoryName = "Elektronik", Description = "Elektronik ürünler" };
            Category category2 = new Category { CategoryName = "Kitap", Description = "Kitaplar" };

            Product product1 = new Product { ProductName = "Laptop", UnitPrice = 5000, UnitsInStock = 10};
            Product product2 = new Product { ProductName = "Telefon", UnitPrice = 3000, UnitsInStock = 20, };
            Product product3 = new Product { ProductName = "Roman", UnitPrice = 50, UnitsInStock = 30};
            Product product4 = new Product { ProductName = "Bilim Kitabı", UnitPrice = 100, UnitsInStock = 40 };

            categories.Add(category1);
            categories.Add(category2);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            // Her bir ürün ve kategori için otomatik olarak artan Id'leri konsola yazdıralım
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
