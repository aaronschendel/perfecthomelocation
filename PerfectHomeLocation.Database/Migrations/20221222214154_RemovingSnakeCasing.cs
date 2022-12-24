using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class RemovingSnakeCasing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "email",
                table: "user",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "user",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "user",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "point_of_interest_type",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_type_id",
                table: "point_of_interest_type",
                newName: "PointOfInterestTypeId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "point_of_interest",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "search_phrase",
                table: "point_of_interest",
                newName: "SearchPhrase");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_type_id",
                table: "point_of_interest",
                newName: "PointOfInterestTypeId");

            migrationBuilder.RenameColumn(
                name: "friendly_name",
                table: "point_of_interest",
                newName: "FriendlyName");

            migrationBuilder.RenameColumn(
                name: "point_of_interest_id",
                table: "point_of_interest",
                newName: "PointOfInterestId");

            migrationBuilder.RenameIndex(
                name: "ix_point_of_interest_user_id",
                table: "point_of_interest",
                newName: "IX_point_of_interest_UserId");

            migrationBuilder.RenameIndex(
                name: "ix_point_of_interest_point_of_interest_type_id",
                table: "point_of_interest",
                newName: "IX_point_of_interest_PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_point_of_interest_type",
                table: "point_of_interest_type",
                column: "PointOfInterestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_point_of_interest",
                table: "point_of_interest",
                column: "PointOfInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_point_of_interest_point_of_interest_type_PointOfInterestTyp~",
                table: "point_of_interest",
                column: "PointOfInterestTypeId",
                principalTable: "point_of_interest_type",
                principalColumn: "PointOfInterestTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_point_of_interest_user_UserId",
                table: "point_of_interest",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_point_of_interest_point_of_interest_type_PointOfInterestTyp~",
                table: "point_of_interest");

            migrationBuilder.DropForeignKey(
                name: "FK_point_of_interest_user_UserId",
                table: "point_of_interest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_point_of_interest_type",
                table: "point_of_interest_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_point_of_interest",
                table: "point_of_interest");

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
                name: "Name",
                table: "point_of_interest_type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PointOfInterestTypeId",
                table: "point_of_interest_type",
                newName: "point_of_interest_type_id");

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
                name: "IX_point_of_interest_UserId",
                table: "point_of_interest",
                newName: "ix_point_of_interest_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_point_of_interest_PointOfInterestTypeId",
                table: "point_of_interest",
                newName: "ix_point_of_interest_point_of_interest_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user",
                table: "user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_point_of_interest_type",
                table: "point_of_interest_type",
                column: "point_of_interest_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_point_of_interest",
                table: "point_of_interest",
                column: "point_of_interest_id");

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
    }
}
