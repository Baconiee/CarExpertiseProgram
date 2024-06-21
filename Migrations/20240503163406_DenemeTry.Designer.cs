﻿// <auto-generated />
using System;
using CarExpertise.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarExpertise.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240503163406_DenemeTry")]
    partial class DenemeTry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarExpertise.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AracKm")
                        .HasColumnType("int");

                    b.Property<string>("AracPlaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OdemeSekli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ucret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YakitTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YedekAnahtar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CustomerModels");
                });

            modelBuilder.Entity("CarExpertise.Models.Deneme1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deneme1s");
                });

            modelBuilder.Entity("CarExpertise.Models.Deneme2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DipNot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deneme2s");
                });

            modelBuilder.Entity("CarExpertise.Models.ExpertiseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ABS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ABSFren")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Airbag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AksKontrol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkuDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Amortisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracAltıMuhafaza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArkaTampon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aynalar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bagaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Camlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaYanik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Davlumbaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difransiyel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DingilKontrol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DipNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireksiyonPompa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dosemeler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EgsozSitem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElektirikliDireksiyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnjektorDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Farlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrenBalatalari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrenDiskleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrenHidrolik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gosterge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasarKmNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HavaFiltreKabinDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HavuzSaci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Helezonlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizSabitleyici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jantlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kaput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Klima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KlimaElektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Korna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastikBasınçElektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastikler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorArızaLambası")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorBeyinElektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorFabrika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorGenel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorOlculen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorYag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnTampon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkSensorleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Radyo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RotKollari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagArkaCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagArkaKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagArkaSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagMaspiyelArka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagMaspiyelOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagOnCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagOnDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagOnKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagOnSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SagOrtaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalincakBurc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanzumanDebriyaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SağArkaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Silecekler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolArkaCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolArkaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolArkaKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolArkaSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolMaspiyelArka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolMaspiyelOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolOnCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolOnDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolOnKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolOnSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolOrtaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stepne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sunroof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tavan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurboDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurboIntercoller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VKayis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YagSizdirmazlik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YakitSistem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YakitSizdirmalik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YakıtHortumlari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_AksKontrol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Amartisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_AracAltıMuhafaza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Aynalar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Camlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Davlumbaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Difransiyel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_DingilKontrol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Farlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_FrenBalatalari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_FrenDiskleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Helezonlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Jantlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Klima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Lastikler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_RotKollari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_SalincakBurc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Silecekler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Stepne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_Sunroof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_YakıtHortumlari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_abs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_abs_fren")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_airbag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_dosemeler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_elektrikli_direksiyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_esp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_esr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_gosterge_panelleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_hiz_sabitleyici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_klima_elektronigi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_korna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_lastik_basinc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_motor_ariza_lambasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_motor_beyin_elektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_park_sensorleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_radyo_teyp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("not_sanziman_elektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_AkuDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_ArkaTampon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_Bagaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_ContaYanik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_DireksiyonPompa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_EgsozSitem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_EnjektorDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_FrenHidrolik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_HavaFiltreKabinDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_HavuzSaci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_Kaput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_MotorGenel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_MotorYag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_OnTampon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagArkaCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagArkaKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagArkaSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagMaspiyelArka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagMaspiyelOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagOnCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagOnDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagOnKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagOnSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SagOrtaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SanzumanDebriyaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SağArkaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolArkaCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolArkaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolArkaKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolArkaSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolMaspiyelArka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolMaspiyelOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolOnCamurluk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolOnDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolOnKapi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolOnSase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_SolOrtaDirek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_Tavan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_TurboDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_TurboIntercoller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_VKayis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_YagSizdirmazlik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_YakitSistem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ntsi_YakitSizdirmalik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ŞanzımanElektroniği")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExpertiseModels");
                });

            modelBuilder.Entity("CarExpertise.Models.VehicleModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleModels");
                });
#pragma warning restore 612, 618
        }
    }
}
