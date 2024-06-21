using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class YuruyenAksam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AksKontrol",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Amortisor",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracAltıMuhafaza",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Davlumbaz",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Difransiyel",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DingilKontrol",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenBalatalari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenDiskleri",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Helezonlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jantlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastikler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorFabrika",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorNot",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorOlculen",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RotKollari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalincakBurc",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakıtHortumlari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_AksKontrol",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Amartisor",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_AracAltıMuhafaza",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Davlumbaz",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Difransiyel",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_DingilKontrol",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_FrenBalatalari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_FrenDiskleri",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Helezonlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Jantlar",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Lastikler",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_RotKollari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_SalincakBurc",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_YakıtHortumlari",
                table: "ExpertiseModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AksKontrol",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Amortisor",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "AracAltıMuhafaza",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Davlumbaz",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Difransiyel",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "DingilKontrol",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "FrenBalatalari",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "FrenDiskleri",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Helezonlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Jantlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "Lastikler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorFabrika",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorNot",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "MotorOlculen",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "RotKollari",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "SalincakBurc",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "YakıtHortumlari",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_AksKontrol",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Amartisor",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_AracAltıMuhafaza",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Davlumbaz",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Difransiyel",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_DingilKontrol",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_FrenBalatalari",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_FrenDiskleri",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Helezonlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Jantlar",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_Lastikler",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_RotKollari",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_SalincakBurc",
                table: "ExpertiseModels");

            migrationBuilder.DropColumn(
                name: "not_YakıtHortumlari",
                table: "ExpertiseModels");
        }
    }
}
