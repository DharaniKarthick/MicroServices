using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransactionService.Model;
using TransactionService.Service;

namespace TransactionService.Controllers
{
    /// <summary>
    /// Manages Trade Transaction Data
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _service;

        public TransactionsController(ITransactionService service)
        {
            _service = service;
        }

       
        /// <summary>
        /// Get the status asscociated with TradeId
        /// </summary>
        /// <param name="id">TradeId</param>
        /// <returns>Return the list of status</returns>
        [HttpGet("{id}")]
        public IActionResult GetAllSupplier(int id)
        {
            try
            {
                var tradeTransaction = _service.GetTradeTransactionById(id);
                if (tradeTransaction == null)
                {
                    return NotFound();
                }

                var statuses = _service.GetAllStatusById(id);
                var response = new
                {
                    TradeType = tradeTransaction.TradeType,
                    Statuses = statuses.Select(s => new { s.Status })
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
