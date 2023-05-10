using MVC_Injection.Models;

namespace MVC_Injection.Database
{
    public class SupplierData
    {
        public static List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier{ID=1,CompanyName="Exotic Liquids",ContactName="Charlotte Coope"},
            new Supplier{ID=2,CompanyName="New Orleans Cajun Delights",ContactName="Shelley Burke"},
            new Supplier{ID=3,CompanyName="Grandma Kelly's Homestead",ContactName="Regina Murphy"},
        };
    }
}
