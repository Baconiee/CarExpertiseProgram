using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class BakBakalim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracKm",
                table: "Trys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AracMarkaId",
                table: "Trys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriAd",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Trys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ucret",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "Trys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Yil",
                table: "Trys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "AracMarkaId",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "MusteriAd",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "Trys");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "Trys");
        }
    }
}
