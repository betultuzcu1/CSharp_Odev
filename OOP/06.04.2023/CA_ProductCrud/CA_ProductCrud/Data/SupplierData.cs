using CA_ProductCrud.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Data
{
    internal class SupplierData
    {
        public static List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier { CompanyName = "webdepo.com", ContactName = "Acar", PhoneNumber = "05554443322"},
            new Supplier { CompanyName = "senkop.com.tr", ContactName = "Mesut", PhoneNumber = "05554440011"}
        };
    }
}
