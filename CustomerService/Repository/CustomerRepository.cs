using CustomerService.DatabaseContext;
using CustomerService.Model;

namespace CustomerService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDBContext _context;

        public CustomerRepository(CustomerDBContext context)
        {
            _context = context;
        }

        public int GetCustomerCount()
        {
            return _context.Customers.Count();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
