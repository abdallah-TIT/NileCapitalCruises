using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class RemoveFacilitiyIdfromCruiseFacility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Cruises_Facilties_tbl_CruiseBooking_Cruises_CruiseId",
                table: "tbl_Master_Cruises_Facilties");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Cruises_Facilties_tbl_Master_Facilties_FacilityId",
                table: "tbl_Master_Cruises_Facilties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Cruises_Facilties",
                table: "tbl_Master_Cruises_Facilties");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Cruises_Facilties",
                newName: "tbl_CruiseBooking_Cruises_Facilties");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Cruises_Facilties_FacilityId",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                newName: "IX_tbl_CruiseBooking_Cruises_Facilties_FacilityId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Cruises_Facilties_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                newName: "IX_tbl_CruiseBooking_Cruises_Facilties_CruiseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cruises_Facilties",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Facilties_tbl_CruiseBooking_Cruises_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                column: "CruiseId",
                principalTable: "tbl_CruiseBooking_Cruises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Facilties_tbl_Master_Facilties_FacilityId",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                column: "FacilityId",
                principalTable: "tbl_Master_Facilties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Facilties_tbl_CruiseBooking_Cruises_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Facilties");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Facilties_tbl_Master_Facilties_FacilityId",
                table: "tbl_CruiseBooking_Cruises_Facilties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cruises_Facilties",
                table: "tbl_CruiseBooking_Cruises_Facilties");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Cruises_Facilties",
                newName: "tbl_Master_Cruises_Facilties");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Facilties_FacilityId",
                table: "tbl_Master_Cruises_Facilties",
                newName: "IX_tbl_Master_Cruises_Facilties_FacilityId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Facilties_CruiseId",
                table: "tbl_Master_Cruises_Facilties",
                newName: "IX_tbl_Master_Cruises_Facilties_CruiseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Cruises_Facilties",
                table: "tbl_Master_Cruises_Facilties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Cruises_Facilties_tbl_CruiseBooking_Cruises_CruiseId",
                table: "tbl_Master_Cruises_Facilties",
                column: "CruiseId",
                principalTable: "tbl_CruiseBooking_Cruises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Cruises_Facilties_tbl_Master_Facilties_FacilityId",
                table: "tbl_Master_Cruises_Facilties",
                column: "FacilityId",
                principalTable: "tbl_Master_Facilties",
                principalColumn: "Id");
        }
    }
}
