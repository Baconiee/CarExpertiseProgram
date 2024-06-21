using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class YagSizdirmalikUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YagSizdirmazlik",
                table: "EkspertizSablonTable",
                newName: "YagSizdirmalik");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YagSizdirmalik",
                table: "EkspertizSablonTable",
                newName: "YagSizdirmazlik");
        }
    }
}
