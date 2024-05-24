using SupplierServices.Model;

namespace SupplierServices.Repository
{
    public interface ISupplierRepository
    {

        int GetSupplierCount();
        List<Supplier> GetAllSupplier();
    }
}
