using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class AddDiningContenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiningDescription",
                table: "tbl_CruiseBooking_Dinings");

            migrationBuilder.RenameColumn(
                name: "DiningName",
                table: "tbl_CruiseBooking_Dinings",
                newName: "DiningNameSys");

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Dinings_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiningId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    DiningNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DiningDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Dinings_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Dinings_Contents_tbl_CruiseBooking_Dinings_DiningId",
                        column: x => x.DiningId,
                        principalTable: "tbl_CruiseBooking_Dinings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Dinings_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Dinings_Content_DiningId",
                table: "tbl_CruiseBooking_Dinings_Contents",
                column: "DiningId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Dinings_Content_LangId",
                table: "tbl_CruiseBooking_Dinings_Contents",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Dinings_Contents");

            migrationBuilder.RenameColumn(
                name: "DiningNameSys",
                table: "tbl_CruiseBooking_Dinings",
                newName: "DiningName");

            migrationBuilder.AddColumn<string>(
                name: "DiningDescription",
                table: "tbl_CruiseBooking_Dinings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
