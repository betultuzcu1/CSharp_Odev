using MVC_Injection.Database;
using MVC_Injection.Models;
using MVC_Injection.Repository;

namespace MVC_Injection.Service
{
    //test verilerini listelen service
    public class TestCategoryService : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return CategoryTestData.categories.ToList();
        }
    }
}
