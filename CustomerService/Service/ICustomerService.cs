using CustomerService.Model;

namespace CustomerService.Service
{
    public interface ICustomerService
    {
        int GetCustomerCount();
        List<Customer> GetAllCustomers();
    }
}
