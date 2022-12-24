using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PerfectHomeLocation.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PointOfInterestTypes",
                columns: table => new
                {
                    PointOfInterestTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PointOfInterestTypeId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointOfInterestTypes", x => x.PointOfInterestTypeId);
                    table.ForeignKey(
                        name: "FK_PointOfInterestTypes_PointOfInterestTypes_PointOfInterestTy~",
                        column: x => x.PointOfInterestTypeId1,
                        principalTable: "PointOfInterestTypes",
                        principalColumn: "PointOfInterestTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PointsOfInterest",
                columns: table => new
                {
                    PointOfInterestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FriendlyName = table.Column<string>(type: "text", nullable: false),
                    SearchPhrase = table.Column<string>(type: "text", nullable: false),
                    PointOfInterestTypeId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsOfInterest", x => x.PointOfInterestId);
                    table.ForeignKey(
                        name: "FK_PointsOfInterest_PointOfInterestTypes_PointOfInterestTypeId",
                        column: x => x.PointOfInterestTypeId,
                        principalTable: "PointOfInterestTypes",
                        principalColumn: "PointOfInterestTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PointsOfInterest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointOfInterestTypes_PointOfInterestTypeId1",
                table: "PointOfInterestTypes",
                column: "PointOfInterestTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_PointOfInterestTypeId",
                table: "PointsOfInterest",
                column: "PointOfInterestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_UserId",
                table: "PointsOfInterest",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointsOfInterest");

            migrationBuilder.DropTable(
                name: "PointOfInterestTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
