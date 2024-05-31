using SupplierServices.DatabaseContext;
using SupplierServices.Model;

namespace SupplierServices.Repository
{
    public class SupplierRepository:ISupplierRepository
    {
        private readonly SupplierDBContext _context;

        public SupplierRepository(SupplierDBContext context)
        {
            _context = context;
        }

        public int GetSupplierCount()
        {
            return _context.Suppliers.Count();
        }

        public List<Supplier> GetAllSupplier()
        {
            return _context.Suppliers.ToList();
        }
    }
}
