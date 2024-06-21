using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class YeniAracModeli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracKm",
                table: "VehicleModelss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriAd",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "VehicleModelss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ucret",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "VehicleModelss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Yil",
                table: "VehicleModelss",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "MusteriAd",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "VehicleModelss");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "VehicleModelss");
        }
    }
}
