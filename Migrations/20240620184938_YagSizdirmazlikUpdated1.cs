using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class YagSizdirmazlikUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YakitSizdirmalik",
                table: "EkspertizSablonTable",
                newName: "YakitSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmalik",
                table: "EkspertizSablonTable",
                newName: "YagSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "ntsi_YakitSizdirmalik",
                table: "Deneme2s",
                newName: "ntsi_YakitSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "ntsi_YagSizdirmalik",
                table: "Deneme2s",
                newName: "ntsi_YagSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "YakitSizdirmalik",
                table: "Deneme2s",
                newName: "YakitSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmalik",
                table: "Deneme2s",
                newName: "YagSizdirmazlik");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YakitSizdirmazlik",
                table: "EkspertizSablonTable",
                newName: "YakitSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmazlik",
                table: "EkspertizSablonTable",
                newName: "YagSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "ntsi_YakitSizdirmazlik",
                table: "Deneme2s",
                newName: "ntsi_YakitSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "ntsi_YagSizdirmazlik",
                table: "Deneme2s",
                newName: "ntsi_YagSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "YakitSizdirmazlik",
                table: "Deneme2s",
                newName: "YakitSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmazlik",
                table: "Deneme2s",
                newName: "YagSizdirmalik");
        }
    }
}
