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
    [Migration("20240324142321_MotorMekanik")]
    partial class MotorMekanik
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

                    b.Property<string>("AracMarka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracModel")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("CarExpertise.Models.ExpertiseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AkuDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArkaTampon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bagaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaYanik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireksiyonPompa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EgsozSitem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnjektorDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrenHidrolik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HavaFiltreKabinDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HavuzSaci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kaput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorGenel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorYag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnTampon")
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

                    b.Property<string>("SanzumanDebriyaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SağArkaDirek")
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
