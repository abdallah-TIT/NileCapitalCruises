using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class AddNumberOfRoomsfieldtoCabinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "tbl_CruiseBooking_Cabins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_CruiseBooking_Cabins",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "tbl_CruiseBooking_Cabins");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_CruiseBooking_Cabins");
        }
    }
}
