using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Crud
{
    internal class CategoryCrud
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        //Listeleme
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        //Ekleme
        public string AddCategory(Category category)
        {
            try
            {
                Category category1 = new Category();
                Console.Write("Lütfen kategori adını giriniz:");
                category1.CategoryName = Console.ReadLine();
                Console.Write("Lütfen açıklma giriniz:");
                category1.Description = Console.ReadLine();               
                db.Categories.Add(category1);

                if (db.SaveChanges() > 0)
                {
                    return "Kategori başarı ile eklendi!";
                }
                else
                {
                    return "Ekleme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }

        //güncelleme

        public string UpdateCategory(Category category)
        {
            try
            {
                Category updateCategory = db.Categories.Find(category.CategoryID);
                updateCategory.CategoryName = category.CategoryName;
                updateCategory.Description = category.Description;               
                if (db.SaveChanges() > 0)
                {
                    return "Kategori başarı ile güncellendi!";
                }
                else
                {
                    return "Güncelleme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }

        //silme 

        public string DeleteCategory(int id)
        {
            try
            {
                var value = db.Categories.Find(id);
                db.Categories.Remove(value);

                if (db.SaveChanges() > 0)
                {
                    return "Kategori başarı ile silindi!";
                }
                else
                {
                    return "Silme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }
    }
}
