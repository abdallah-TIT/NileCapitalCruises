using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class ChangeDiningTypeinDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Dinings_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                table: "tbl_CruiseBooking_Dinings");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_DiningTypes_Contents_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                table: "tbl_Master_DiningTypes_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Dinings_Types",
                table: "tbl_CruiseBooking_Dinings_Types");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Dinings_Types",
                newName: "tbl_Master_Dinings_Types");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Dinings_Types",
                table: "tbl_Master_Dinings_Types",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Dinings_tbl_Master_Dinings_Types_DiningTypeId",
                table: "tbl_CruiseBooking_Dinings",
                column: "DiningTypeId",
                principalTable: "tbl_Master_Dinings_Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_DiningTypes_Contents_tbl_Master_Dinings_Types_DiningTypeId",
                table: "tbl_Master_DiningTypes_Contents",
                column: "DiningTypeId",
                principalTable: "tbl_Master_Dinings_Types",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Dinings_tbl_Master_Dinings_Types_DiningTypeId",
                table: "tbl_CruiseBooking_Dinings");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_DiningTypes_Contents_tbl_Master_Dinings_Types_DiningTypeId",
                table: "tbl_Master_DiningTypes_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Dinings_Types",
                table: "tbl_Master_Dinings_Types");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Dinings_Types",
                newName: "tbl_CruiseBooking_Dinings_Types");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Dinings_Types",
                table: "tbl_CruiseBooking_Dinings_Types",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Dinings_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                table: "tbl_CruiseBooking_Dinings",
                column: "DiningTypeId",
                principalTable: "tbl_CruiseBooking_Dinings_Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_DiningTypes_Contents_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                table: "tbl_Master_DiningTypes_Contents",
                column: "DiningTypeId",
                principalTable: "tbl_CruiseBooking_Dinings_Types",
                principalColumn: "Id");
        }
    }
}
