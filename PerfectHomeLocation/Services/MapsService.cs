using PerfectHomeLocation.Api.Clients;
using PerfectHomeLocation.Api.Models;
using PerfectHomeLocation.Api.Repositories;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Api.Services
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

        public async Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, Models.PointOfInterestType pointOfInterestType)
        {
            var pointOfInterest = new PointOfInterest
            {
                FriendlyName = friendlyName,
                SearchPhrase = searchPhrase,
                PointOfInterestTypeId = (int) pointOfInterestType
            };

            string placeId = "";
            string placeName = "";

            if (pointOfInterestType == Models.PointOfInterestType.Exact)
            {
                var searchResponse = await _mapsApiClient.SearchForPlace(searchPhrase);
                placeId = searchResponse.Candidates[0].PlaceId;
                var placeDetailsResponse = await _mapsApiClient.GetPlaceDetailsResponse(placeId);
                placeName = placeDetailsResponse.Result.Name;

                pointOfInterest.PlaceId = placeId;
            }

            _pointOfInterestRepository.SavePointOfInterest(pointOfInterest);

            return new SavePointOfInterestResponse
            {
                FoundPlaceName = placeName,
                PlaceId = placeId,
                SearchPhrase = searchPhrase
            };
        }

        public async Task<DistanceResultResponse> GetDistances(string startingAddress)
        {
            var result = _pointOfInterestRepository.GetPointsOfInterest(1);


            return new DistanceResultResponse();
        }
    }
}
