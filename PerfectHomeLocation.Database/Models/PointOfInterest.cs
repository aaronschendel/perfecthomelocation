using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Database;
public class PointOfInterest
{
    public long PointOfInterestId { get; set; }
    public string FriendlyName { get; set; }
    public string SearchPhrase { get; set; }
    public virtual PointOfInterestType PointOfInterestType { get; set; }
}

