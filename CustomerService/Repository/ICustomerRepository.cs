using CustomerService.Model;

namespace CustomerService.Repository
{
    public interface ICustomerRepository
    {
        int GetCustomerCount();
        List<Customer> GetAllCustomers();
    }

}
