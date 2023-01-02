using PerfectHomeLocation.Api.Repositories.DTOs;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Api.Repositories
{
    public interface IPointOfInterestRepository
    {
        List<PointOfInterestDto> GetPointsOfInterest(long userId);
        void SavePointOfInterest(PointOfInterest pointOfInterest);
    }
}