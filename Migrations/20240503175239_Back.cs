﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class Back : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModels");

            migrationBuilder.DropTable(
                name: "ExpertiseModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracKm = table.Column<int>(type: "int", nullable: false),
                    AracPlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ucret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YedekAnahtar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpertiseModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABSFren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airbag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AksKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkuDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amortisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracAltıMuhafaza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aynalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Camlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContaYanik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Davlumbaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difransiyel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DingilKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DipNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireksiyonPompa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosemeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgsozSitem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElektirikliDireksiyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnjektorDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Farlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenBalatalari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenDiskleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenHidrolik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gosterge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasarKmNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavaFiltreKabinDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavuzSaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Helezonlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizSabitleyici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jantlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kaput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KlimaElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Korna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastikBasınçElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorArızaLambası = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorBeyinElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorFabrika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorOlculen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorYag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkSensorleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Radyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotKollari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalincakBurc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SanzumanDebriyaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SağArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silecekler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stepne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sunroof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboIntercoller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKayis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YagSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSizdirmalik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakıtHortumlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_AksKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Amartisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_AracAltıMuhafaza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Aynalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Camlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Davlumbaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Difransiyel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_DingilKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Farlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_FrenBalatalari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_FrenDiskleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Helezonlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Jantlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Klima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Lastikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_RotKollari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_SalincakBurc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Silecekler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Stepne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_Sunroof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_YakıtHortumlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_abs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_abs_fren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_airbag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_dosemeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_elektrikli_direksiyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_esp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_esr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_gosterge_panelleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_hiz_sabitleyici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_klima_elektronigi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_korna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_lastik_basinc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_motor_ariza_lambasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_motor_beyin_elektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_park_sensorleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_radyo_teyp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    not_sanziman_elektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_AkuDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_ContaYanik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_DireksiyonPompa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_EgsozSitem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_EnjektorDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_FrenHidrolik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_HavaFiltreKabinDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_HavuzSaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Kaput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_MotorGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_MotorYag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SanzumanDebriyaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SağArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_TurboDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_TurboIntercoller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_VKayis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_YagSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_YakitSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_YakitSizdirmalik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ŞanzımanElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertiseModels", x => x.Id);
                });
        }
    }
}