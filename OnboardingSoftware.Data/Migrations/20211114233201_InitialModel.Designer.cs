﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnboardingSoftware.Data;

namespace OnboardingSoftware.Data.Migrations
{
    [DbContext(typeof(OnboardingSoftwareDbContext))]
    [Migration("20211114233201_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AplikantInteres", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("InteresiID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "InteresiID");

                    b.HasIndex("InteresiID");

                    b.ToTable("AplikantInteres");
                });

            modelBuilder.Entity("AplikantIskustvo", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("IskustvoID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "IskustvoID");

                    b.HasIndex("IskustvoID");

                    b.ToTable("AplikantIskustvo");
                });

            modelBuilder.Entity("AplikantObrazovanje", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("ObrazovanjeID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "ObrazovanjeID");

                    b.HasIndex("ObrazovanjeID");

                    b.ToTable("AplikantObrazovanje");
                });

            modelBuilder.Entity("AplikantPosao", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("PosloviID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "PosloviID");

                    b.HasIndex("PosloviID");

                    b.ToTable("AplikantPosao");
                });

            modelBuilder.Entity("AplikantTest", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("TestoviID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "TestoviID");

                    b.HasIndex("TestoviID");

                    b.ToTable("AplikantTest");
                });

            modelBuilder.Entity("AplikantVjestina", b =>
                {
                    b.Property<int>("AplikantiID")
                        .HasColumnType("int");

                    b.Property<int>("VjestineID")
                        .HasColumnType("int");

                    b.HasKey("AplikantiID", "VjestineID");

                    b.HasIndex("VjestineID");

                    b.ToTable("AplikantVjestina");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Aplikant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industrija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("JeVerifikovan")
                        .HasColumnType("bit");

                    b.Property<string>("LokacijaZaposlenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StatusZaposlenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrenutnaPozicija")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Aplikanti");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Interes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Interesi");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Iskustvo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Dokument")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("JeTrenutnoZaposlen")
                        .HasColumnType("bit");

                    b.Property<string>("LokacijaPozicije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivKompanije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisPozicije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnaPozicija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipUgovora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Iskustvo");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Obrazovanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fakultet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smjer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Obrazovanje");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Posao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LokacijaID");

                    b.HasIndex("TestID");

                    b.ToTable("Posao");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Test", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojPitanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Kraj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OsvojeniProcenat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Pocetak")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trajanje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Vjestina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Vjestine");
                });

            modelBuilder.Entity("AplikantInteres", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Interes", null)
                        .WithMany()
                        .HasForeignKey("InteresiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantIskustvo", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Iskustvo", null)
                        .WithMany()
                        .HasForeignKey("IskustvoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantObrazovanje", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Obrazovanje", null)
                        .WithMany()
                        .HasForeignKey("ObrazovanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantPosao", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Posao", null)
                        .WithMany()
                        .HasForeignKey("PosloviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantTest", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Test", null)
                        .WithMany()
                        .HasForeignKey("TestoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantVjestina", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Vjestina", null)
                        .WithMany()
                        .HasForeignKey("VjestineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnboardingSoftware.Core.Models.Posao", b =>
                {
                    b.HasOne("OnboardingSoftware.Core.Models.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnboardingSoftware.Core.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lokacija");

                    b.Navigation("Test");
                });
#pragma warning restore 612, 618
        }
    }
}
