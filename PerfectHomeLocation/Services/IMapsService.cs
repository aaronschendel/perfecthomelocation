using PerfectHomeLocation.Api.Models;
using PerfectHomeLocation.Database.Models;
using PointOfInterestType = PerfectHomeLocation.Api.Models.PointOfInterestType;

namespace PerfectHomeLocation.Api.Services
{
    public interface IMapsService
    {
        Task<SavePointOfInterestResponse> SavePointOfInterest(string searchPhrase, string friendlyName, PointOfInterestType pointOfInterestType);
    }
}