using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditCabinCategoryTypeNameSystoCabinTypeNameSysinCabinTypetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CabinCategoryTypeNameSys",
                table: "tbl_Master_Cabins_Types",
                newName: "CabinTypeNameSys");

            migrationBuilder.AddColumn<string>(
                name: "CabinTypeUrl",
                table: "tbl_Master_Cabins_Types",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CabinTypeUrl",
                table: "tbl_Master_Cabins_Types");

            migrationBuilder.RenameColumn(
                name: "CabinTypeNameSys",
                table: "tbl_Master_Cabins_Types",
                newName: "CabinCategoryTypeNameSys");
        }
    }
}
