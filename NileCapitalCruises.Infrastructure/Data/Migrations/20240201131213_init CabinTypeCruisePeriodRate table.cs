using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class initCabinTypeCruisePeriodRatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Periods_tbl_Master_Periods_Types_PeriodTypeId",
                table: "tbl_CruiseBooking_Periods");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_StandardRates_StandardRateId",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_StandardRates_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Periods_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_StandardRates");

            migrationBuilder.DropTable(
                name: "tbl_Master_Periods_Types");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CruiseBooking_Periods_PeriodTypeId",
                table: "tbl_CruiseBooking_Periods");

            migrationBuilder.DropColumn(
                name: "PeriodTypeId",
                table: "tbl_CruiseBooking_Periods");

            migrationBuilder.RenameColumn(
                name: "StandardRateId",
                table: "tbl_CruiseBooking_Rates",
                newName: "ParentRateId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Rates_StandardRateId",
                table: "tbl_CruiseBooking_Rates",
                newName: "IX_tbl_CruiseBooking_Rates_ParentRateId");

            migrationBuilder.AddColumn<bool>(
                name: "IsPercentage",
                table: "tbl_CruiseBooking_Rates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPositiveSign",
                table: "tbl_CruiseBooking_Rates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Percentage",
                table: "tbl_CruiseBooking_Rates",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "tbl_CruiseBooking_Rates",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    PeriodId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeCruiseId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_CabinTypes_Cruises_CabinTypeCruiseId",
                        column: x => x.CabinTypeCruiseId,
                        principalTable: "tbl_CruiseBooking_CabinTypes_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "tbl_CruiseBooking_Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_CabinTypeCruiseId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "CabinTypeCruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_PeriodId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypesCruises_Periods_Rates_RateId",
                table: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates",
                column: "RateId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_Rates_ParentRateId",
                table: "tbl_CruiseBooking_Rates",
                column: "ParentRateId",
                principalTable: "tbl_CruiseBooking_Rates",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_Rates_ParentRateId",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypesCruises_Periods_Rates");

            migrationBuilder.DropColumn(
                name: "IsPercentage",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropColumn(
                name: "IsPositiveSign",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropColumn(
                name: "Percentage",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "tbl_CruiseBooking_Rates");

            migrationBuilder.RenameColumn(
                name: "ParentRateId",
                table: "tbl_CruiseBooking_Rates",
                newName: "StandardRateId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_CruiseBooking_Rates_ParentRateId",
                table: "tbl_CruiseBooking_Rates",
                newName: "IX_tbl_CruiseBooking_Rates_StandardRateId");

            migrationBuilder.AddColumn<int>(
                name: "PeriodTypeId",
                table: "tbl_CruiseBooking_Periods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_StandardRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    StandardRateNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_StandardRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Periods_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    PeriodTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Periods_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_StandardRates_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    StandardRateId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    StandardRateName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_StandardRates_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_Contents_tbl_CruiseBooking_StandardRates_StandardRateId",
                        column: x => x.StandardRateId,
                        principalTable: "tbl_CruiseBooking_StandardRates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    CabinPriceDouble = table.Column<float>(type: "real", nullable: true),
                    CabinPriceSingle = table.Column<float>(type: "real", nullable: true),
                    CabinPriceTriple = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: true),
                    IsPositiveSign = table.Column<bool>(type: "bit", nullable: true),
                    Percentage = table.Column<float>(type: "real", nullable: true),
                    Value = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_Master_Periods_Types_PeriodTypeId",
                        column: x => x.PeriodTypeId,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    StandardRateId = table.Column<int>(type: "int", nullable: true),
                    CabinPrice = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_CruiseBooking_StandardRates_StandardRateId",
                        column: x => x.StandardRateId,
                        principalTable: "tbl_CruiseBooking_StandardRates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_Master_Periods_Types_PeriodTypeId",
                        column: x => x.PeriodTypeId,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Periods_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeId1 = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Periods_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_Contents_tbl_Master_Periods_Types_PeriodTypeId1",
                        column: x => x.PeriodTypeId1,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_PeriodTypeId",
                table: "tbl_CruiseBooking_Periods",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_PeriodTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_RateId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_PeriodTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_StandardRateId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "StandardRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_CruiseId",
                table: "tbl_CruiseBooking_StandardRates",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_Contents_LanguageId",
                table: "tbl_CruiseBooking_StandardRates_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_Contents_StandardRateId",
                table: "tbl_CruiseBooking_StandardRates_Contents",
                column: "StandardRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_Types_CruiseId",
                table: "tbl_Master_Periods_Types",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_LanguageId",
                table: "tbl_Master_Periods_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_PeriodTypeId",
                table: "tbl_Master_Periods_Types_Contents",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_PeriodTypeId1",
                table: "tbl_Master_Periods_Types_Contents",
                column: "PeriodTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Periods_tbl_Master_Periods_Types_PeriodTypeId",
                table: "tbl_CruiseBooking_Periods",
                column: "PeriodTypeId",
                principalTable: "tbl_Master_Periods_Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_StandardRates_StandardRateId",
                table: "tbl_CruiseBooking_Rates",
                column: "StandardRateId",
                principalTable: "tbl_CruiseBooking_StandardRates",
                principalColumn: "Id");
        }
    }
}
