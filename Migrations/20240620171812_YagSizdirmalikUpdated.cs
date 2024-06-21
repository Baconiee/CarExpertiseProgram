using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class YagSizdirmalikUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ntsi_YagSizdirmazlik",
                table: "Deneme2s",
                newName: "ntsi_YagSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmazlik",
                table: "Deneme2s",
                newName: "YagSizdirmalik");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ntsi_YagSizdirmalik",
                table: "Deneme2s",
                newName: "ntsi_YagSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "YagSizdirmalik",
                table: "Deneme2s",
                newName: "YagSizdirmazlik");
        }
    }
}
