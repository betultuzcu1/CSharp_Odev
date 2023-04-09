using CA_ProductCrud.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Data
{
    internal class CategoryData
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category{CategoryName = "Elektronik", Description = "Elektronik ürünler"},
            new Category { CategoryName = "Kitap", Description = "Kitaplar" }
        };

       
    }
            
}
