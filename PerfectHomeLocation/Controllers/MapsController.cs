using Microsoft.AspNetCore.Mvc;
using PerfectHomeLocation.Clients;
using PerfectHomeLocation.Database.Models;
using PerfectHomeLocation.Models;
using PerfectHomeLocation.Services;

namespace PerfectHomeLocation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly ILogger<MapsController> _logger;
        private readonly IMapsApiClient _mapsApiClient;
        private readonly IMapsService _mapsService;

        public MapsController(ILogger<MapsController> logger, IMapsApiClient mapsApiClient)
        {
            _logger = logger;
            _mapsApiClient = mapsApiClient;
        }

        [HttpGet("/search")]
        public async Task<SearchByTextResponse> Get(string searchPhrase)
        {
            return await _mapsApiClient.SearchForPlace(searchPhrase);
        }

        [HttpPost("/pointofinterest/save")]
        public async Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, int pointOfInterestType)
        {
            return await _mapsService.SavePointOfInterest(searchPhrase, friendlyName, pointOfInterestType);
        }

        [HttpGet("/place/{placeId}")]
        public async Task<PlaceDetailsResponse> GetPlaceDetails(string placeId)
        {
            return await _mapsApiClient.GetPlaceDetailsResponse(placeId);
        }

        [HttpGet("/results")]
        public Task<DistanceResultResponse> GetResults()
        {
            return null;
        }
    }
}