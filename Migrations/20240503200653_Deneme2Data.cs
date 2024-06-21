using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class Deneme2Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ABS",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ABSFren",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Airbag",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AksKontrol",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AkuDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Amortisor",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracAltıMuhafaza",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaTampon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aynalar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bagaj",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Camlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContaYanik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Davlumbaz",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Difransiyel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DingilKontrol",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DireksiyonPompa",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dosemeler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESP",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESR",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EgsozSitem",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElektirikliDireksiyon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnjektorDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Farlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenBalatalari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenDiskleri",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrenHidrolik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gosterge",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HasarKmNot",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HavaFiltreKabinDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HavuzSaci",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Helezonlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HizSabitleyici",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jantlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kaput",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Klima",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KlimaElektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Korna",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastikBasınçElektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastikler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorArızaLambası",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorBeyinElektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorFabrika",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorGenel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorNot",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorOlculen",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorYag",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnTampon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParkSensorleri",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Radyo",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RotKollari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagArkaCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagArkaKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagArkaSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagMaspiyelArka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagMaspiyelOn",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagOnCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagOnDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagOnKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagOnSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SagOrtaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalincakBurc",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SanzumanDebriyaj",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SağArkaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Silecekler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolArkaCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolArkaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolArkaKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolArkaSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolMaspiyelArka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolMaspiyelOn",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolOnCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolOnDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolOnKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolOnSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolOrtaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stepne",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunroof",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tavan",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurboDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurboIntercoller",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VKayis",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YagSizdirmazlik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitSistem",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitSizdirmalik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakıtHortumlari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_AksKontrol",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Amartisor",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_AracAltıMuhafaza",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Aynalar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Camlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Davlumbaz",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Difransiyel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_DingilKontrol",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Farlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_FrenBalatalari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_FrenDiskleri",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Helezonlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Jantlar",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Klima",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Lastikler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_RotKollari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_SalincakBurc",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Silecekler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Stepne",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_Sunroof",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_YakıtHortumlari",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_abs",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_abs_fren",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_airbag",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_dosemeler",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_elektrikli_direksiyon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_esp",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_esr",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_gosterge_panelleri",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_hiz_sabitleyici",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_klima_elektronigi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_korna",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_lastik_basinc",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_motor_ariza_lambasi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_motor_beyin_elektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_park_sensorleri",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_radyo_teyp",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "not_sanziman_elektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_AkuDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ArkaTampon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_Bagaj",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ContaYanik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_DireksiyonPompa",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_EgsozSitem",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_EnjektorDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_FrenHidrolik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_HavaFiltreKabinDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_HavuzSaci",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_Kaput",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_MotorGenel",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_MotorYag",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_OnTampon",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagArkaCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagArkaKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagArkaSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagMaspiyelArka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagMaspiyelOn",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagOnCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagOnDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagOnKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagOnSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SagOrtaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SanzumanDebriyaj",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SağArkaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolArkaCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolArkaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolArkaKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolArkaSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolMaspiyelArka",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolMaspiyelOn",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolOnCamurluk",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolOnDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolOnKapi",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolOnSase",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_SolOrtaDirek",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_Tavan",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_TurboDurum",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_TurboIntercoller",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_VKayis",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YagSizdirmazlik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YakitSistem",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_YakitSizdirmalik",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ŞanzımanElektroniği",
                table: "Deneme2s",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ABS",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ABSFren",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Airbag",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AksKontrol",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AkuDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Amortisor",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "AracAltıMuhafaza",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ArkaTampon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Aynalar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Bagaj",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Camlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ContaYanik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Davlumbaz",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Difransiyel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "DingilKontrol",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "DireksiyonPompa",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Dosemeler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ESP",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ESR",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "EgsozSitem",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ElektirikliDireksiyon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "EnjektorDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Farlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "FrenBalatalari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "FrenDiskleri",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "FrenHidrolik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Gosterge",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "HasarKmNot",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "HavaFiltreKabinDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "HavuzSaci",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Helezonlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "HizSabitleyici",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Jantlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Kaput",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Klima",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "KlimaElektroniği",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Korna",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "LastikBasınçElektroniği",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Lastikler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorArızaLambası",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorBeyinElektroniği",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorFabrika",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorGenel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorNot",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorOlculen",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "MotorYag",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "OnTampon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ParkSensorleri",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Radyo",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "RotKollari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagArkaCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagArkaKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagArkaSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagMaspiyelArka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagMaspiyelOn",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagOnCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagOnDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagOnKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagOnSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SagOrtaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SalincakBurc",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SanzumanDebriyaj",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SağArkaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Silecekler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolArkaCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolArkaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolArkaKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolArkaSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolMaspiyelArka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolMaspiyelOn",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolOnCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolOnDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolOnKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolOnSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "SolOrtaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Stepne",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Sunroof",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "Tavan",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "TurboDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "TurboIntercoller",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "VKayis",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YagSizdirmazlik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YakitSistem",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YakitSizdirmalik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "YakıtHortumlari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_AksKontrol",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Amartisor",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_AracAltıMuhafaza",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Aynalar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Camlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Davlumbaz",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Difransiyel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_DingilKontrol",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Farlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_FrenBalatalari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_FrenDiskleri",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Helezonlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Jantlar",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Klima",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Lastikler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_RotKollari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_SalincakBurc",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Silecekler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Stepne",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_Sunroof",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_YakıtHortumlari",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_abs",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_abs_fren",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_airbag",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_dosemeler",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_elektrikli_direksiyon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_esp",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_esr",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_gosterge_panelleri",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_hiz_sabitleyici",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_klima_elektronigi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_korna",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_lastik_basinc",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_motor_ariza_lambasi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_motor_beyin_elektroniği",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_park_sensorleri",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_radyo_teyp",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "not_sanziman_elektroniği",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_AkuDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_ArkaTampon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_Bagaj",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_ContaYanik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_DireksiyonPompa",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_EgsozSitem",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_EnjektorDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_FrenHidrolik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_HavaFiltreKabinDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_HavuzSaci",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_Kaput",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_MotorGenel",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_MotorYag",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_OnTampon",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagArkaCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagArkaKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagArkaSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagMaspiyelArka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagMaspiyelOn",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagOnCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagOnDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagOnKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagOnSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SagOrtaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SanzumanDebriyaj",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SağArkaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolArkaCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolArkaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolArkaKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolArkaSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolMaspiyelArka",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolMaspiyelOn",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolOnCamurluk",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolOnDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolOnKapi",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolOnSase",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_SolOrtaDirek",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_Tavan",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_TurboDurum",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_TurboIntercoller",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_VKayis",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_YagSizdirmazlik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_YakitSistem",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ntsi_YakitSizdirmalik",
                table: "Deneme2s");

            migrationBuilder.DropColumn(
                name: "ŞanzımanElektroniği",
                table: "Deneme2s");
        }
    }
}
