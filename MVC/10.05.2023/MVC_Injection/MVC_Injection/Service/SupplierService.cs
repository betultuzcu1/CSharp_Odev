using MVC_Injection.Database;
using MVC_Injection.Models;
using MVC_Injection.Repository;

namespace MVC_Injection.Service
{
    public class SupplierService : ISupplierRepository
    {
        public void AddSupplier(Supplier supplier)
        {
            SupplierData.suppliers.Add(supplier);
        }

        public List<Supplier> GetSuppliers()
        {
            return SupplierData.suppliers.ToList();
        }

    }
}
