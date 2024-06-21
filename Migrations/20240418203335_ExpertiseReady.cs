using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class ExpertiseReady : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ABS",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ABSFren",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Airbag",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aynalar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Camlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DipNot",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dosemeler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESP",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESR",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElektirikliDireksiyon",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Farlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gosterge",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HasarKmNot",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HizSabitleyici",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Klima",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KlimaElektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Korna",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastikBasınçElektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorArızaLambası",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorBeyinElektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParkSensorleri",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Radyo",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Silecekler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stepne",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunroof",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Aynalar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Camlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Farlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Klima",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Silecekler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Stepne",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Sunroof",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_abs",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_abs_fren",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_airbag",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_dosemeler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_elektrikli_direksiyon",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_esp",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_esr",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_gosterge_panelleri",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_hiz_sabitleyici",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_klima_elektronigi",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_korna",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_lastik_basinc",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_motor_ariza_lambasi",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_motor_beyin_elektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_park_sensorleri",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_radyo_teyp",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_sanziman_elektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ŞanzımanElektroniği",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ABS",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ABSFren",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Airbag",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Aynalar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Camlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "DipNot",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Dosemeler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ESP",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ESR",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ElektirikliDireksiyon",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Farlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Gosterge",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "HasarKmNot",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "HizSabitleyici",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Klima",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "KlimaElektroniği",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Korna",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "LastikBasınçElektroniği",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorArızaLambası",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorBeyinElektroniği",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ParkSensorleri",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Radyo",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Silecekler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Stepne",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Sunroof",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Aynalar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Camlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Farlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Klima",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Silecekler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Stepne",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Sunroof",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_abs",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_abs_fren",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_airbag",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_dosemeler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_elektrikli_direksiyon",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_esp",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_esr",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_gosterge_panelleri",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_hiz_sabitleyici",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_klima_elektronigi",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_korna",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_lastik_basinc",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_motor_ariza_lambasi",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_motor_beyin_elektroniği",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_park_sensorleri",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_radyo_teyp",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_sanziman_elektroniği",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "ŞanzımanElektroniği",
                table: "ExpertiseModels");
        }
    }
}
