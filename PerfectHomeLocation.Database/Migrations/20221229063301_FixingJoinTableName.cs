using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixingJoinTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPointsOfInterest_point_of_interest_type_PointOfInterest~",
                table: "UserPointsOfInterest");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPointsOfInterest_user_UserId",
                table: "UserPointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPointsOfInterest",
                table: "UserPointsOfInterest");

            migrationBuilder.RenameTable(
                name: "UserPointsOfInterest",
                newName: "user_point_of_interest");

            migrationBuilder.RenameIndex(
                name: "IX_UserPointsOfInterest_PointOfInterestTypeId",
                table: "user_point_of_interest",
                newName: "IX_user_point_of_interest_PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_point_of_interest",
                table: "user_point_of_interest",
                columns: new[] { "UserId", "PointOfInterestTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_user_point_of_interest_point_of_interest_type_PointOfIntere~",
                table: "user_point_of_interest",
                column: "PointOfInterestTypeId",
                principalTable: "point_of_interest_type",
                principalColumn: "PointOfInterestTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_point_of_interest_user_UserId",
                table: "user_point_of_interest",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_point_of_interest_point_of_interest_type_PointOfIntere~",
                table: "user_point_of_interest");

            migrationBuilder.DropForeignKey(
                name: "FK_user_point_of_interest_user_UserId",
                table: "user_point_of_interest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_point_of_interest",
                table: "user_point_of_interest");

            migrationBuilder.RenameTable(
                name: "user_point_of_interest",
                newName: "UserPointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_user_point_of_interest_PointOfInterestTypeId",
                table: "UserPointsOfInterest",
                newName: "IX_UserPointsOfInterest_PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPointsOfInterest",
                table: "UserPointsOfInterest",
                columns: new[] { "UserId", "PointOfInterestTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserPointsOfInterest_point_of_interest_type_PointOfInterest~",
                table: "UserPointsOfInterest",
                column: "PointOfInterestTypeId",
                principalTable: "point_of_interest_type",
                principalColumn: "PointOfInterestTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPointsOfInterest_user_UserId",
                table: "UserPointsOfInterest",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
