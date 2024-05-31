using CustomerService.Model;
using CustomerService.Repository;

namespace CustomerService.Service
{
    public class CustomersService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomersService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public int GetCustomerCount()
        {
            return _repository.GetCustomerCount();
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }
    }
}
