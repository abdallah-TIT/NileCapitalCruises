using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class addContentLangStatustoPeriodContenttb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tbl_Master_Languages",
                newName: "LangStatus");

            migrationBuilder.AddColumn<bool>(
                name: "ContentLangStatus",
                table: "tbl_CruiseBooking_Periods_Contents",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentLangStatus",
                table: "tbl_CruiseBooking_Periods_Contents");

            migrationBuilder.RenameColumn(
                name: "LangStatus",
                table: "tbl_Master_Languages",
                newName: "Status");
        }
    }
}
