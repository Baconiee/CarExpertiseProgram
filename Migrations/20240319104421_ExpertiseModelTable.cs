using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class ExpertiseModelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpertiseModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_OnTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kaput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Kaput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaKapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaCamurluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOnSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolMaspiyelArka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolMaspiyelOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Tavan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOnDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_Bagaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolArkaSase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HavuzSaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_HavuzSaci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SağArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SağArkaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_ArkaTampon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SagOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SagOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntsi_SolOrtaDirek = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertiseModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertiseModels");
        }
    }
}
