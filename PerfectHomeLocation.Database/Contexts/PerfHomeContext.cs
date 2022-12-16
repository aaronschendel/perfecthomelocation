using System;
using Microsoft.EntityFrameworkCore;

namespace PerfectHomeLocation.Database
{
	public class PerfHomeContext
	{
		public DbSet<PointOfInterest> PointsOfInterest { get; set; }

	}
}

