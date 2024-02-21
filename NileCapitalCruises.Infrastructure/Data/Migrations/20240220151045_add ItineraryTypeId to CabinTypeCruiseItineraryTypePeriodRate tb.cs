using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class addItineraryTypeIdtoCabinTypeCruiseItineraryTypePeriodRatetb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    PeriodId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeCruiseId = table.Column<int>(type: "int", nullable: true),
                    ItineraryTypeId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeCruiseId",
                        column: x => x.CabinTypeCruiseId,
                        principalTable: "tbl_CruiseBooking_CabinTypes_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_tbl_CruiseBooking_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "tbl_CruiseBooking_Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_tbl_Master_Itineraries_Types_ItineraryTypeId",
                        column: x => x.ItineraryTypeId,
                        principalTable: "tbl_Master_Itineraries_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_CabinTypeCruiseId",
                table: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates",
                column: "CabinTypeCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_ItineraryTypeId",
                table: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates",
                column: "ItineraryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_PeriodId",
                table: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates_RateId",
                table: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates",
                column: "RateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeCruiseId = table.Column<int>(type: "int", nullable: true),
                    PeriodId = table.Column<int>(type: "int", nullable: true),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeCruiseId",
                        column: x => x.CabinTypeCruiseId,
                        principalTable: "tbl_CruiseBooking_CabinTypes_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "tbl_CruiseBooking_Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_CabinTypeCruiseId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "CabinTypeCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_PeriodId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_RateId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "RateId");
        }
    }
}
