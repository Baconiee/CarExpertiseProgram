using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class Deneme1Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracKm",
                table: "Deneme1s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
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

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Deneme1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ucret",
                table: "Deneme1s",
                type: "nvarchar(max)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "Deneme1s");

            migrationBuilder.DropColumn(
                name: "Telefon",
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
        }
    }
}
