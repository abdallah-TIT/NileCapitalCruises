using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editItinerarytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItineraryNameSys",
                table: "tbl_CruiseBooking_Itineraries",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItineraryUrl",
                table: "tbl_CruiseBooking_Itineraries",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItineraryNameSys",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropColumn(
                name: "ItineraryUrl",
                table: "tbl_CruiseBooking_Itineraries");
        }
    }
}
