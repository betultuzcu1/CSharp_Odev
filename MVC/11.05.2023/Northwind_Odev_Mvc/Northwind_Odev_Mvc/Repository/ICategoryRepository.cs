using Northwind_Odev_Mvc.Models;

namespace Northwind_Odev_Mvc.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

        string CreateCategory(Category category);

        string DeleteCategory(int categoryId);

        string UpdateCategory(Category category);

        Category FindCategory(int categoryId);
    }
}
