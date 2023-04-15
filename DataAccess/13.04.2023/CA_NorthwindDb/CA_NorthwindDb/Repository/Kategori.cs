using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Crud;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Repository
{
    internal class Kategori
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        CategoryCrud categoryCrud = new CategoryCrud();
        public void KategorıIslemlerı()
        {
            Console.WriteLine("Lütfen bir alt kategori seçiniz!");
            Console.ReadLine();
            Console.WriteLine("1.Kategori Listeleme\n2.Kategori Ekleme\n3.Kategori Güncelleme\n4.Kategori Silme");
            Console.Write("Kategori Seçimi: ");
            string secim2 = Console.ReadLine();
            switch (secim2)
            {
                case "1":
                    //Listeleme
                    foreach (Category category in categoryCrud.GetCategories())
                    {
                        string format = $"{category.CategoryID} {category.CategoryName} {category.Description} ";
                        Console.WriteLine(format);
                    }
                    break;
                case "2":
                    //ekleme
                    Category category2 = new Category();
                    string sonuc = categoryCrud.AddCategory(category2);
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;
                case "3":
                    //Güncelleme
                    Category updateCategory = new Category();
                    Console.Write("Lütfen güncellemek istediğiniz kategorinin ID'sini giriniz:");
                    updateCategory.CategoryID = int.Parse(Console.ReadLine());
                    Console.Write("Lütfen kategori adını giriniz:");
                    updateCategory.CategoryName = Console.ReadLine();
                    Console.Write("Lütfen açıklma giriniz:");
                    updateCategory.Description = Console.ReadLine();
                    var value=db.Categories.Where(c => c.CategoryID == updateCategory.CategoryID).Select(c => c.CategoryName).FirstOrDefault();
                    Console.WriteLine($"{value} adlı kategoriyi güncellemek istediğinizden emin misiiz?(e/h)");
                    string gülcellemeSecim = Console.ReadLine();
                    if (gülcellemeSecim == "e")
                    {
                        string sonuc1 = categoryCrud.UpdateCategory(updateCategory);
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
                    int categoryId = int.Parse(Console.ReadLine());
                    var value2 = db.Categories.Where(c => c.CategoryID == categoryId).Select(c => c.CategoryName).FirstOrDefault();
                    Console.WriteLine($"{value2} isimli kategoriyi silmek istediğinizden emin misiiz?(e/h)");
                    string silmeSecim = Console.ReadLine();
                    if(silmeSecim == "e")
                    {
                        string sonuc3 = categoryCrud.DeleteCategory(categoryId);
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
