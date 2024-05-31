using MeetingServices.Model;
using MeetingServices.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeetingServices.Controllers
{
    /// <summary>
    /// Manages Meeting Data
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingService _service;

        public MeetingsController(IMeetingService service)
        {
            _service = service;
        }


        /// <summary>
        /// Get the total number of meetings
        /// </summary>
        /// <returns>Diplays the count of meetings</returns>
        [HttpGet("count")]
        public IActionResult GetMeetingCount()
        {
            try
            {
                return Ok(_service.GetMeetingCount());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred while retrieving the meeting count.");
            }

        }

        /// <summary>
        /// Get the details of all meetings
        /// </summary>
        /// <returns>Displays the list of meetings</returns>
        [HttpGet]
        public IActionResult GetAllMeeting()
        {
            try
            {
                return Ok(_service.GetAllMeeting());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, "An error occurred while retrieving the meeting count.");
            }

        }
    }
}
