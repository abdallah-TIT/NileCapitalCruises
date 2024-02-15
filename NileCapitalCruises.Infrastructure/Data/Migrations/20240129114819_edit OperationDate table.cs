using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editOperationDatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "tbl_CruiseBooking_OperationDates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationDateUrl",
                table: "tbl_CruiseBooking_OperationDates",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_CompanyId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Companies_CompanyId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "CompanyId",
                principalTable: "tbl_CruiseBooking_Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Companies_CompanyId",
                table: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_CompanyId",
                table: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropColumn(
                name: "OperationDateUrl",
                table: "tbl_CruiseBooking_OperationDates");
        }
    }
}
