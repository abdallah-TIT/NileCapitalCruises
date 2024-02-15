using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editsometables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_OperationDates");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_OperationDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDateId = table.Column<int>(type: "int", nullable: false),
                    CabinTypeCruiseId = table.Column<int>(type: "int", nullable: false),
                    Allotment = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypesCruises_OperationDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_OperationDates_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeCruiseId",
                        column: x => x.CabinTypeCruiseId,
                        principalTable: "tbl_CruiseBooking_CabinTypes_Cruises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_OperationDates_tbl_CruiseBooking_OperationDates_OperationDateId",
                        column: x => x.OperationDateId,
                        principalTable: "tbl_CruiseBooking_OperationDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeCruiseId = table.Column<int>(type: "int", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoPosition = table.Column<int>(type: "int", nullable: true),
                    PhotoStatus = table.Column<bool>(type: "bit", nullable: true),
                    PhotoHieght = table.Column<int>(type: "int", nullable: true),
                    PhotoWidth = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypesCruises_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Photos_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeCruiseId",
                        column: x => x.CabinTypeCruiseId,
                        principalTable: "tbl_CruiseBooking_CabinTypes_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_OperationDates_CabinTypeCruiseId",
                table: "tbl_CruiseBooking_CabinTypesCruises_OperationDates",
                column: "CabinTypeCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_OperationDates_OperationDateId",
                table: "tbl_CruiseBooking_CabinTypesCruises_OperationDates",
                column: "OperationDateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Photos_CabinTypeCruiseId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Photos",
                column: "CabinTypeCruiseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_OperationDates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Photos");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_OperationDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeId = table.Column<int>(type: "int", nullable: false),
                    OperationDateId = table.Column<int>(type: "int", nullable: false),
                    Allotment = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_OperationDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_OperationDates_tbl_CruiseBooking_OperationDates_OperationDateId",
                        column: x => x.OperationDateId,
                        principalTable: "tbl_CruiseBooking_OperationDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_OperationDates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_OperationDates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_OperationDates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_OperationDates_OperationDateId",
                table: "tbl_CruiseBooking_CabinTypes_OperationDates",
                column: "OperationDateId");
        }
    }
}
