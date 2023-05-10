using MVC_Injection.Models;

namespace MVC_Injection.Database
{

    //Test data
    public class CategoryTestData
    {
       public static List<Category> categories = new List<Category>
        {
            new Category{Id=1,CategoryName="Yiyecek"},
            new Category{Id=2,CategoryName="İçecek"},
            new Category{Id=3,CategoryName="Tatlılar"},

        };
    }
}
