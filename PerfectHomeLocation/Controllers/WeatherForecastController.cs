using Microsoft.AspNetCore.Mvc;

namespace PerfectHomeLocation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly ILogger<MapsController> _logger;

        public MapsController(ILogger<MapsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            
        }
    }
}