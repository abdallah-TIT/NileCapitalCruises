using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditAmenitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmenitiesStatus",
                table: "tbl_Master_Amenities");

            migrationBuilder.RenameColumn(
                name: "AmenitiesName",
                table: "tbl_Master_Amenities_Contents",
                newName: "AmenityName");

            migrationBuilder.RenameColumn(
                name: "AmenitiesPosition",
                table: "tbl_Master_Amenities",
                newName: "AmenityPosition");

            migrationBuilder.RenameColumn(
                name: "AmenitiesNameSys",
                table: "tbl_Master_Amenities",
                newName: "AmenityNameSys");

            migrationBuilder.RenameColumn(
                name: "AmenitiesIconWidth",
                table: "tbl_Master_Amenities",
                newName: "AmenityIconWidth");

            migrationBuilder.RenameColumn(
                name: "AmenitiesIconHeight",
                table: "tbl_Master_Amenities",
                newName: "AmenityIconHeight");

            migrationBuilder.RenameColumn(
                name: "AmenitiesIcon",
                table: "tbl_Master_Amenities",
                newName: "AmenityIcon");

            migrationBuilder.AddColumn<string>(
                name: "AmenityUrl",
                table: "tbl_Master_Amenities",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmenityUrl",
                table: "tbl_Master_Amenities");

            migrationBuilder.RenameColumn(
                name: "AmenityName",
                table: "tbl_Master_Amenities_Contents",
                newName: "AmenitiesName");

            migrationBuilder.RenameColumn(
                name: "AmenityPosition",
                table: "tbl_Master_Amenities",
                newName: "AmenitiesPosition");

            migrationBuilder.RenameColumn(
                name: "AmenityNameSys",
                table: "tbl_Master_Amenities",
                newName: "AmenitiesNameSys");

            migrationBuilder.RenameColumn(
                name: "AmenityIconWidth",
                table: "tbl_Master_Amenities",
                newName: "AmenitiesIconWidth");

            migrationBuilder.RenameColumn(
                name: "AmenityIconHeight",
                table: "tbl_Master_Amenities",
                newName: "AmenitiesIconHeight");

            migrationBuilder.RenameColumn(
                name: "AmenityIcon",
                table: "tbl_Master_Amenities",
                newName: "AmenitiesIcon");

            migrationBuilder.AddColumn<bool>(
                name: "AmenitiesStatus",
                table: "tbl_Master_Amenities",
                type: "bit",
                nullable: true);
        }
    }
}
