using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class editbrandTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_tbl_Master_Brands_Types_BrandTypeId",
                table: "tbl_CruiseBooking_Brands");

            migrationBuilder.DropTable(
                name: "tbl_Master_Brands_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Brands_Types");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CruiseBooking_Brands_BrandTypeId",
                table: "tbl_CruiseBooking_Brands");

            migrationBuilder.DropColumn(
                name: "BrandTypeId",
                table: "tbl_CruiseBooking_Brands");

            migrationBuilder.RenameColumn(
                name: "IsTravco",
                table: "tbl_CruiseBooking_Brands",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tbl_CruiseBooking_Brands",
                newName: "IsTravco");

            migrationBuilder.AddColumn<int>(
                name: "BrandTypeId",
                table: "tbl_CruiseBooking_Brands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Master_Brands_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Brands_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Brands_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    BrandTypeId = table.Column<int>(type: "int", nullable: true),
                    BrandTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Brands_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Brands_Types_Contents_tbl_Master_Brands_Types_BrandTypeId",
                        column: x => x.BrandTypeId,
                        principalTable: "tbl_Master_Brands_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Brands_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Brands_BrandTypeId",
                table: "tbl_CruiseBooking_Brands",
                column: "BrandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Brands_Types_Contents_BrandTypeId",
                table: "tbl_Master_Brands_Types_Contents",
                column: "BrandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Brands_Types_Contents_LanguageId",
                table: "tbl_Master_Brands_Types_Contents",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Brands_tbl_Master_Brands_Types_BrandTypeId",
                table: "tbl_CruiseBooking_Brands",
                column: "BrandTypeId",
                principalTable: "tbl_Master_Brands_Types",
                principalColumn: "Id");
        }
    }
}
