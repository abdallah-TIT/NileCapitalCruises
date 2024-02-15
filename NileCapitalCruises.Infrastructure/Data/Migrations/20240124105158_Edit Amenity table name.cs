using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class EditAmenitytablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_CruiseBooking_Amenities_AmenitiesId",
                table: "tbl_CruiseBooking_Amenities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Amenities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_CruiseBooking_Amenities_AmenityId",
                table: "tbl_CruiseBooking_Cabins_Amenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Amenities_Contents",
                table: "tbl_CruiseBooking_Amenities_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Amenities",
                table: "tbl_CruiseBooking_Amenities");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Amenities_Contents",
                newName: "tbl_Master_Amenities_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Amenities",
                newName: "tbl_Master_Amenities");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Contents_AmenitiesId",
                table: "tbl_Master_Amenities_Contents",
                newName: "IX_tbl_Master_Amenities_Contents_AmenitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Content_LangId",
                table: "tbl_Master_Amenities_Contents",
                newName: "IX_tbl_Master_Amenities_Content_LangId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Content_AmenityId",
                table: "tbl_Master_Amenities_Contents",
                newName: "IX_tbl_Master_Amenities_Content_AmenityId");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_Master_Amenities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Amenities_Contents",
                table: "tbl_Master_Amenities_Contents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Amenities",
                table: "tbl_Master_Amenities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_Master_Amenities_AmenityId",
                table: "tbl_CruiseBooking_Cabins_Amenities",
                column: "AmenityId",
                principalTable: "tbl_Master_Amenities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenitiesId",
                table: "tbl_Master_Amenities_Contents",
                column: "AmenitiesId",
                principalTable: "tbl_Master_Amenities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Amenities_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_Master_Amenities_AmenityId",
                table: "tbl_CruiseBooking_Cabins_Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Amenities_AmenitiesId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Amenities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Amenities_Contents",
                table: "tbl_Master_Amenities_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Amenities",
                table: "tbl_Master_Amenities");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_Master_Amenities");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Amenities_Contents",
                newName: "tbl_CruiseBooking_Amenities_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Amenities",
                newName: "tbl_CruiseBooking_Amenities");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Amenities_Contents_AmenitiesId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                newName: "IX_tbl_CruiseBooking_Amenities_Contents_AmenitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Amenities_Content_LangId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                newName: "IX_tbl_CruiseBooking_Amenities_Content_LangId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Amenities_Content_AmenityId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                newName: "IX_tbl_CruiseBooking_Amenities_Content_AmenityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Amenities_Contents",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Amenities",
                table: "tbl_CruiseBooking_Amenities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_CruiseBooking_Amenities_AmenitiesId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "AmenitiesId",
                principalTable: "tbl_CruiseBooking_Amenities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_CruiseBooking_Amenities_AmenityId",
                table: "tbl_CruiseBooking_Cabins_Amenities",
                column: "AmenityId",
                principalTable: "tbl_CruiseBooking_Amenities",
                principalColumn: "Id");
        }
    }
}
