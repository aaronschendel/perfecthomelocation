using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PerfectHomeLocation.Database.ModelConfigurations
{
	public class PointOfInterestConfiguration : IEntityTypeConfiguration<PointOfInterest>
	{
		public void Configure(EntityTypeBuilder<PointOfInterest> builder)
		{
			builder.HasKey(x => x.PointOfInterestId);
			builder.Property(x => x.PointOfInterestId).ValueGeneratedOnAdd();


            builder.HasOne(t => t.PointOfInterestType)
            .WithMany(u => u.PointOfInterest)
            .HasForeignKey(u => u.MemberTypeId);

        }
	}
}

