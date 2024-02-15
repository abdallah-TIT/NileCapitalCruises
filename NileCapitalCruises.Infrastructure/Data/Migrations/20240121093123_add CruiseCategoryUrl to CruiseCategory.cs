using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class addCruiseCategoryUrltoCruiseCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CruiseCategoryUrl",
                table: "tbl_CruiseBooking_Cruises_Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CruiseCategoryUrl",
                table: "tbl_CruiseBooking_Cruises_Categories");
        }
    }
}
