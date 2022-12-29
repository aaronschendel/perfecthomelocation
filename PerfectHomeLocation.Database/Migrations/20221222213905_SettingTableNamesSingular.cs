using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class SettingTableNamesSingular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_PointOfInterestTypes_PointOfInterestTypeId",
                table: "PointsOfInterest");

            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Users_UserId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointOfInterestTypes",
                table: "PointOfInterestTypes");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "point_of_interest");

            migrationBuilder.RenameTable(
                name: "PointOfInterestTypes",
                newName: "point_of_interest_type");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "user",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "user",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "user",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "point_of_interest",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "SearchPhrase",
                table: "point_of_interest",
                newName: "search_phrase");

            migrationBuilder.RenameColumn(
                name: "PointOfInterestTypeId",
                table: "point_of_interest",
                newName: "point_of_interest_type_id");

            migrationBuilder.RenameColumn(
                name: "FriendlyName",
                table: "point_of_interest",
                newName: "friendly_name");

            migrationBuilder.RenameColumn(
                name: "PointOfInterestId",
                table: "point_of_interest",
                newName: "point_of_interest_id");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_UserId",
                table: "point_of_interest",
                newName: "ix_point_of_interest_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_PointOfInterestTypeId",
                table: "point_of_interest",
                newName: "ix_point_of_interest_point_of_interest_type_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "point_of_interest_type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PointOfInterestTypeId",
                table: "point_of_interest_type",
                newName: "point_of_interest_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user",
                table: "user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_point_of_interest",
                table: "point_of_interest",
                column: "point_of_interest_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_point_of_interest_type",
                table: "point_of_interest_type",
                column: "point_of_interest_type_id");

            migrationBuilder.AddForeignKey(
                name: "fk_point_of_interest_point_of_interest_types_point_of_interest",
                table: "point_of_interest",
                column: "point_of_interest_type_id",
                principalTable: "point_of_interest_type",
                principalColumn: "point_of_interest_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_point_of_interest_users_user_id",
                table: "point_of_interest",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_point_of_interest_point_of_interest_types_point_of_interest",
                table: "point_of_interest");

            migrationBuilder.DropForeignKey(
                name: "fk_point_of_interest_users_user_id",
                table: "point_of_interest");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "pk_point_of_interest_type",
                table: "point_of_interest_type");

            migrationBuilder.DropPrimaryKey(
                name: "pk_point_of_interest",
                table: "point_of_interest");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "point_of_interest_type",
                newName: "PointOfInterestTypes");

            migrationBuilder.RenameTable(
                name: "point_of_interest",
                newName: "PointsOfInterest");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "PointOfInterestTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_type_id",
                table: "PointOfInterestTypes",
                newName: "PointOfInterestTypeId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "PointsOfInterest",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "search_phrase",
                table: "PointsOfInterest",
                newName: "SearchPhrase");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_type_id",
                table: "PointsOfInterest",
                newName: "PointOfInterestTypeId");

            migrationBuilder.RenameColumn(
                name: "friendly_name",
                table: "PointsOfInterest",
                newName: "FriendlyName");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_id",
                table: "PointsOfInterest",
                newName: "PointOfInterestId");

            migrationBuilder.RenameIndex(
                name: "ix_point_of_interest_user_id",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_UserId");

            migrationBuilder.RenameIndex(
                name: "ix_point_of_interest_point_of_interest_type_id",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointOfInterestTypes",
                table: "PointOfInterestTypes",
                column: "PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "PointOfInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_PointOfInterestTypes_PointOfInterestTypeId",
                table: "PointsOfInterest",
                column: "PointOfInterestTypeId",
                principalTable: "PointOfInterestTypes",
                principalColumn: "PointOfInterestTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Users_UserId",
                table: "PointsOfInterest",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
