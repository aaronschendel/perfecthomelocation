using PerfectHomeLocation.Database;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private PerfHomeContext _context;

        public PointOfInterestRepository(PerfHomeContext context)
        {
            _context = context;
        }

        public void SavePointOfInterest(PointOfInterest pointOfInterest)
        {
            using (_context)
            {
                _context.PointsOfInterest.Add(pointOfInterest);
                _context.SaveChanges();
            }
        }
    }
}
