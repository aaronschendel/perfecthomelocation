using Microsoft.AspNetCore.Mvc;
using PerfectHomeLocation.Api.Models;
using PerfectHomeLocation.Api.Services;
using PerfectHomeLocation.Database.Models;
using PerfectHomeLocation.Api.Clients;

namespace PerfectHomeLocation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly ILogger<MapsController> _logger;
        private readonly IMapsApiClient _mapsApiClient;
        private readonly IMapsService _mapsService;

        public MapsController(ILogger<MapsController> logger, IMapsApiClient mapsApiClient, IMapsService mapsService)
        {
            _logger = logger;
            _mapsApiClient = mapsApiClient;
            _mapsService= mapsService;
        }

        [HttpGet("/search")]
        public async Task<SearchByTextResponse> Get(string searchPhrase)
        {
            return await _mapsApiClient.SearchForPlace(searchPhrase);
        }

        [HttpPost("/pointofinterest/save")]
        public async Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, Models.PointOfInterestType pointOfInterestType)
        {
            return await _mapsService.SavePointOfInterest(searchPhrase, friendlyName, pointOfInterestType);
        }

        [HttpGet("/place/{placeId}")]
        public async Task<PlaceDetailsResponse> GetPlaceDetails(string placeId)
        {
            return await _mapsApiClient.GetPlaceDetailsResponse(placeId);
        }

        [HttpGet("/results")]
        public async Task<DistanceResultResponse> GetResults()
        {
            return await _mapsService.GetDistances("");
        }
    }
}