using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokrocily_zaverecny_projekt.Data.Migrations
{
    public partial class Vytvoreni_Pojisteni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Insured",
                type: "nvarchar(60)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Insured",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Insured",
                type: "nvarchar(60)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PSC",
                table: "Insured",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Insured",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "Insured",
                type: "nvarchar(60)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    InsuredId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    InsurenceObject = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Insured");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Insured");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Insured");

            migrationBuilder.DropColumn(
                name: "PSC",
                table: "Insured");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Insured");

            migrationBuilder.DropColumn(
                name: "Town",
                table: "Insured");
        }
    }
}
