using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilirkisiAspire.ApiService.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UcretHesaplamalari",
                columns: table => new
                {
                    UcretHesaplamaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeslekKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AylikOrtalamaUcret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemelUcret = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    ElleGirilenYemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    ElleGirilenYolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Prim = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    GiydirilmisUcret = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    AsgariUcretKatsayiAl = table.Column<bool>(type: "bit", nullable: false),
                    UcretBordrolarindaHesapla = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UcretHesaplamalari", x => x.UcretHesaplamaId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MahkemeDosyalari",
                columns: table => new
                {
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MahkemeIli = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MahkemeSayisi = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    DosyaYili = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    EsasNo = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DavaciId = table.Column<int>(type: "int", nullable: true),
                    UcretHesaplamaId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MahkemeDosyalari", x => x.MahkemeDosyasiId);
                    table.ForeignKey(
                        name: "FK_MahkemeDosyalari_UcretHesaplamalari_UcretHesaplamaId",
                        column: x => x.UcretHesaplamaId,
                        principalTable: "UcretHesaplamalari",
                        principalColumn: "UcretHesaplamaId");
                });

            migrationBuilder.CreateTable(
                name: "Davacilar",
                columns: table => new
                {
                    DavaciId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DilekceOzeti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DavaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TemelUcret = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    AUdenHesapla = table.Column<bool>(type: "bit", nullable: true),
                    YolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YuTopTasHesapla = table.Column<bool>(type: "bit", nullable: true),
                    Prim = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Ikramiye = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    DigerOdemeler = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    HaftalikCalismaGunu = table.Column<int>(type: "int", nullable: true),
                    HaftalikTatilGunu = table.Column<int>(type: "int", nullable: true),
                    GunlukCalismaSaati = table.Column<int>(type: "int", nullable: true),
                    HaftalikEkCalismaSuresi = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davacilar", x => x.DavaciId);
                    table.ForeignKey(
                        name: "FK_Davacilar_MahkemeDosyalari_DavaciId",
                        column: x => x.DavaciId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DavaciVekilleri",
                columns: table => new
                {
                    DavaciVekiliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavaciVekilleri", x => x.DavaciVekiliId);
                    table.ForeignKey(
                        name: "FK_DavaciVekilleri_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Davalilar",
                columns: table => new
                {
                    DavaliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsimYaDaUnvan = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DilekceOzeti = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    ZamanAsimiItirazi = table.Column<bool>(type: "bit", nullable: true),
                    TemelUcret = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    AUdenHesapla = table.Column<bool>(type: "bit", nullable: true),
                    YolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YuTopTasHesapla = table.Column<bool>(type: "bit", nullable: true),
                    Prim = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Ikramiye = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    DigerOdemeler = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davalilar", x => x.DavaliId);
                    table.ForeignKey(
                        name: "FK_Davalilar_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId");
                });

            migrationBuilder.CreateTable(
                name: "DavaliVekilleri",
                columns: table => new
                {
                    DavaliVekiliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavaliVekilleri", x => x.DavaliVekiliId);
                    table.ForeignKey(
                        name: "FK_DavaliVekilleri_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HizmetSureleri",
                columns: table => new
                {
                    HizmetSuresiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SgkKayitlari = table.Column<bool>(type: "bit", nullable: false),
                    TanikBeyanlari = table.Column<bool>(type: "bit", nullable: false),
                    UcretBordrolari = table.Column<bool>(type: "bit", nullable: false),
                    TalepleBaglilikIlkesi = table.Column<bool>(type: "bit", nullable: false),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetSureleri", x => x.HizmetSuresiId);
                    table.ForeignKey(
                        name: "FK_HizmetSureleri_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId");
                });

            migrationBuilder.CreateTable(
                name: "Muzekkereler",
                columns: table => new
                {
                    MuzekkereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazilanKurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirilenUcret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzekkereler", x => x.MuzekkereId);
                    table.ForeignKey(
                        name: "FK_Muzekkereler_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuantajKayitlari",
                columns: table => new
                {
                    PuantajKaydiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Ay = table.Column<int>(type: "int", nullable: false),
                    FazlaCalisma = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    UBGT = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Izin = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    PuantajKayitlariVarYok = table.Column<bool>(type: "bit", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuantajKayitlari", x => x.PuantajKaydiId);
                    table.ForeignKey(
                        name: "FK_PuantajKayitlari_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId");
                });

            migrationBuilder.CreateTable(
                name: "SgkIncelemeleri",
                columns: table => new
                {
                    SgkIncelemesiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SigortaIseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigortaIstenAyrilisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigortaSicilNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsverenUnvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalisilanGun = table.Column<int>(type: "int", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SgkIncelemeleri", x => x.SgkIncelemesiId);
                    table.ForeignKey(
                        name: "FK_SgkIncelemeleri_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taniklar",
                columns: table => new
                {
                    TanikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeyanOzeti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Husumet = table.Column<bool>(type: "bit", nullable: true),
                    TaniginIseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaniginIstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DavacininIseGirisSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DavacininIsttenCikisSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HaftalikEkCalismaSure = table.Column<TimeSpan>(type: "time", nullable: true),
                    TemelUcret = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    YemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    AUdenHesapla = table.Column<bool>(type: "bit", nullable: true),
                    YuTopTasHesapla = table.Column<bool>(type: "bit", nullable: true),
                    YolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Prim = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    Ikramiye = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    DigerOdemeler = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    HaftalikCalismaGunu = table.Column<int>(type: "int", maxLength: 2, nullable: true),
                    HaftaTatiliGunu = table.Column<int>(type: "int", nullable: true),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taniklar", x => x.TanikId);
                    table.ForeignKey(
                        name: "FK_Taniklar_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UcretBordrolari",
                columns: table => new
                {
                    UcretBordrosuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Ay = table.Column<int>(type: "int", nullable: false),
                    Ucret = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    FazlaCalisma = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    UBGT = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Prim = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    YemekUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    YolUcreti = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Izin = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    UcretBordrosuVarYok = table.Column<bool>(type: "bit", nullable: true),
                    ImzaVarYok = table.Column<bool>(type: "bit", nullable: false),
                    BankaDekontuVarYok = table.Column<bool>(type: "bit", nullable: false),
                    MahkemeDosyasiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UcretBordrolari", x => x.UcretBordrosuId);
                    table.ForeignKey(
                        name: "FK_UcretBordrolari_MahkemeDosyalari_MahkemeDosyasiId",
                        column: x => x.MahkemeDosyasiId,
                        principalTable: "MahkemeDosyalari",
                        principalColumn: "MahkemeDosyasiId");
                });

            migrationBuilder.CreateTable(
                name: "OdemeTalepleri",
                columns: table => new
                {
                    OdemeTalebiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bedel = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    DavaciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemeTalepleri", x => x.OdemeTalebiId);
                    table.ForeignKey(
                        name: "FK_OdemeTalepleri_Davacilar_DavaciId",
                        column: x => x.DavaciId,
                        principalTable: "Davacilar",
                        principalColumn: "DavaciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EksikGunBildirimleri",
                columns: table => new
                {
                    EksikGunBildirimiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EksikGunBildirilenAy = table.Column<int>(type: "int", nullable: true),
                    EksikGunBildirilenYil = table.Column<int>(type: "int", nullable: true),
                    EksikGunNedeni = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    IstenCikisKodu = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    SgkIncelemesiId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EksikGunBildirimleri", x => x.EksikGunBildirimiId);
                    table.ForeignKey(
                        name: "FK_EksikGunBildirimleri_SgkIncelemeleri_SgkIncelemesiId",
                        column: x => x.SgkIncelemesiId,
                        principalTable: "SgkIncelemeleri",
                        principalColumn: "SgkIncelemesiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DavaciVekilleri_MahkemeDosyasiId",
                table: "DavaciVekilleri",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Davalilar_MahkemeDosyasiId",
                table: "Davalilar",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_DavaliVekilleri_MahkemeDosyasiId",
                table: "DavaliVekilleri",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_EksikGunBildirimleri_SgkIncelemesiId",
                table: "EksikGunBildirimleri",
                column: "SgkIncelemesiId");

            migrationBuilder.CreateIndex(
                name: "IX_HizmetSureleri_MahkemeDosyasiId",
                table: "HizmetSureleri",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_MahkemeDosyalari_UcretHesaplamaId",
                table: "MahkemeDosyalari",
                column: "UcretHesaplamaId",
                unique: true,
                filter: "[UcretHesaplamaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Muzekkereler_MahkemeDosyasiId",
                table: "Muzekkereler",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_OdemeTalepleri_DavaciId",
                table: "OdemeTalepleri",
                column: "DavaciId");

            migrationBuilder.CreateIndex(
                name: "IX_PuantajKayitlari_MahkemeDosyasiId",
                table: "PuantajKayitlari",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_SgkIncelemeleri_MahkemeDosyasiId",
                table: "SgkIncelemeleri",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Taniklar_MahkemeDosyasiId",
                table: "Taniklar",
                column: "MahkemeDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_UcretBordrolari_MahkemeDosyasiId",
                table: "UcretBordrolari",
                column: "MahkemeDosyasiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DavaciVekilleri");

            migrationBuilder.DropTable(
                name: "Davalilar");

            migrationBuilder.DropTable(
                name: "DavaliVekilleri");

            migrationBuilder.DropTable(
                name: "EksikGunBildirimleri");

            migrationBuilder.DropTable(
                name: "HizmetSureleri");

            migrationBuilder.DropTable(
                name: "Muzekkereler");

            migrationBuilder.DropTable(
                name: "OdemeTalepleri");

            migrationBuilder.DropTable(
                name: "PuantajKayitlari");

            migrationBuilder.DropTable(
                name: "Taniklar");

            migrationBuilder.DropTable(
                name: "UcretBordrolari");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SgkIncelemeleri");

            migrationBuilder.DropTable(
                name: "Davacilar");

            migrationBuilder.DropTable(
                name: "MahkemeDosyalari");

            migrationBuilder.DropTable(
                name: "UcretHesaplamalari");
        }
    }
}
