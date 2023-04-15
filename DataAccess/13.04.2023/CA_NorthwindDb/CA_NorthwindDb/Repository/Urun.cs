using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;
using CA_NorthwindDb.Crud;

namespace CA_NorthwindDb.Repository
{
    internal class Urun
    {
        ProductCrud productCrud = new ProductCrud();
       
        public void UrunIslmeleri()
        {
            Console.WriteLine("Lütfen bir alt kategori seçiniz!");
            Console.ReadLine();
            Console.WriteLine("1.Ürün Listeleme\n2.Ürün Ekleme\n3.Ürün Güncelleme\n4.Ürün Silme");
            Console.Write("Kategori Seçimi: ");
            string secim1 = Console.ReadLine();
            switch (secim1)
            {
                case "1":
                    //Listeleme
                    foreach (Product product in productCrud.GetProducts())
                    {
                        string format = $"{product.ProductID} {product.ProductName} {product.UnitPrice} {product.UnitsInStock} ";
                        Console.WriteLine(format);
                    }
                    break;
                case "2":
                    //ekleme
                    Product product2 = new Product();
                    string sonuc = productCrud.AddPrdouct(product2);
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;
                case "3":
                    //Güncelleme
                    Product updateProduct = new Product();
                    Console.Write("Lütfen güncellemek istediğiniz ürün ID'sini giriniz:");
                    updateProduct.ProductID = int.Parse(Console.ReadLine());
                    Console.Write("Lütfen ürün adını giriniz:");
                    updateProduct.ProductName = Console.ReadLine();
                    Console.Write("Lütfen stok miktarını giriniz:");
                    updateProduct.UnitsInStock = short.Parse(Console.ReadLine());
                    Console.Write("Lütfen ürün fiyatını giriniz:");
                    updateProduct.UnitPrice = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"{updateProduct.ProductID} ID'li ürünü güncellemek istediğinizden emin misiiz?(e/h)");
                    string gülcellemeSecim= Console.ReadLine();
                    if (gülcellemeSecim == "e")
                    {
                        string sonuc1 = productCrud.UpdateProduct(updateProduct);
                        Console.WriteLine(sonuc1);
                    }
                    else
                    {
                        return;
                    }
                    break;
                case "4":
                    //silme
                    Console.Write("Silmek istediğiniz ürün ID'sini giriniz:");
                    int productId = int.Parse(Console.ReadLine());                    
                    Console.WriteLine($"{productId} ID'li ürünü silmek istediğinizden emin misiiz?(e/h)");
                    string silmeSecim=Console.ReadLine();
                    if(silmeSecim == "e")
                    {
                        string sonuc3 = productCrud.DeleteProduct(productId);
                        Console.WriteLine(sonuc3);
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Lütfen geçrli bir seçim yapınız!");
                    break;
            }
        }
    }
}
