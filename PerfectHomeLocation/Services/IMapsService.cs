namespace PerfectHomeLocation.Services
{
    public interface IMapsService
    {
        Task<SearchByTextResponse> SearchForPlace(string searchString);
    }
}

