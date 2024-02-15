using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditDiningNameSystoDiningNameinDiningContenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiningNameSys",
                table: "tbl_CruiseBooking_Dinings_Contents",
                newName: "DiningName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiningName",
                table: "tbl_CruiseBooking_Dinings_Contents",
                newName: "DiningNameSys");
        }
    }
}
