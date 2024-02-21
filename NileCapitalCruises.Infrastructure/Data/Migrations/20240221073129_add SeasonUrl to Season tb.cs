using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class addSeasonUrltoSeasontb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeasonUrl",
                table: "tbl_CruiseBooking_Seasons",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeasonUrl",
                table: "tbl_CruiseBooking_Seasons");
        }
    }
}
