using MVC_Injection.Models;

namespace MVC_Injection.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        
    }
}
