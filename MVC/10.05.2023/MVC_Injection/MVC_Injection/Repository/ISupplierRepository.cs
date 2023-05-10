using MVC_Injection.Models;

namespace MVC_Injection.Repository
{
    public interface ISupplierRepository
    {
        List<Supplier> GetSuppliers();
        void AddSupplier(Supplier supplier);
    }
}
