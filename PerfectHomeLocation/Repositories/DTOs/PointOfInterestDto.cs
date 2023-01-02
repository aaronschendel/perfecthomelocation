using PerfectHomeLocation.Api.Models;

namespace PerfectHomeLocation.Api.Repositories.DTOs
{
    public class PointOfInterestDto
    {
        public string FriendlyName { get; set; }
        public string SearchPhrase { get; set; }
        public string? PlaceId { get; set; }
        public virtual PointOfInterestType PointOfInterestType { get; set; }
    }
}
