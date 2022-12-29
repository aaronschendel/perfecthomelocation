namespace PerfectHomeLocation.Core.Clients
{
    public interface IMapsApiClient
    {
        Task<SearchByTextResponse> SearchForPlace(string searchString);
        Task<PlaceDetailsResponse> GetPlaceDetailsResponse(string placeId);
    }
}

