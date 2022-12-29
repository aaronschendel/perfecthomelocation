﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PerfectHomeLocation.Database.Contexts;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    [DbContext(typeof(PerfHomeContext))]
    [Migration("20221222214154_RemovingSnakeCasing")]
    partial class RemovingSnakeCasing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.PointOfInterest", b =>
                {
                    b.Property<long>("PointOfInterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("PointOfInterestId"));

                    b.Property<string>("FriendlyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PointOfInterestTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("SearchPhrase")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("PointOfInterestId");

                    b.HasIndex("PointOfInterestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("point_of_interest", (string)null);
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.PointOfInterestType", b =>
                {
                    b.Property<int>("PointOfInterestTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PointOfInterestTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PointOfInterestTypeId");

                    b.ToTable("point_of_interest_type", (string)null);

                    b.HasData(
                        new
                        {
                            PointOfInterestTypeId = 1,
                            Name = "Exact"
                        },
                        new
                        {
                            PointOfInterestTypeId = 2,
                            Name = "Relative"
                        });
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.PointOfInterest", b =>
                {
                    b.HasOne("PerfectHomeLocation.Database.Models.PointOfInterestType", "PointOfInterestType")
                        .WithMany()
                        .HasForeignKey("PointOfInterestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PerfectHomeLocation.Database.Models.User", null)
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("UserId");

                    b.Navigation("PointOfInterestType");
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.User", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
