using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfectHomeLocation.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectHomeLocation.Database.ModelConfigurations
{
    public class UserPointOfInterestConfiguration : IEntityTypeConfiguration<UserPointOfInterest>
    {
        public void Configure(EntityTypeBuilder<UserPointOfInterest> builder)
        {
            builder.HasKey(d => new {d.UserId, d.PointOfInterestTypeId});

            builder.ToTable("user_point_of_interest");
        }
    }
}
