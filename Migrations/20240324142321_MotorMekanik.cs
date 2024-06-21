using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class MotorMekanik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AkuDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContaYanik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DireksiyonPompa",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EgsozSitem",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnjektorDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenHidrolik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HavaFiltreKabinDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorGenel",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorYag",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SanzumanDebriyaj",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurboDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurboIntercoller",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VKayis",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YagSizdirmazlik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitSistem",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitSizdirmalik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_AkuDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ContaYanik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_DireksiyonPompa",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_EgsozSitem",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_EnjektorDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_FrenHidrolik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_HavaFiltreKabinDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_MotorGenel",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_MotorYag",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SanzumanDebriyaj",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_TurboDurum",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_TurboIntercoller",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_VKayis",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YagSizdirmazlik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YakitSistem",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YakitSizdirmalik",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AkuDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ContaYanik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "DireksiyonPompa",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "EgsozSitem",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "EnjektorDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "FrenHidrolik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "HavaFiltreKabinDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorGenel",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorYag",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "SanzumanDebriyaj",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "TurboDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "TurboIntercoller",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "VKayis",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "YagSizdirmazlik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "YakitSistem",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "YakitSizdirmalik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_AkuDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_ContaYanik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_DireksiyonPompa",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_EgsozSitem",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_EnjektorDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_FrenHidrolik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_HavaFiltreKabinDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_MotorGenel",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_MotorYag",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_SanzumanDebriyaj",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_TurboDurum",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_TurboIntercoller",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_VKayis",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_YagSizdirmazlik",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_YakitSistem",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ntsi_YakitSizdirmalik",
                table: "ExpertiseModels");
        }
    }
}
