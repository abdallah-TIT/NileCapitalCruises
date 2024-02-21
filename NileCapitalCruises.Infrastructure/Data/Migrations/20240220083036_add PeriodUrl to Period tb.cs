using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class addPeriodUrltoPeriodtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PeriodUrl",
                table: "tbl_CruiseBooking_Periods",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodUrl",
                table: "tbl_CruiseBooking_Periods");
        }
    }
}
