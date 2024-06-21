using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class VehicleTableReadyDemo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Trys");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Trys",
                newName: "AracModel");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trys",
                newName: "AracMarka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AracModel",
                table: "Trys",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "AracMarka",
                table: "Trys",
                newName: "Name");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Trys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
