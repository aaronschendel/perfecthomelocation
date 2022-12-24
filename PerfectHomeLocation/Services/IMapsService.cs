using PerfectHomeLocation.Database.Models;
using PerfectHomeLocation.Models;

namespace PerfectHomeLocation.Services
{
    public interface IMapsService
    {
        Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, PointOfInterestType pointOfInterestType);
    }
}