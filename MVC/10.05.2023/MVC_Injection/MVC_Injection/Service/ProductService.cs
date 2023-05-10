using MVC_Injection.Database;
using MVC_Injection.Models;
using MVC_Injection.Repository;

namespace MVC_Injection.Service
{
    public class ProductService : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return ProductData.products.ToList();
        }
    }
}
