using Microsoft.CodeAnalysis;
using Northwind_Odev_Mvc.Models;
using Northwind_Odev_Mvc.Repository;

namespace Northwind_Odev_Mvc.Service
{
    public class CategoryService : ICategoryRepository
    {
        NorthwndContext context=new NorthwndContext();
        public string CreateCategory(Category category)
        {
            try
            {
                context.Categories.Add(category);

                context.SaveChanges();

                return "Ürün başarı ile eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteCategory(int categoryId)
        {
            try
            {
                var deleted = FindCategory(categoryId);
                context.Categories.Remove(deleted);
                context.SaveChanges();
                return "Ürün başarı ile kaldırıldı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Category FindCategory(int categoryId)
        {
            return context.Categories.Find(categoryId);
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public string UpdateCategory(Category category)
        {
            var updated = FindCategory(category.CategoryId);

            if (updated != null)
            {
                context.Entry(updated).CurrentValues.SetValues(category);
                context.SaveChanges();
                return "Ürün güncellendi!";
            }
            else
            {
                return $"{category.CategoryId} numaralı bir ürün bulunamadı!";
            }
        }
    }
}
