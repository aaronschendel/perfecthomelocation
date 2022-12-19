using System;
using Microsoft.EntityFrameworkCore;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Database
{
	public class PerfHomeContext : DbContext
	{
		public DbSet<PointOfInterest> PointsOfInterest { get; set; }
		public DbSet<PointOfInterestType> PointOfInterestTypes { get; set; }
		public DbSet<User> Users { get; set; }
	}
}

