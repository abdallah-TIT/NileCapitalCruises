using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class initItineraryDayandItineraryPhototables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ContentLangStatus",
                table: "tbl_Master_Itineraries_Types_Contents",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Itineraries_Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNumber = table.Column<int>(type: "int", nullable: true),
                    WeekDayId = table.Column<int>(type: "int", nullable: true),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Itineraries_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_Days_tbl_CruiseBooking_Itineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "tbl_CruiseBooking_Itineraries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_Days_tbl_Master_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "tbl_Master_WeekDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Itineraries_Days_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DayDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ItineraryDayId = table.Column<int>(type: "int", nullable: true),
                    ItineraryTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Itineraries_Days_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_Days_Contents_tbl_Master_Itineraries_Types_ItineraryTypeId",
                        column: x => x.ItineraryTypeId,
                        principalTable: "tbl_Master_Itineraries_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_Days_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Itineraries_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoPosition = table.Column<int>(type: "int", nullable: true),
                    PhotoStatus = table.Column<bool>(type: "bit", nullable: true),
                    PhotoHieght = table.Column<int>(type: "int", nullable: true),
                    PhotoWidth = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Itineraries_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_Photos_tbl_CruiseBooking_Itineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "tbl_CruiseBooking_Itineraries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Days_ItineraryId",
                table: "tbl_CruiseBooking_Itineraries_Days",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Days_WeekDayId",
                table: "tbl_CruiseBooking_Itineraries_Days",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Days_Contents_ItineraryDayId",
                table: "tbl_CruiseBooking_Itineraries_Days_Contents",
                column: "ItineraryDayId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Days_Contents_ItineraryTypeId",
                table: "tbl_CruiseBooking_Itineraries_Days_Contents",
                column: "ItineraryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Days_Contents_LanguageId",
                table: "tbl_CruiseBooking_Itineraries_Days_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_Photos_ItineraryId",
                table: "tbl_CruiseBooking_Itineraries_Photos",
                column: "ItineraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Itineraries_Days");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Itineraries_Days_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Itineraries_Photos");

            migrationBuilder.DropColumn(
                name: "ContentLangStatus",
                table: "tbl_Master_Itineraries_Types_Contents");
        }
    }
}
