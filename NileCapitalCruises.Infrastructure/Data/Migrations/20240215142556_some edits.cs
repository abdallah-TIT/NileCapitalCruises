using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class someedits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_CruiseBooking_Brands_BrandId",
                table: "tbl_CruiseBooking_Brands_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents");

            migrationBuilder.RenameColumn(
                name: "LangStatus",
                table: "tbl_Master_Languages",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "tbl_CruiseBooking_Brands_Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_CruiseBooking_Brands_BrandId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "BrandId",
                principalTable: "tbl_CruiseBooking_Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "CruiseCategoryId",
                principalTable: "tbl_CruiseBooking_Cruises_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_CruiseBooking_Brands_BrandId",
                table: "tbl_CruiseBooking_Brands_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tbl_Master_Languages",
                newName: "LangStatus");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "tbl_CruiseBooking_Brands_Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_CruiseBooking_Brands_BrandId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "BrandId",
                principalTable: "tbl_CruiseBooking_Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "CruiseCategoryId",
                principalTable: "tbl_CruiseBooking_Cruises_Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_Master_Languages_LanguageId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "LanguageId",
                principalTable: "tbl_Master_Languages",
                principalColumn: "Id");
        }
    }
}
