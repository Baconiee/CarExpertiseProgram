using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class SablonReadReal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EkspertizSablonTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    MotorYag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurboIntercoller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireksiyonPompa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenHidrolik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnjektorDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavaFiltreKabinDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakitSizdirmalik = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    DipNot = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkspertizSablonTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EkspertizSablonTable");
        }
    }
}
