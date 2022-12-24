using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class TryAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointOfInterestTypes_PointOfInterestTypes_PointOfInterestTy~",
                table: "PointOfInterestTypes");

            migrationBuilder.DropIndex(
                name: "IX_PointOfInterestTypes_PointOfInterestTypeId1",
                table: "PointOfInterestTypes");

            migrationBuilder.DropColumn(
                name: "PointOfInterestTypeId1",
                table: "PointOfInterestTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointOfInterestTypeId1",
                table: "PointOfInterestTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PointOfInterestTypes_PointOfInterestTypeId1",
                table: "PointOfInterestTypes",
                column: "PointOfInterestTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PointOfInterestTypes_PointOfInterestTypes_PointOfInterestTy~",
                table: "PointOfInterestTypes",
                column: "PointOfInterestTypeId1",
                principalTable: "PointOfInterestTypes",
                principalColumn: "PointOfInterestTypeId");
        }
    }
}
