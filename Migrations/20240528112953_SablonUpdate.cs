using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class SablonUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AracKaporta",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracMotor",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElektronikSistem",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcDisAksesuar",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorPerformans",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YuruyenAksam",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracKaporta",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "AracMotor",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "ElektronikSistem",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "IcDisAksesuar",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "MotorPerformans",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "YuruyenAksam",
                table: "EkspertizSablonTable");
        }
    }
}
