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
    [Migration("20240318120713_TelefonUpdate")]
    partial class TelefonUpdate
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
