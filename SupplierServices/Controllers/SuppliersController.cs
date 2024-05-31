using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplierServices.Model;
using SupplierServices.Services;

namespace SupplierServices.Controllers
{

    /// <summary>
    /// Manages Supplier Data
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _service;

        public SuppliersController(ISupplierService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get the total number of suppliers
        /// </summary>
        /// <returns>Diplays the count of suppliers</returns>
        [HttpGet("count")]
        public IActionResult GetCustomerCount()
        {
            try
            {
                return Ok(_service.GetSupplierCount());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred");
            }
        }
        /// <summary>
        /// Get the details of all suppliers
        /// </summary>
        /// <returns>Displays the list of suppliers</returns>
        [HttpGet]
        public IActionResult GetAllSupplier()
        {
            try
            {
                return Ok(_service.GetAllSupplier());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred");
            }

        }
    }
}
