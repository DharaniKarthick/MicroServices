using SupplierServices.Model;

namespace SupplierServices.Services
{
    public interface ISupplierService
    {
        int GetSupplierCount();
        List<Supplier> GetAllSupplier();
    }
}
