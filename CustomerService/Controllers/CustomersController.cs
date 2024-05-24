using CustomerService.Model;
using CustomerService.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.Controllers
{

    /// <summary>
    /// Manages Customer Data
    /// </summary>
    [ApiController]
        [Route("api/[controller]")]
        public class CustomersController : ControllerBase
        {
            private readonly ICustomerService _service;

            public CustomersController(ICustomerService service)
            {
                _service = service;
            }

        /// <summary>
        /// Get the total number of customers
        /// </summary>
        /// <returns>Diplays the count of customers</returns>
        [HttpGet("count")]
            public ActionResult<int> GetCustomerCount()
            {
                try
                {
                    return _service.GetCustomerCount();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                    return StatusCode(500, "An error occurred");
                }
            }
        /// <summary>
        /// Get the details of all customers
        /// </summary>
        /// <returns>Displays the list of customers</returns>
        [HttpGet]
            public ActionResult<List<Customer>> GetAllCustomers()
            {
            try
            {
                return _service.GetAllCustomers();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred");
            }

            }
        }

    
}
