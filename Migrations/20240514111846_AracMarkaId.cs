using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class AracMarkaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "VehicleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AracMarkaId",
                table: "VehicleModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "VehicleModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "AracMarkaId",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "VehicleModels");
        }
    }
}
