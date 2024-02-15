using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class initCabinTypeCruisetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Contents_tbl_CruiseBooking_Itineraries_ItineraryId",
                table: "tbl_Master_Itineraries_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Itineraries_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Itineraries_Contents",
                table: "tbl_Master_Itineraries_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Itineraries_Contents",
                newName: "tbl_CruiseBooking_Itineraries_Contents");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Itineraries_Contents_LanguageId",
                table: "tbl_CruiseBooking_Itineraries_Contents",
                newName: "IX_tbl_CruiseBooking_Itineraries_Contents_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Itineraries_Contents_ItineraryId",
                table: "tbl_CruiseBooking_Itineraries_Contents",
                newName: "IX_tbl_CruiseBooking_Itineraries_Contents_ItineraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Itineraries_Contents",
                table: "tbl_CruiseBooking_Itineraries_Contents",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_Cruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: true),
                    Occupancy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_Cruises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_Cruises_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_Cruises_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_Cruises",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_Cruises_CruiseId",
                table: "tbl_CruiseBooking_CabinTypes_Cruises",
                column: "CruiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_Contents_tbl_CruiseBooking_Itineraries_ItineraryId",
                table: "tbl_CruiseBooking_Itineraries_Contents",
                column: "ItineraryId",
                principalTable: "tbl_CruiseBooking_Itineraries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Itineraries_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_Contents_tbl_CruiseBooking_Itineraries_ItineraryId",
                table: "tbl_CruiseBooking_Itineraries_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Itineraries_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_Cruises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Itineraries_Contents",
                table: "tbl_CruiseBooking_Itineraries_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Itineraries_Contents",
                newName: "tbl_Master_Itineraries_Contents");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Contents_LanguageId",
                table: "tbl_Master_Itineraries_Contents",
                newName: "IX_tbl_Master_Itineraries_Contents_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Contents_ItineraryId",
                table: "tbl_Master_Itineraries_Contents",
                newName: "IX_tbl_Master_Itineraries_Contents_ItineraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Itineraries_Contents",
                table: "tbl_Master_Itineraries_Contents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Contents_tbl_CruiseBooking_Itineraries_ItineraryId",
                table: "tbl_Master_Itineraries_Contents",
                column: "ItineraryId",
                principalTable: "tbl_CruiseBooking_Itineraries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Itineraries_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");
        }
    }
}
