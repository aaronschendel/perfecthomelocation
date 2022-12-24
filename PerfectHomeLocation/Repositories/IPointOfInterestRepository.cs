using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Repositories
{
    public interface IPointOfInterestRepository
    {
        void SavePointOfInterest(PointOfInterest pointOfInterest);
    }
}