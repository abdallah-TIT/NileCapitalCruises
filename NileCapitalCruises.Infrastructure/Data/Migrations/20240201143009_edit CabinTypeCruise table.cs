using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editCabinTypeCruisetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaximumAdults",
                table: "tbl_CruiseBooking_CabinTypes_Cruises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaximumChildren",
                table: "tbl_CruiseBooking_CabinTypes_Cruises",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumAdults",
                table: "tbl_CruiseBooking_CabinTypes_Cruises");

            migrationBuilder.DropColumn(
                name: "MaximumChildren",
                table: "tbl_CruiseBooking_CabinTypes_Cruises");
        }
    }
}
