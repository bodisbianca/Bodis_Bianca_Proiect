﻿// <auto-generated />
using System;
using Bodis_Bianca_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bodis_Bianca_Proiect.Migrations
{
    [DbContext(typeof(Bodis_Bianca_ProiectContext))]
    [Migration("20210109172324_DetaliiSpecie")]
    partial class DetaliiSpecie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Age")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SpecieID");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Specie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetaliiSpecie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecieName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Specie");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Animal", b =>
                {
                    b.HasOne("Bodis_Bianca_Proiect.Models.Specie", "Specie")
                        .WithMany("Animals")
                        .HasForeignKey("SpecieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
