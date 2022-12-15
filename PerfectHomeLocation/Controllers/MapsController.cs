using Microsoft.AspNetCore.Mvc;
using PerfectHomeLocation.Clients;
using PerfectHomeLocation.Models;

namespace PerfectHomeLocation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly ILogger<MapsController> _logger;
        private readonly IMapsApiClient _mapsApiClient;

        public MapsController(ILogger<MapsController> logger, IMapsApiClient mapsService)
        {
            _logger = logger;
            _mapsApiClient = mapsService;
        }

        [HttpGet("/search")]
        public Task<SearchByTextResponse> Get(string searchPhrase)
        {
            return _mapsApiClient.SearchForPlace(searchPhrase);
        }

        [HttpGet("/place/{placeId}")]
        public Task<PlaceDetailsResponse> GetPlaceDetails(string placeId)
        {
            return _mapsApiClient.GetPlaceDetailsResponse(placeId);
        }

        [HttpGet("/results")]
        public Task<DistanceResultResponse> GetResults(string homeCandidateAddress)
        {
            return null;
        }
    }
}