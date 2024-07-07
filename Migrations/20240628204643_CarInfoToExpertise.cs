using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class CarInfoToExpertise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AracKm",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AracMarkaId",
                table: "Deneme2s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Deneme2s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ucret",
                table: "Deneme2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yil",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AracMarkaId",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "Deneme2s");
        }
    }
}
