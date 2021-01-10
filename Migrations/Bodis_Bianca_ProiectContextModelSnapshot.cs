﻿// <auto-generated />
using System;
using Bodis_Bianca_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bodis_Bianca_Proiect.Migrations
{
    [DbContext(typeof(Bodis_Bianca_ProiectContext))]
    partial class Bodis_Bianca_ProiectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("FosterID")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FosterID");

                    b.HasIndex("SpecieID");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.AnimalTrait", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<int>("SpecieID")
                        .HasColumnType("int");

                    b.Property<int?>("TraitID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalID");

                    b.HasIndex("TraitID");

                    b.ToTable("AnimalTrait");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Foster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetaliiFoster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FosterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vechime")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Foster");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Specie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetaliiSpecie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DifIntretinere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VarstaMaxima")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Specie");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Trait", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avantaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dezavantaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraitDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trait");
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.Animal", b =>
                {
                    b.HasOne("Bodis_Bianca_Proiect.Models.Foster", "Foster")
                        .WithMany()
                        .HasForeignKey("FosterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bodis_Bianca_Proiect.Models.Specie", "Specie")
                        .WithMany("Animals")
                        .HasForeignKey("SpecieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bodis_Bianca_Proiect.Models.AnimalTrait", b =>
                {
                    b.HasOne("Bodis_Bianca_Proiect.Models.Animal", "Animal")
                        .WithMany("AnimalTraits")
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bodis_Bianca_Proiect.Models.Trait", "Trait")
                        .WithMany("AnimalTraits")
                        .HasForeignKey("TraitID");
                });
#pragma warning restore 612, 618
        }
    }
}
