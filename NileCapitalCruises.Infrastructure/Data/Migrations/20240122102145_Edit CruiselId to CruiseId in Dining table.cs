using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditCruiselIdtoCruiseIdinDiningtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CruiselId",
                table: "tbl_CruiseBooking_Dinings");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_CruiseBooking_Dinings",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_CruiseBooking_Dinings");

            migrationBuilder.AddColumn<int>(
                name: "CruiselId",
                table: "tbl_CruiseBooking_Dinings",
                type: "int",
                nullable: true);
        }
    }
}
