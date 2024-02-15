using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditAmenitytableforforiegnkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenitiesId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Master_Amenities_Contents_AmenitiesId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.DropColumn(
                name: "AmenitiesId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.RenameColumn(
                name: "OriginalTableId",
                table: "tbl_Master_Amenities_Contents",
                newName: "AmenityId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenityId",
                table: "tbl_Master_Amenities_Contents",
                column: "AmenityId",
                principalTable: "tbl_Master_Amenities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenityId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.RenameColumn(
                name: "AmenityId",
                table: "tbl_Master_Amenities_Contents",
                newName: "OriginalTableId");

            migrationBuilder.AddColumn<int>(
                name: "AmenitiesId",
                table: "tbl_Master_Amenities_Contents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Amenities_Contents_AmenitiesId",
                table: "tbl_Master_Amenities_Contents",
                column: "AmenitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenitiesId",
                table: "tbl_Master_Amenities_Contents",
                column: "AmenitiesId",
                principalTable: "tbl_Master_Amenities",
                principalColumn: "Id");
        }
    }
}
