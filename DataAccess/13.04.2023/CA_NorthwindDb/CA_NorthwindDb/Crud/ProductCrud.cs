using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Crud
{
    internal class ProductCrud
    {
        NORTHWNDEntities db=new NORTHWNDEntities();
        //Listeleme
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        //Ekleme
        public string AddPrdouct(Product product)
        {
            try
            {
                Product product1 = new Product();
                Console.Write("Lütfen ürün adını giriniz:");
                product1.ProductName = Console.ReadLine();
                Console.Write("Lütfen stok miktarını giriniz:");
                product1.UnitsInStock = short.Parse(Console.ReadLine());
                Console.Write("Lütfen fiyat giriniz:");
                product1.UnitPrice = decimal.Parse(Console.ReadLine());

                db.Products.Add(product1);

                if (db.SaveChanges() > 0)
                {
                    return "Ürün başarı ile eklendi!";
                }
                else
                {
                    return "Ekleme işlemi başarısız!";
                }
            }
            catch(Exception ex)
            {
                return $"{ex}.Message";
            }            
        }

        //güncelleme

        public string UpdateProduct(Product product) 
        {
            try
            {
                Product updateProduct = db.Products.Find(product.ProductID);
                updateProduct.ProductName = product.ProductName;
                updateProduct.UnitPrice = product.UnitPrice;
                updateProduct.UnitsInStock = product.UnitsInStock;

                if (db.SaveChanges() > 0)
                {
                    return "Ürün başarı ile güncellendi!";
                }
                else
                {
                    return "Güncelleme işlemi başarısız!";
                }
            }
            catch(Exception ex)
            {
                return $"{ex}.Message";
            }
        }

        //silme 

        public string DeleteProduct(int id)
        {
            try
            {
                var value = db.Products.Find(id);
                db.Products.Remove(value);
                
                 if (db.SaveChanges() > 0)
                 {
                    return "Ürün başarı ile silindi!";
                 }
                 else
                 {
                   return "Silme işlemi başarısız!";
                 }               
            }
            catch(Exception ex)
            {
                return $"{ex}.Message";
            }          
        }
    }
}
