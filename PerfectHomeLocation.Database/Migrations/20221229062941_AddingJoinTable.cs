using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_point_of_interest_user_UserId",
                table: "point_of_interest");

            migrationBuilder.DropIndex(
                name: "IX_point_of_interest_UserId",
                table: "point_of_interest");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "point_of_interest");

            migrationBuilder.CreateTable(
                name: "UserPointsOfInterest",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PointOfInterestTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPointsOfInterest", x => new { x.UserId, x.PointOfInterestTypeId });
                    table.ForeignKey(
                        name: "FK_UserPointsOfInterest_point_of_interest_type_PointOfInterest~",
                        column: x => x.PointOfInterestTypeId,
                        principalTable: "point_of_interest_type",
                        principalColumn: "PointOfInterestTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPointsOfInterest_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPointsOfInterest_PointOfInterestTypeId",
                table: "UserPointsOfInterest",
                column: "PointOfInterestTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPointsOfInterest");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "point_of_interest",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_point_of_interest_UserId",
                table: "point_of_interest",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_point_of_interest_user_UserId",
                table: "point_of_interest",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId");
        }
    }
}
