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

            //Ürün oluşturma
            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();

            Category category1 = new Category("Electronics", "Electronic devices");
            Category category2 = new Category("Clothing", "Clothing items");

            Product product1 = new Product("Laptop", 1500,300);
            Product product2 = new Product("Smartphone", 1000,200);
             
            
            

            Supplier supplier1 = new Supplier("webdepo.com","Acar","05554443322");
            Supplier supplier2 = new Supplier("senkop.com.tr", "Mesut", "05551110088");

            
            categories.Add(category1);
            categories.Add(category2);

            products.Add(product1);
            products.Add(product2);

            suppliers.Add(supplier1);
            suppliers.Add(supplier2);

           

            //Ekleme

            Product product3=new Product ( "Roman", 50, 30 );
            Product product4 = new Product("Bilim Kitabı", 100, 40);  

            products.Add(product3);
            products.Add(product4);

            // Id'si 2 olan ürünü silmek için
            Product productToRemove = products.Find(p => p.Id == 2);
            products.Remove(productToRemove);


            //Listeleme
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            foreach (var supplier in suppliers)
            {
                Console.WriteLine(supplier);
            }


            Console.ReadLine();

        }
    }
}
