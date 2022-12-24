using PerfectHomeLocation.Clients;
using PerfectHomeLocation.Database.Models;
using PerfectHomeLocation.Models;
using PerfectHomeLocation.Repositories;

namespace PerfectHomeLocation.Services
{
    public class MapsService : IMapsService
    {
        private readonly IPointOfInterestRepository _pointOfInterestRepository;
        private readonly IMapsApiClient _mapsApiClient;

        public MapsService(IPointOfInterestRepository pointOfInterestRepository, IMapsApiClient mapsApiClient)
        {
            _pointOfInterestRepository = pointOfInterestRepository;
            _mapsApiClient = mapsApiClient;
        }

        public async Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, PointOfInterestType pointOfInterestType)
        {
            var searchResponse = await _mapsApiClient.SearchForPlace(searchPhrase);
            var placeId = searchResponse.Candidates[0].PlaceId;
            var placeDetailsResponse = await _mapsApiClient.GetPlaceDetailsResponse(placeId);

            var pointOfInterest = new PointOfInterest
            {
                FriendlyName = friendlyName,
                SearchPhrase = searchPhrase,
                PointOfInterestType = pointOfInterestType,
                PlaceId = placeId
            };

            _pointOfInterestRepository.SavePointOfInterest(pointOfInterest);

            return new SavePointOfInterestResponse
            {
                FoundPlaceName = placeDetailsResponse.Result.Name,
                PlaceId = placeId,
                SearchPhrase = searchPhrase
            };
        }
    }
}
