﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnboardingSoftware.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aplikanti",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MjestoRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    JeVerifikovan = table.Column<bool>(type: "bit", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusZaposlenja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaZaposlenja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrenutnaPozicija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industrija = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplikanti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Interesi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Iskustvo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadnaPozicija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipUgovora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazivKompanije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaPozicije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpisPozicije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JeTrenutnoZaposlen = table.Column<bool>(type: "bit", nullable: false),
                    Dokument = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iskustvo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sektor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Obrazovanje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fakultet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Smjer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lokacija = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obrazovanje", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Testovi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trajanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pocetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojPitanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsvojeniProcenat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testovi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vjestine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vjestine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AplikantInteres",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    InteresID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantInteres", x => new { x.AplikantID, x.InteresID });
                    table.ForeignKey(
                        name: "FK_AplikantInteres_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantInteres_Interesi_InteresID",
                        column: x => x.InteresID,
                        principalTable: "Interesi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplikantIskustvo",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    IskustvoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantIskustvo", x => new { x.AplikantID, x.IskustvoID });
                    table.ForeignKey(
                        name: "FK_AplikantIskustvo_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantIskustvo_Iskustvo_IskustvoID",
                        column: x => x.IskustvoID,
                        principalTable: "Iskustvo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplikantObrazovanje",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    ObrazovanjeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantObrazovanje", x => new { x.AplikantID, x.ObrazovanjeID });
                    table.ForeignKey(
                        name: "FK_AplikantObrazovanje_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantObrazovanje_Obrazovanje_ObrazovanjeID",
                        column: x => x.ObrazovanjeID,
                        principalTable: "Obrazovanje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplikantTest",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    TestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantTest", x => new { x.AplikantID, x.TestID });
                    table.ForeignKey(
                        name: "FK_AplikantTest_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantTest_Testovi_TestID",
                        column: x => x.TestID,
                        principalTable: "Testovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pitanja",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedniBroj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitanja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pitanja_Testovi_TestID",
                        column: x => x.TestID,
                        principalTable: "Testovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poslovi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false),
                    TestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poslovi_Lokacija_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Poslovi_Testovi_TestID",
                        column: x => x.TestID,
                        principalTable: "Testovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplikantVjestina",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    VjestinaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantVjestina", x => new { x.AplikantID, x.VjestinaID });
                    table.ForeignKey(
                        name: "FK_AplikantVjestina_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantVjestina_Vjestine_VjestinaID",
                        column: x => x.VjestinaID,
                        principalTable: "Vjestine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odgovori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PonudjeniOdgovor_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PonudjeniOdgovor_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PonudjeniOdgovor_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PonudjeniOdgovor_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TacanOdgovor_1 = table.Column<bool>(type: "bit", nullable: false),
                    TacanOdgovor_2 = table.Column<bool>(type: "bit", nullable: false),
                    TacanOdgovor_3 = table.Column<bool>(type: "bit", nullable: false),
                    TacanOdgovor_4 = table.Column<bool>(type: "bit", nullable: false),
                    TekstOdgovor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PitanjeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odgovori", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Odgovori_Pitanja_PitanjeID",
                        column: x => x.PitanjeID,
                        principalTable: "Pitanja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AplikantPosao",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    PosaoID = table.Column<int>(type: "int", nullable: false),
                    PopratnoPismo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantPosao", x => new { x.AplikantID, x.PosaoID });
                    table.ForeignKey(
                        name: "FK_AplikantPosao_Aplikanti_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikanti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantPosao_Poslovi_PosaoID",
                        column: x => x.PosaoID,
                        principalTable: "Poslovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AplikantInteres_InteresID",
                table: "AplikantInteres",
                column: "InteresID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantIskustvo_IskustvoID",
                table: "AplikantIskustvo",
                column: "IskustvoID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantObrazovanje_ObrazovanjeID",
                table: "AplikantObrazovanje",
                column: "ObrazovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantPosao_PosaoID",
                table: "AplikantPosao",
                column: "PosaoID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantTest_TestID",
                table: "AplikantTest",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantVjestina_VjestinaID",
                table: "AplikantVjestina",
                column: "VjestinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Odgovori_PitanjeID",
                table: "Odgovori",
                column: "PitanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pitanja_TestID",
                table: "Pitanja",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslovi_LokacijaID",
                table: "Poslovi",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslovi_TestID",
                table: "Poslovi",
                column: "TestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AplikantInteres");

            migrationBuilder.DropTable(
                name: "AplikantIskustvo");

            migrationBuilder.DropTable(
                name: "AplikantObrazovanje");

            migrationBuilder.DropTable(
                name: "AplikantPosao");

            migrationBuilder.DropTable(
                name: "AplikantTest");

            migrationBuilder.DropTable(
                name: "AplikantVjestina");

            migrationBuilder.DropTable(
                name: "Odgovori");

            migrationBuilder.DropTable(
                name: "Interesi");

            migrationBuilder.DropTable(
                name: "Iskustvo");

            migrationBuilder.DropTable(
                name: "Obrazovanje");

            migrationBuilder.DropTable(
                name: "Poslovi");

            migrationBuilder.DropTable(
                name: "Aplikanti");

            migrationBuilder.DropTable(
                name: "Vjestine");

            migrationBuilder.DropTable(
                name: "Pitanja");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Testovi");
        }
    }
}
