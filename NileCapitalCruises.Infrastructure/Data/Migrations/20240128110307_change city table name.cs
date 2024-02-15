using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class changecitytablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_CruiseBooking_Cities_CityId",
                table: "tbl_CruiseBooking_Cities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityFromId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityToId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Cities_EmbarcationCityId",
                table: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailFrom",
                table: "tbl_Master_Itineraries_Types");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailTo",
                table: "tbl_Master_Itineraries_Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cities_Contents",
                table: "tbl_CruiseBooking_Cities_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cities",
                table: "tbl_CruiseBooking_Cities");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Cities_Contents",
                newName: "tbl_Master_Cities_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_CruiseBooking_Cities",
                newName: "tbl_Master_Cities");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Cities_Contents_LanguageId",
                table: "tbl_Master_Cities_Contents",
                newName: "IX_tbl_Master_Cities_Contents_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Cities_Contents_CityId",
                table: "tbl_Master_Cities_Contents",
                newName: "IX_tbl_Master_Cities_Contents_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Cities_Contents",
                table: "tbl_Master_Cities_Contents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Master_Cities",
                table: "tbl_Master_Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Cities_CityFromId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityFromId",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Cities_CityToId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityToId",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_Master_Cities_EmbarcationCityId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "EmbarcationCityId",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Cities_Contents_tbl_Master_Cities_CityId",
                table: "tbl_Master_Cities_Contents",
                column: "CityId",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Cities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Cities_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_Master_Cities_SailFrom",
                table: "tbl_Master_Itineraries_Types",
                column: "SailFrom",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_Master_Cities_SailTo",
                table: "tbl_Master_Itineraries_Types",
                column: "SailTo",
                principalTable: "tbl_Master_Cities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Cities_CityFromId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Cities_CityToId",
                table: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_Master_Cities_EmbarcationCityId",
                table: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Cities_Contents_tbl_Master_Cities_CityId",
                table: "tbl_Master_Cities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Cities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_Master_Cities_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_Master_Cities_SailFrom",
                table: "tbl_Master_Itineraries_Types");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_Master_Cities_SailTo",
                table: "tbl_Master_Itineraries_Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Cities_Contents",
                table: "tbl_Master_Cities_Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Master_Cities",
                table: "tbl_Master_Cities");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Cities_Contents",
                newName: "tbl_CruiseBooking_Cities_Contents");

            migrationBuilder.RenameTable(
                name: "tbl_Master_Cities",
                newName: "tbl_CruiseBooking_Cities");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Cities_Contents_LanguageId",
                table: "tbl_CruiseBooking_Cities_Contents",
                newName: "IX_tbl_CruiseBooking_Cities_Contents_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Master_Cities_Contents_CityId",
                table: "tbl_CruiseBooking_Cities_Contents",
                newName: "IX_tbl_CruiseBooking_Cities_Contents_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cities_Contents",
                table: "tbl_CruiseBooking_Cities_Contents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CruiseBooking_Cities",
                table: "tbl_CruiseBooking_Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_CruiseBooking_Cities_CityId",
                table: "tbl_CruiseBooking_Cities_Contents",
                column: "CityId",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cities_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityFromId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityFromId",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityToId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityToId",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Cities_EmbarcationCityId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "EmbarcationCityId",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailFrom",
                table: "tbl_Master_Itineraries_Types",
                column: "SailFrom",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailTo",
                table: "tbl_Master_Itineraries_Types",
                column: "SailTo",
                principalTable: "tbl_CruiseBooking_Cities",
                principalColumn: "Id");
        }
    }
}
