using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class PanelPodyedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArkaPanel",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaPodye",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPanel",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPodye",
                table: "EkspertizSablonTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaPanel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaPodye",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPanel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPodye",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ArkaPanel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ArkaPodye",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_OnPanel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_OnPodye",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArkaPanel",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "ArkaPodye",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "OnPanel",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "OnPodye",
                table: "EkspertizSablonTable");

            migrationBuilder.DropColumn(
                name: "ArkaPanel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ArkaPodye",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "OnPanel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "OnPodye",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_ArkaPanel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_ArkaPodye",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_OnPanel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_OnPodye",
                table: "Deneme2s");
        }
    }
}
