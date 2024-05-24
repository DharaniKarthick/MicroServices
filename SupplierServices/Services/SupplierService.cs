using SupplierServices.Model;
using SupplierServices.Repository;

namespace SupplierServices.Services
{
    public class SuppliersService:ISupplierService
    {
        private readonly ISupplierRepository _repository;

        public SuppliersService(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public int GetSupplierCount()
        {
            return _repository.GetSupplierCount();
        }

        public List<Supplier> GetAllSupplier()
        {
            return _repository.GetAllSupplier();
        }
    }
}
