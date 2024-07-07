using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class ProjectUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deneme1s");

            migrationBuilder.DropTable(
                name: "Deneme2s");

            migrationBuilder.DropTable(
                name: "EkspertizSablonTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpertiseModels",
                table: "ExpertiseModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerModels",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "CustomerModels");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "CustomerModels");

            migrationBuilder.RenameTable(
                name: "ExpertiseModels",
                newName: "ExpertiseTable");

            migrationBuilder.RenameTable(
                name: "CustomerModels",
                newName: "CustomerModel");

            migrationBuilder.RenameColumn(
                name: "ntsi_YakitSizdirmalik",
                table: "ExpertiseTable",
                newName: "ntsi_YakitSizdirmazlik");

            migrationBuilder.RenameColumn(
                name: "YakitSizdirmalik",
                table: "ExpertiseTable",
                newName: "ntsi_OnPodye");

            migrationBuilder.RenameColumn(
                name: "Yil",
                table: "CustomerModel",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "AracKm",
                table: "CustomerModel",
                newName: "AracMarkaId");

            migrationBuilder.AddColumn<int>(
                name: "AracId",
                table: "ExpertiseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracKm",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracMarka",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AracMarkaId",
                table: "ExpertiseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AracModel",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaPanel",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArkaPodye",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ExpertiseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ExpertiseTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "ExpertiseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPanel",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnPodye",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "ExpertiseTable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ucret",
                table: "ExpertiseTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitSizdirmazlik",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yil",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ArkaPanel",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_ArkaPodye",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ntsi_OnPanel",
                table: "ExpertiseTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CustomerModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpertiseTable",
                table: "ExpertiseTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerModel",
                table: "CustomerModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ExpertiseTemplateTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SagOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kaput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavuzSaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SağArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorYag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboIntercoller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireksiyonPompa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenHidrolik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnjektorDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavaFiltreKabinDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SanzumanDebriyaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgsozSitem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContaYanik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKayis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YagSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkuDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorFabrika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorOlculen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jantlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotKollari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amortisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenDiskleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenBalatalari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakıtHortumlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Helezonlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AksKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalincakBurc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracAltıMuhafaza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Davlumbaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DingilKontrol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difransiyel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aynalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Camlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silecekler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Farlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sunroof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stepne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABSFren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Radyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosemeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizSabitleyici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkSensorleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Korna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gosterge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airbag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorArızaLambası = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElektirikliDireksiyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastikBasınçElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KlimaElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorBeyinElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ŞanzımanElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasarKmNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DipNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SablonAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracKaporta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMotor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorPerformans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuruyenAksam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcDisAksesuar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElektronikSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertiseTemplateTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertiseTemplateTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpertiseTable",
                table: "ExpertiseTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerModel",
                table: "CustomerModel");

            migrationBuilder.DropColumn(
                name: "AracId",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "AracKm",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "AracMarka",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "AracMarkaId",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "AracModel",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "ArkaPanel",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "ArkaPodye",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "OnPanel",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "OnPodye",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "Ucret",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "YakitSizdirmazlik",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "YakitTipi",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "YedekAnahtar",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "ntsi_ArkaPanel",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "ntsi_ArkaPodye",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "ntsi_OnPanel",
                table: "ExpertiseTable");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CustomerModel");

            migrationBuilder.RenameTable(
                name: "ExpertiseTable",
                newName: "ExpertiseModels");

            migrationBuilder.RenameTable(
                name: "CustomerModel",
                newName: "CustomerModels");

            migrationBuilder.RenameColumn(
                name: "ntsi_YakitSizdirmazlik",
                table: "ExpertiseModels",
                newName: "ntsi_YakitSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "ntsi_OnPodye",
                table: "ExpertiseModels",
                newName: "YakitSizdirmalik");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CustomerModels",
                newName: "Yil");

            migrationBuilder.RenameColumn(
                name: "AracMarkaId",
                table: "CustomerModels",
                newName: "AracKm");

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ucret",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakitTipi",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YedekAnahtar",
                table: "CustomerModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpertiseModels",
                table: "ExpertiseModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerModels",
                table: "CustomerModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Deneme1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracMarkaId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneme1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deneme2s",
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
                    AracId = table.Column<int>(type: "int", nullable: false),
                    AracKm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMarka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMarkaId = table.Column<int>(type: "int", nullable: false),
                    AracModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracPlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aynalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Camlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    SaseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboIntercoller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ucret = table.Column<int>(type: "int", nullable: true),
                    VKayis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YagSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakıtHortumlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YedekAnahtar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ntsi_ArkaPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_ArkaPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ntsi_OnPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_OnPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ntsi_YakitSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ŞanzımanElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneme2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EkspertizSablonTable",
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
                    AracKaporta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracMotor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aynalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Camlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
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
                    ElektronikSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IcDisAksesuar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    MotorPerformans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorYag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnPodye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkSensorleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Radyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotKollari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SablonAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    YakitSizdirmazlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakıtHortumlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuruyenAksam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updateId = table.Column<int>(type: "int", nullable: true),
                    ŞanzımanElektroniği = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkspertizSablonTable", x => x.Id);
                });
        }
    }
}
