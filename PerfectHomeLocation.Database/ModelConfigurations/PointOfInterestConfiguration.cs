using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectHomeLocation.Database.Models;

namespace PerfectHomeLocation.Database.ModelConfigurations
{
	public class PointOfInterestConfiguration : IEntityTypeConfiguration<PointOfInterest>
	{
		public void Configure(EntityTypeBuilder<PointOfInterest> builder)
		{
			builder.HasKey(x => x.PointOfInterestId);
			builder.Property(x => x.PointOfInterestId).ValueGeneratedOnAdd();
			builder.HasOne(p => p.PointOfInterestType);
		}
	}
}

