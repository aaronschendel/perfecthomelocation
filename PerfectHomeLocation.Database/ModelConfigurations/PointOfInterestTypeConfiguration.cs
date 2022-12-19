using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Database.ModelConfigurations
{
	public class PointOfInterestTypeConfiguration : IEntityTypeConfiguration<PointOfInterestType>
	{
		public void Configure(EntityTypeBuilder<PointOfInterestType> builder)
		{
			builder.HasKey(t => t.PointOfInterestTypeId);

			builder.HasData(new PointOfInterestType
			{
				PointOfInterestTypeId = 1,
				Name = "Exact"
			});

			builder.HasData(new PointOfInterestType
			{
				PointOfInterestTypeId = 2,
				Name = "Relative"
			});
		}
	}
}

