using Microsoft.AspNetCore.Mvc;
using PerfectHomeLocation.Services;

namespace PerfectHomeLocation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly ILogger<MapsController> _logger;
        private readonly IMapsService _mapsService;

        public MapsController(ILogger<MapsController> logger, IMapsService mapsService)
        {
            _logger = logger;
            _mapsService = mapsService;
        }

        [HttpGet]
        public Task<SearchByTextResponse> Get()
        {
            return _mapsService.SearchForPlace("panera bread eagan");
        }
    }
}