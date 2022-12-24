using System;
namespace PerfectHomeLocation.Database.Models
{
	public class User
	{
		public long UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public virtual ICollection<PointOfInterest> PointsOfInterest { get; set; }
	}
}

