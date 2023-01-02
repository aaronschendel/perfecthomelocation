using PerfectHomeLocation.Api.Models;
using PerfectHomeLocation.Api.Repositories.DTOs;
using PerfectHomeLocation.Database.Contexts;
using PerfectHomeLocation.Database.Models;
using System.ComponentModel;

namespace PerfectHomeLocation.Api.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private PerfHomeContext _dbContext;

        public PointOfInterestRepository(PerfHomeContext context)
        {
            _dbContext = context;
        }

        public async void SavePointOfInterest(PointOfInterest pointOfInterest)
        {
            await _dbContext.PointsOfInterest.AddAsync(pointOfInterest);
            await _dbContext.SaveChangesAsync();
        }

        public List<PointOfInterestDto> GetPointsOfInterest(long userId)
        {
            return _dbContext.PointsOfInterest.Select(p => new PointOfInterestDto
            {
                FriendlyName = p.FriendlyName,
                PlaceId = p.PlaceId,
                PointOfInterestType = Enum.Parse<Models.PointOfInterestType>(p.PointOfInterestTypeId.ToString()),
                SearchPhrase= p.SearchPhrase
            }).ToList();
        }
    }
}
