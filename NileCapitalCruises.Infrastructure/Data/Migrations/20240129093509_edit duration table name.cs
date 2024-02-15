using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editdurationtablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Durations_DurationId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Durations",
                table: "tbl_CruiseBooking_Durations");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Durations",
                newName: "tbl_Master_Durations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Durations",
                table: "tbl_Master_Durations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Durations_DurationId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "DurationId",
                principalTable: "tbl_Master_Durations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Durations_DurationId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Durations",
                table: "tbl_Master_Durations");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Durations",
                newName: "tbl_CruiseBooking_Durations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Durations",
                table: "tbl_CruiseBooking_Durations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Durations_DurationId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "DurationId",
                principalTable: "tbl_CruiseBooking_Durations",
                principalColumn: "Id");
        }
    }
}
