using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Api.Repositories
{
    public interface IPointOfInterestRepository
    {
        void SavePointOfInterest(PointOfInterest pointOfInterest);
    }
}