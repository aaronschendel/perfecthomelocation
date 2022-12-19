using System;
namespace PerfectHomeLocation.Database.Models
{
	public class PointOfInterestType
	{
		public int PointOfInterestTypeId { get; set; }
		public string Name { get; set; } = string.Empty;
		public virtual ICollection<PointOfInterestType> PointOfInterestTypes { get; set; } = new List<PointOfInterestType>();
	}
}

