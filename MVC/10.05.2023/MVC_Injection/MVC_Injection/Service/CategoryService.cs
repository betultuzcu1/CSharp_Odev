using MVC_Injection.Database;
using MVC_Injection.Models;
using MVC_Injection.Repository;

namespace MVC_Injection.Service
{
    //veritabanı nesnelerini döndüren service
    public class CategoryService : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            //Categories
            return CategoryData.categories.ToList();
        }
    }
}
