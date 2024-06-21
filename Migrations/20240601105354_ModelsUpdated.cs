using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "Deneme1s");

            migrationBuilder.CreateTable(
                name: "CarModelTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracPlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMarka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMarkaId = table.Column<int>(type: "int", nullable: false),
                    AracModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    YakitTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    AracKm = table.Column<int>(type: "int", nullable: false),
                    YedekAnahtar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ucret = table.Column<int>(type: "int", nullable: true),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModelTable");

            migrationBuilder.AddColumn<int>(
                name: "AracKm",
                table: "Deneme1s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Deneme1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ucret",
                table: "Deneme1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Yil",
                table: "Deneme1s",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
