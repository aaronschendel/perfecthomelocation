using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class ActuallyUsingConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PointOfInterestTypes",
                columns: new[] { "PointOfInterestTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Exact" },
                    { 2, "Relative" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointOfInterestTypes",
                keyColumn: "PointOfInterestTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PointOfInterestTypes",
                keyColumn: "PointOfInterestTypeId",
                keyValue: 2);
        }
    }
}
