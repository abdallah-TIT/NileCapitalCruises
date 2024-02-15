using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class removefacilitytypetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Facilties_tbl_CruiseBooking_Facilities_Types_FacilityTypeId",
                table: "tbl_Master_Facilties");

            migrationBuilder.DropTable(
                name: "tbl_Master_Facilities_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Facilities_Types");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Master_Facilties_FacilityTypeId",
                table: "tbl_Master_Facilties");

            migrationBuilder.DropColumn(
                name: "FacilityTypeId",
                table: "tbl_Master_Facilties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacilityTypeId",
                table: "tbl_Master_Facilties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Facilities_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Facilities_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Facilities_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: true),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Facilities_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilities_Types_Contents_tbl_CruiseBooking_Facilities_Types_FacilityTypeId",
                        column: x => x.FacilityTypeId,
                        principalTable: "tbl_CruiseBooking_Facilities_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilities_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilties_FacilityTypeId",
                table: "tbl_Master_Facilties",
                column: "FacilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilities_Types_Contents_FacilityTypeId",
                table: "tbl_Master_Facilities_Types_Contents",
                column: "FacilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilities_Types_Contents_LanguageId",
                table: "tbl_Master_Facilities_Types_Contents",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Facilties_tbl_CruiseBooking_Facilities_Types_FacilityTypeId",
                table: "tbl_Master_Facilties",
                column: "FacilityTypeId",
                principalTable: "tbl_CruiseBooking_Facilities_Types",
                principalColumn: "Id");
        }
    }
}
