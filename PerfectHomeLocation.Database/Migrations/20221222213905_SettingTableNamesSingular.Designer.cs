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
    [Migration("20221222213905_SettingTableNamesSingular")]
    partial class SettingTableNamesSingular
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
                        .HasColumnType("bigint")
                        .HasColumnName("point_of_interest_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("PointOfInterestId"));

                    b.Property<string>("FriendlyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("friendly_name");

                    b.Property<int>("PointOfInterestTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("point_of_interest_type_id");

                    b.Property<string>("SearchPhrase")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("search_phrase");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("PointOfInterestId")
                        .HasName("pk_point_of_interest");

                    b.HasIndex("PointOfInterestTypeId")
                        .HasDatabaseName("ix_point_of_interest_point_of_interest_type_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_point_of_interest_user_id");

                    b.ToTable("point_of_interest", (string)null);
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.PointOfInterestType", b =>
                {
                    b.Property<int>("PointOfInterestTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("point_of_interest_type_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PointOfInterestTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("PointOfInterestTypeId")
                        .HasName("pk_point_of_interest_type");

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
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("UserId")
                        .HasName("pk_user");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("PerfectHomeLocation.Database.Models.PointOfInterest", b =>
                {
                    b.HasOne("PerfectHomeLocation.Database.Models.PointOfInterestType", "PointOfInterestType")
                        .WithMany()
                        .HasForeignKey("PointOfInterestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_point_of_interest_point_of_interest_types_point_of_interest");

                    b.HasOne("PerfectHomeLocation.Database.Models.User", null)
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_point_of_interest_users_user_id");

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
