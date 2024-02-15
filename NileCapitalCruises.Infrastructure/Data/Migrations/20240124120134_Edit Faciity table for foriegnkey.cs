using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditFaciitytableforforiegnkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacilitiyId",
                table: "tbl_CruiseBooking_Cruises_Facilties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacilitiyId",
                table: "tbl_CruiseBooking_Cruises_Facilties",
                type: "int",
                nullable: true);
        }
    }
}
