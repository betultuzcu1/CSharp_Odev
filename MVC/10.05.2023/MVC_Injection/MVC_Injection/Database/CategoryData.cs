using MVC_Injection.Models;

namespace MVC_Injection.Database
{
    //veritabanını temsil eden nesne
    public class CategoryData
    {
        public static List<Category> categories = new List<Category>
        {
            new Category{Id=1,CategoryName="Beveregas"},
            new Category{Id=2,CategoryName="Condiments"},
            new Category{Id=3,CategoryName="Desserts"},

        };
    }
}
