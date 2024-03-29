﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class AddDiningTypeUrltoDiningType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiningTypeUrl",
                table: "tbl_CruiseBooking_Dinings_Types",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiningTypeUrl",
                table: "tbl_CruiseBooking_Dinings_Types");
        }
    }
}
