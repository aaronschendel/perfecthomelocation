
namespace PerfectHomeLocation.Database.Models;
public class PointOfInterest
{
    public long PointOfInterestId { get; set; }
    public string FriendlyName { get; set; }
    public string SearchPhrase { get; set; }
    public string PlaceId { get; set; }
    public int PointOfInterestTypeId { get; set; }
    public virtual PointOfInterestType PointOfInterestType { get; set; }
}

