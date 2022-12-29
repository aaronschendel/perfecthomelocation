using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PerfectHomeLocation.Database.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace PerfectHomeLocation.Database.Contexts
{
    public class PerfHomeContext : DbContext
    {
        public PerfHomeContext(DbContextOptions<PerfHomeContext> options)
        : base(options)
        {
        }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
        public DbSet<PointOfInterestType> PointOfInterestTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPointOfInterest> UserPointsOfInterest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder//.UseSnakeCaseNamingConvention()
                .UseLazyLoadingProxies()
                .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));

            base.OnConfiguring(optionsBuilder);
        }
    }
}

