using MVC_Injection.Models;

namespace MVC_Injection.Database
{
    public class ProductData
    {
        //Product List

        public static List<Product> products = new List<Product>()
        {

            new Product{ID=1,ProductName="Chai",UnitPrice=18},
            new Product{ID=2,ProductName="Ikura",UnitPrice=20},
            new Product{ID=3,ProductName="Tofu",UnitPrice=25},
            new Product{ID=4,ProductName="Chang",UnitPrice=28},
        };
    }
}
