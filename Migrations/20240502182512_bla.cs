using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class bla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "CustomerModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
