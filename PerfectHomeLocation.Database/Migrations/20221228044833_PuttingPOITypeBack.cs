using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class PuttingPOITypeBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PointOfInterestType",
                table: "point_of_interest",
                newName: "PointOfInterestTypeId");

            migrationBuilder.CreateTable(
                name: "point_of_interest_type",
                columns: table => new
                {
                    PointOfInterestTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_point_of_interest_type", x => x.PointOfInterestTypeId);
                });

            migrationBuilder.InsertData(
                table: "point_of_interest_type",
                columns: new[] { "PointOfInterestTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Exact" },
                    { 2, "Relative" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_point_of_interest_PointOfInterestTypeId",
                table: "point_of_interest",
                column: "PointOfInterestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_point_of_interest_point_of_interest_type_PointOfInterestTyp~",
                table: "point_of_interest",
                column: "PointOfInterestTypeId",
                principalTable: "point_of_interest_type",
                principalColumn: "PointOfInterestTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_point_of_interest_point_of_interest_type_PointOfInterestTyp~",
                table: "point_of_interest");

            migrationBuilder.DropTable(
                name: "point_of_interest_type");

            migrationBuilder.DropIndex(
                name: "IX_point_of_interest_PointOfInterestTypeId",
                table: "point_of_interest");

            migrationBuilder.RenameColumn(
                name: "PointOfInterestTypeId",
                table: "point_of_interest",
                newName: "PointOfInterestType");
        }
    }
}
