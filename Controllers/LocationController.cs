using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LocationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
        }

        // POST: api/location
        [HttpPost("{latitude}/{longitude}")]
        public async Task<IActionResult> PostLocation([FromRoute] double latitude, [FromRoute] double longitude)
        {
            if (latitude >= -90 && latitude <= 90 && longitude >= -180 && longitude <= 180)
            {
                var location = Location.Default;

                if (location == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(location);
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
