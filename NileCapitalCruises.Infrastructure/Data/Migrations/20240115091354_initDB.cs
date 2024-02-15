using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NileCapitalCruises.Infrastructure.Data.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "ASPStateTempApplications",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false),
                    AppName = table.Column<string>(type: "char(280)", unicode: false, fixedLength: true, maxLength: 280, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASPState__8E2CF7F99C8E2398", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "ASPStateTempSessions",
                columns: table => new
                {
                    SessionId = table.Column<string>(type: "nvarchar(88)", maxLength: 88, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getutcdate())"),
                    Expires = table.Column<DateTime>(type: "datetime", nullable: false),
                    LockDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LockDateLocal = table.Column<DateTime>(type: "datetime", nullable: false),
                    LockCookie = table.Column<int>(type: "int", nullable: false),
                    Timeout = table.Column<int>(type: "int", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    SessionItemShort = table.Column<byte[]>(type: "varbinary(7000)", maxLength: 7000, nullable: true),
                    SessionItemLong = table.Column<byte[]>(type: "image", nullable: true),
                    Flags = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASPState__C9F492909AA164B4", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmenitiesNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AmenitiesIcon = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AmenitiesStatus = table.Column<bool>(type: "bit", nullable: true),
                    AmenitiesPosition = table.Column<int>(type: "int", nullable: true),
                    AmenitiesIconWidth = table.Column<int>(type: "int", nullable: true),
                    AmenitiesIconHeight = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CityUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityStatus = table.Column<bool>(type: "bit", nullable: true),
                    CityPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    CityPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    CityBannerWidth = table.Column<int>(type: "int", nullable: true),
                    CityBannerHeight = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CityUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityStatus = table.Column<bool>(type: "bit", nullable: true),
                    CityPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    CityPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    CityBannerWidth = table.Column<int>(type: "int", nullable: true),
                    CityBannerHeight = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cruises_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseCategoryNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClassIcon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cruises_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Dinings_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiningTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Dinings_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Durations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(type: "int", nullable: true),
                    Nights = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Durations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Facilities_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Facilities_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Brands_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Brands_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Cabins_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinCategoryTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Cabins_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_CabinStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinStatusNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_CabinStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageFlag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageAbbreviation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LangStatus = table.Column<bool>(type: "bit", nullable: true),
                    LanguageClass = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayCode = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    WeekDayNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_WeekDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "tbl_Master_Itineraries_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ItineraryDays = table.Column<int>(type: "int", nullable: true),
                    ItineraryNights = table.Column<int>(type: "int", nullable: true),
                    SailFrom = table.Column<int>(type: "int", nullable: true),
                    SailTo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Itineraries_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailFrom",
                        column: x => x.SailFrom,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Types_tbl_CruiseBooking_Cities_SailTo",
                        column: x => x.SailTo,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Companies_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyUserUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyUserName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Companies_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Companies_Users_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Companies_Users_tbl_CruiseBooking_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_CruiseBooking_Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    DestinationNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SejourCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    IsMainMenu = table.Column<bool>(type: "bit", nullable: true),
                    IsTravelGuide = table.Column<bool>(type: "bit", nullable: true),
                    DestinationMainVideo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IntroIsVideo = table.Column<bool>(type: "bit", nullable: true),
                    DestinationUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsPort = table.Column<bool>(type: "bit", nullable: true),
                    IsEmbarkationCruise = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DestinationStatus = table.Column<bool>(type: "bit", nullable: true),
                    DestinationMainPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerHeight = table.Column<int>(type: "int", nullable: true),
                    IsFetaure = table.Column<bool>(type: "bit", nullable: true),
                    DestinationMainPhotoPackages = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoCruises = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoExcursions = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoShore = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoTransfers = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoHotels = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainPhotoPackagesWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoCruisesWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoExcursionsWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoShoreWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoTransfersWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoHotelsWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoPackagesHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoCruisesHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoExcursionsHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoShoreHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoTransfersHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainPhotoHotelsHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerPackages = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerCruises = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerExcursions = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerShore = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerTransfers = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerHotels = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMainBannerPackagesWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerCruisesWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerExcursionsWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerShoreWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerTransfersWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerHotelsWidth = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerPackagesHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerCruisesHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerExcursionsHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerShoreHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerTransfersHeight = table.Column<int>(type: "int", nullable: true),
                    DestinationMainBannerHotelsHeight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Destinations_tbl_CruiseBooking_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tbl_CruiseBooking_Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Facilties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: true),
                    FacilityNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Facilties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilties_tbl_CruiseBooking_Facilities_Types_FacilityTypeId",
                        column: x => x.FacilityTypeId,
                        principalTable: "tbl_CruiseBooking_Facilities_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BrandUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    BrandPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BrandPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    BrandPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    BrandBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BrandBannerWidth = table.Column<int>(type: "int", nullable: true),
                    BrandBannerHeight = table.Column<int>(type: "int", nullable: true),
                    BrandTypeId = table.Column<int>(type: "int", nullable: true),
                    IsTravco = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Brands_tbl_Master_Brands_Types_BrandTypeId",
                        column: x => x.BrandTypeId,
                        principalTable: "tbl_Master_Brands_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Amenities_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalTableId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    AmenitiesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AmenitiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Amenities_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_CruiseBooking_Amenities_AmenitiesId",
                        column: x => x.AmenitiesId,
                        principalTable: "tbl_CruiseBooking_Amenities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Amenities_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cities_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cities_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_CruiseBooking_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cities_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Companies_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyAdress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Companies_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Companies_Contents_tbl_CruiseBooking_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_CruiseBooking_Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Companies_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Countries_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Countries_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Countries_Contents_tbl_CruiseBooking_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tbl_CruiseBooking_Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Countries_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cruises_Categories_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseCategoryId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    CruiseCategoryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cruises_Categories_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                        column: x => x.CruiseCategoryId,
                        principalTable: "tbl_CruiseBooking_Cruises_Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_Categories_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Decks_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    DeckName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Decks_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Decks_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Brands_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    BrandTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Brands_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Brands_Types_Contents_tbl_Master_Brands_Types_BrandTypeId",
                        column: x => x.BrandTypeId,
                        principalTable: "tbl_Master_Brands_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Brands_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Cabins_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CabinTypeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Cabins_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Cabins_Types_Contents_tbl_Master_Cabins_Types_CabinTypeId1",
                        column: x => x.CabinTypeId1,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Cabins_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_CabinStatuses_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinStatusId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    CabinStatusName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_CabinStatuses_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_CabinStatuses_Contents_tbl_Master_CabinStatuses_CabinStatusId",
                        column: x => x.CabinStatusId,
                        principalTable: "tbl_Master_CabinStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_CabinStatuses_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_DiningTypes_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiningTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    DiningTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_DiningTypes_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_DiningTypes_Contents_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                        column: x => x.DiningTypeId,
                        principalTable: "tbl_CruiseBooking_Dinings_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_DiningTypes_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Facilities_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Facilities_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilities_Types_Contents_tbl_CruiseBooking_Facilities_Types_FacilityTypeId",
                        column: x => x.FacilityTypeId,
                        principalTable: "tbl_CruiseBooking_Facilities_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilities_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_WeekDays_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDayName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    WeekDayNameShort = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    WeekDayId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_WeekDays_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_WeekDays_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_WeekDays_Contents_tbl_Master_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "tbl_Master_WeekDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Itineraries_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ItineraryTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Itineraries_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Types_Contents_tbl_Master_Itineraries_Types_ItineraryTypeId",
                        column: x => x.ItineraryTypeId,
                        principalTable: "tbl_Master_Itineraries_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Destinations_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    DestinationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DestinationIntro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LangStatus = table.Column<bool>(type: "bit", nullable: true),
                    DestinationMetatagTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DestinationMetatagDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Destinations_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Destinations_Contents_tbl_CruiseBooking_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "tbl_CruiseBooking_Destinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Destinations_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Facilties_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FacilityNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    FacilityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Facilties_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilties_Contents_tbl_Master_Facilties_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "tbl_Master_Facilties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Facilties_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Brands_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    BrandName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BrandIntro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MetatagTitleBrand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MetatagTitleDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BrandDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Brands_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_CruiseBooking_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "tbl_CruiseBooking_Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Brands_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseStatus = table.Column<bool>(type: "bit", nullable: true),
                    CabinNumbers = table.Column<int>(type: "int", nullable: true),
                    DeckNumbers = table.Column<int>(type: "int", nullable: true),
                    CruiseCategoryId = table.Column<int>(type: "int", nullable: true),
                    CruiseUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruisePhoto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseLogo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseBanner = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruisePhotoWidth = table.Column<int>(type: "int", nullable: true),
                    CruisePhotoHeight = table.Column<int>(type: "int", nullable: true),
                    CruiseLogoWidth = table.Column<int>(type: "int", nullable: true),
                    CruiseLogoHeight = table.Column<int>(type: "int", nullable: true),
                    CruiseBannerWidth = table.Column<int>(type: "int", nullable: true),
                    CruiseBannerHeight = table.Column<int>(type: "int", nullable: true),
                    CruiseDeckPlan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseDeckPlanWidth = table.Column<int>(type: "int", nullable: true),
                    CruiseDeckPlanHeight = table.Column<int>(type: "int", nullable: true),
                    CruisePosition = table.Column<int>(type: "int", nullable: true),
                    CruiseLength = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseWidth = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseHeight = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseOopeningYear = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseRenovationYear = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseReservationEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseGeneralEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseCheckIn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseCheckout = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsBooking = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsExpedia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsAgouda = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsFacebook = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsInstgram = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsX = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsSnapChat = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsTikTok = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WslinkdIn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsTripAdvisor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsYoutube = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsGoogle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WsBrandUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactGmName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactGmMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactGmEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactSalesName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactSalesMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactSalesEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactReservationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactReservationMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactReservationEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactFinanceName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactFininaceMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactFininaceEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactMarketingName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactMarketingMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactMarketingEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cruises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_tbl_CruiseBooking_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "tbl_CruiseBooking_Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_tbl_CruiseBooking_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_CruiseBooking_Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_tbl_CruiseBooking_Cruises_Categories_CruiseCategoryId",
                        column: x => x.CruiseCategoryId,
                        principalTable: "tbl_CruiseBooking_Cruises_Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CompanyUsers_Cruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyUserId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CompanyUsers_Cruises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CompanyUsers_Cruises_tbl_CruiseBooking_Companies_Users_CompanyUserId",
                        column: x => x.CompanyUserId,
                        principalTable: "tbl_CruiseBooking_Companies_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CompanyUsers_Cruises_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cruises_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    CruiseName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseDetails = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseIntro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseOverview = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseDining = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseAccommodation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseActivities = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseNote = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseTechnicalSpecifications = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cruises_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_Contents_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cruises_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoPosition = table.Column<int>(type: "int", nullable: true),
                    PhotoStatus = table.Column<bool>(type: "bit", nullable: true),
                    PhotoHieght = table.Column<int>(type: "int", nullable: true),
                    PhotoWidth = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cruises_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cruises_Photos_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    DeckPosition = table.Column<int>(type: "int", nullable: true),
                    DeckNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DeckPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeckPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    DeckPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Decks_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Dinings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiselId = table.Column<int>(type: "int", nullable: true),
                    DiningName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DiningHours = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DiningDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DressCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningCuisine = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningOpenFor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningMenu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningFolderName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiningTypeId = table.Column<int>(type: "int", nullable: true),
                    DiningUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Dinings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Dinings_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Dinings_tbl_CruiseBooking_Dinings_Types_DiningTypeId",
                        column: x => x.DiningTypeId,
                        principalTable: "tbl_CruiseBooking_Dinings_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Itineraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ItineraryMap = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    ItineraryTypeId = table.Column<int>(type: "int", nullable: true),
                    WeekDayId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ItineraryStatus = table.Column<bool>(type: "bit", nullable: true),
                    CityFromId = table.Column<int>(type: "int", nullable: true),
                    CityToId = table.Column<int>(type: "int", nullable: true),
                    OverviewPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Itineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityFromId",
                        column: x => x.CityFromId,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cities_CityToId",
                        column: x => x.CityToId,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_CruiseBooking_Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_CruiseBooking_Durations_DurationId",
                        column: x => x.DurationId,
                        principalTable: "tbl_CruiseBooking_Durations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_Itineraries_Types_ItineraryTypeId",
                        column: x => x.ItineraryTypeId,
                        principalTable: "tbl_Master_Itineraries_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Itineraries_tbl_Master_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "tbl_Master_WeekDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    SeasonNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Seasons_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_StandardRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardRateNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_StandardRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Cruises_Facilties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilitiyId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    FacilityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Cruises_Facilties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Cruises_Facilties_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Cruises_Facilties_tbl_Master_Facilties_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "tbl_Master_Facilties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Periods_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Periods_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cabins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    DeckId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    CabinNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinPhoto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinBanner = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinStatus = table.Column<bool>(type: "bit", nullable: true),
                    CabinPosition = table.Column<int>(type: "int", nullable: true),
                    CabinSize = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinPhotoWidth = table.Column<int>(type: "int", nullable: true),
                    CabinPhotoHeight = table.Column<int>(type: "int", nullable: true),
                    CabinBannerWidth = table.Column<int>(type: "int", nullable: true),
                    CabinBannerHeight = table.Column<int>(type: "int", nullable: true),
                    CabinMinPax = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinMaxPax = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsUpperDeckCabin = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_tbl_CruiseBooking_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "tbl_CruiseBooking_Decks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Dinings_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiningId = table.Column<int>(type: "int", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoPosition = table.Column<int>(type: "int", nullable: true),
                    PhotoStatus = table.Column<bool>(type: "bit", nullable: true),
                    PhotoHieght = table.Column<int>(type: "int", nullable: true),
                    PhotoWidth = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Dinings_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Dinings_Photos_tbl_CruiseBooking_Dinings_DiningId",
                        column: x => x.DiningId,
                        principalTable: "tbl_CruiseBooking_Dinings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_OperationDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    WeekDayId = table.Column<int>(type: "int", nullable: true),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    Operation_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OperationDay = table.Column<int>(type: "int", nullable: true),
                    OperationMonth = table.Column<int>(type: "int", nullable: true),
                    OperationYear = table.Column<int>(type: "int", nullable: true),
                    EmbarcationCityId = table.Column<int>(type: "int", nullable: true),
                    OperationDateStatus = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_OperationDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Cities_EmbarcationCityId",
                        column: x => x.EmbarcationCityId,
                        principalTable: "tbl_CruiseBooking_Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_OperationDates_tbl_CruiseBooking_Itineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "tbl_CruiseBooking_Itineraries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_OperationDates_tbl_Master_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "tbl_Master_WeekDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Itineraries_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Intro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Itineraries_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Contents_tbl_CruiseBooking_Itineraries_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "tbl_CruiseBooking_Itineraries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Itineraries_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Seasons_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    SeasonName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Seasons_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Seasons_Contents_tbl_CruiseBooking_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "tbl_CruiseBooking_Seasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Seasons_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    StandardRateId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Rates_tbl_CruiseBooking_StandardRates_StandardRateId",
                        column: x => x.StandardRateId,
                        principalTable: "tbl_CruiseBooking_StandardRates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_StandardRates_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardRateId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    StandardRateName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_StandardRates_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_Contents_tbl_CruiseBooking_StandardRates_StandardRateId",
                        column: x => x.StandardRateId,
                        principalTable: "tbl_CruiseBooking_StandardRates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_StandardRates_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    StandardRateId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    CabinPrice = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_CruiseBooking_StandardRates_StandardRateId",
                        column: x => x.StandardRateId,
                        principalTable: "tbl_CruiseBooking_StandardRates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_tbl_Master_Periods_Types_PeriodTypeId",
                        column: x => x.PeriodTypeId,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodNameSys = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Periods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Periods_tbl_CruiseBooking_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "tbl_CruiseBooking_Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Periods_tbl_CruiseBooking_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "tbl_CruiseBooking_Seasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Periods_tbl_Master_Periods_Types_PeriodTypeId",
                        column: x => x.PeriodTypeId,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Master_Periods_Types_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    PeriodTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    PeriodTypeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Master_Periods_Types_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Master_Periods_Types_Contents_tbl_Master_Periods_Types_PeriodTypeId1",
                        column: x => x.PeriodTypeId1,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cabins_Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinId = table.Column<int>(type: "int", nullable: true),
                    AmenityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cabins_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_CruiseBooking_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "tbl_CruiseBooking_Amenities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_Amenities_tbl_CruiseBooking_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "tbl_CruiseBooking_Cabins",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cabins_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    CabinName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CabinDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CabinIntro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cabins_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_Contents_tbl_CruiseBooking_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "tbl_CruiseBooking_Cabins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Cabins_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinId = table.Column<int>(type: "int", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoPosition = table.Column<int>(type: "int", nullable: true),
                    PhotoStatus = table.Column<bool>(type: "bit", nullable: true),
                    PhotoHieght = table.Column<int>(type: "int", nullable: true),
                    PhotoWidth = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Cabins_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Cabins_Photos_tbl_CruiseBooking_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "tbl_CruiseBooking_Cabins",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_OperationDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDateId = table.Column<int>(type: "int", nullable: false),
                    CabinTypeId = table.Column<int>(type: "int", nullable: false),
                    Allotment = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_OperationDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_OperationDates_tbl_CruiseBooking_OperationDates_OperationDateId",
                        column: x => x.OperationDateId,
                        principalTable: "tbl_CruiseBooking_OperationDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_OperationDates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodTypeId = table.Column<int>(type: "int", nullable: true),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    CabinTypeId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<float>(type: "real", nullable: true),
                    Percentage = table.Column<float>(type: "real", nullable: true),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: true),
                    IsPositiveSign = table.Column<bool>(type: "bit", nullable: true),
                    CabinPriceSingle = table.Column<float>(type: "real", nullable: true),
                    CabinPriceDouble = table.Column<float>(type: "real", nullable: true),
                    CabinPriceTriple = table.Column<float>(type: "real", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_Master_Cabins_Types_CabinTypeId",
                        column: x => x.CabinTypeId,
                        principalTable: "tbl_Master_Cabins_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_tbl_Master_Periods_Types_PeriodTypeId",
                        column: x => x.PeriodTypeId,
                        principalTable: "tbl_Master_Periods_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Rates_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    ContentLangStatus = table.Column<bool>(type: "bit", nullable: true),
                    RateName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Rates_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Rates_Contents_tbl_CruiseBooking_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "tbl_CruiseBooking_Rates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Rates_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CruiseBooking_Periods_Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    PeriodId = table.Column<int>(type: "int", nullable: true),
                    PeriodName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    PeriodId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CruiseBooking_Periods_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Periods_Contents_tbl_CruiseBooking_Periods_PeriodId1",
                        column: x => x.PeriodId1,
                        principalTable: "tbl_CruiseBooking_Periods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_CruiseBooking_Periods_Contents_tbl_Master_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_Master_Languages",
                        principalColumn: "Id");
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
                name: "Index_AppName",
                table: "ASPStateTempApplications",
                column: "AppName");

            migrationBuilder.CreateIndex(
                name: "Index_Expires",
                table: "ASPStateTempSessions",
                column: "Expires");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Content_AmenityId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "OriginalTableId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Content_LangId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Amenities_Contents_AmenitiesId",
                table: "tbl_CruiseBooking_Amenities_Contents",
                column: "AmenitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Brands_BrandTypeId",
                table: "tbl_CruiseBooking_Brands",
                column: "BrandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Brands_Content_BrandId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Brands_Content_LangId",
                table: "tbl_CruiseBooking_Brands_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_CabinTypeId",
                table: "tbl_CruiseBooking_Cabins",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_CruiseId",
                table: "tbl_CruiseBooking_Cabins",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_DeckId",
                table: "tbl_CruiseBooking_Cabins",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_Amenities_AmenityId",
                table: "tbl_CruiseBooking_Cabins_Amenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_Amenities_CabinId",
                table: "tbl_CruiseBooking_Cabins_Amenities",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_Content_CabinId",
                table: "tbl_CruiseBooking_Cabins_Contents",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_Content_LangId",
                table: "tbl_CruiseBooking_Cabins_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cabins_Photos_CabinId",
                table: "tbl_CruiseBooking_Cabins_Photos",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_OperationDates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_OperationDates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_OperationDates_OperationDateId",
                table: "tbl_CruiseBooking_CabinTypes_OperationDates",
                column: "OperationDateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_PeriodTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates_RateId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_CabinTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_PeriodTypeId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates_StandardRateId",
                table: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates",
                column: "StandardRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cities_Contents_CityId",
                table: "tbl_CruiseBooking_Cities_Contents",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cities_Contents_LanguageId",
                table: "tbl_CruiseBooking_Cities_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Companies_Content_CompanyId",
                table: "tbl_CruiseBooking_Companies_Contents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Companies_Content_LanguageId",
                table: "tbl_CruiseBooking_Companies_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Companies_Users_CompanyId",
                table: "tbl_CruiseBooking_Companies_Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Companies_Users_UserId",
                table: "tbl_CruiseBooking_Companies_Users",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CompanyUsers_Cruises_CompanyUserId",
                table: "tbl_CruiseBooking_CompanyUsers_Cruises",
                column: "CompanyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_CompanyUsers_Cruises_CruiseId",
                table: "tbl_CruiseBooking_CompanyUsers_Cruises",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Countries_Contents_CountryId",
                table: "tbl_CruiseBooking_Countries_Contents",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Countries_Contents_LanguageId",
                table: "tbl_CruiseBooking_Countries_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_BrandId",
                table: "tbl_CruiseBooking_Cruises",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_CompanyId",
                table: "tbl_CruiseBooking_Cruises",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_CruiseCategoryId",
                table: "tbl_CruiseBooking_Cruises",
                column: "CruiseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Categories_Content_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "CruiseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Categories_Content_LangId",
                table: "tbl_CruiseBooking_Cruises_Categories_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Content_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Contents",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Content_LangId",
                table: "tbl_CruiseBooking_Cruises_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Cruises_Photos_CruiseId",
                table: "tbl_CruiseBooking_Cruises_Photos",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Decks_CruiseId",
                table: "tbl_CruiseBooking_Decks",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Decks_Content_DeckId",
                table: "tbl_CruiseBooking_Decks_Contents",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Decks_Content_LangId",
                table: "tbl_CruiseBooking_Decks_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Destinations_CountryId",
                table: "tbl_CruiseBooking_Destinations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Destinations_Content_DestinationId",
                table: "tbl_CruiseBooking_Destinations_Contents",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Destinations_Content_LangId",
                table: "tbl_CruiseBooking_Destinations_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Dinings_CruiseId",
                table: "tbl_CruiseBooking_Dinings",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Dinings_DiningTypeId",
                table: "tbl_CruiseBooking_Dinings",
                column: "DiningTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Dinings_Photos_DiningId",
                table: "tbl_CruiseBooking_Dinings_Photos",
                column: "DiningId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_CityFromId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityFromId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_CityToId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CityToId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_CompanyId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_CruiseId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_DurationId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_ItineraryTypeId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "ItineraryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Itineraries_WeekDayId",
                table: "tbl_CruiseBooking_Itineraries",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_CruiseId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_EmbarcationCityId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "EmbarcationCityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_ItineraryId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_OperationDates_WeekDayId",
                table: "tbl_CruiseBooking_OperationDates",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_CruiseId",
                table: "tbl_CruiseBooking_Periods",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_PeriodTypeId",
                table: "tbl_CruiseBooking_Periods",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_SeasonId",
                table: "tbl_CruiseBooking_Periods",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_Contents_LanguageId",
                table: "tbl_CruiseBooking_Periods_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_Contents_PeriodId",
                table: "tbl_CruiseBooking_Periods_Contents",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_Contents_PeriodId1",
                table: "tbl_CruiseBooking_Periods_Contents",
                column: "PeriodId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Rates_CruiseId",
                table: "tbl_CruiseBooking_Rates",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Rates_StandardRateId",
                table: "tbl_CruiseBooking_Rates",
                column: "StandardRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Rates_Contents_LanguageId",
                table: "tbl_CruiseBooking_Rates_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Rates_Contents_RateId",
                table: "tbl_CruiseBooking_Rates_Contents",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Seasons_CruiseId",
                table: "tbl_CruiseBooking_Seasons",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Seasons_Contents_LanguageId",
                table: "tbl_CruiseBooking_Seasons_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Seasons_Contents_SeasonId",
                table: "tbl_CruiseBooking_Seasons_Contents",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_CruiseId",
                table: "tbl_CruiseBooking_StandardRates",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_Contents_LanguageId",
                table: "tbl_CruiseBooking_StandardRates_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_StandardRates_Contents_StandardRateId",
                table: "tbl_CruiseBooking_StandardRates_Contents",
                column: "StandardRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Brands_Types_Contents_BrandTypeId",
                table: "tbl_Master_Brands_Types_Contents",
                column: "BrandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Brands_Types_Contents_LanguageId",
                table: "tbl_Master_Brands_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Cabins_Types_Contents_CabinTypeId",
                table: "tbl_Master_Cabins_Types_Contents",
                column: "CabinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Cabins_Types_Contents_CabinTypeId1",
                table: "tbl_Master_Cabins_Types_Contents",
                column: "CabinTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Cabins_Types_Contents_LanguageId",
                table: "tbl_Master_Cabins_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_CabinStatuses_Contents_CabinStatusId",
                table: "tbl_Master_CabinStatuses_Contents",
                column: "CabinStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_CabinStatuses_Contents_LanguageId",
                table: "tbl_Master_CabinStatuses_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Cruises_Facilties_CruiseId",
                table: "tbl_Master_Cruises_Facilties",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Cruises_Facilties_FacilityId",
                table: "tbl_Master_Cruises_Facilties",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_DiningTypes_Contents_DiningTypeId",
                table: "tbl_Master_DiningTypes_Contents",
                column: "DiningTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_DiningTypes_Contents_LanguageId",
                table: "tbl_Master_DiningTypes_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilities_Types_Contents_FacilityTypeId",
                table: "tbl_Master_Facilities_Types_Contents",
                column: "FacilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilities_Types_Contents_LanguageId",
                table: "tbl_Master_Facilities_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilties_FacilityTypeId",
                table: "tbl_Master_Facilties",
                column: "FacilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilties_Contents_FacilityId",
                table: "tbl_Master_Facilties_Contents",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Facilties_Contents_LanguageId",
                table: "tbl_Master_Facilties_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Contents_ItineraryId",
                table: "tbl_Master_Itineraries_Contents",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Contents_LanguageId",
                table: "tbl_Master_Itineraries_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Types_SailFrom",
                table: "tbl_Master_Itineraries_Types",
                column: "SailFrom");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Types_SailTo",
                table: "tbl_Master_Itineraries_Types",
                column: "SailTo");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Types_Contents_ItineraryTypeId",
                table: "tbl_Master_Itineraries_Types_Contents",
                column: "ItineraryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Itineraries_Types_Contents_LanguageId",
                table: "tbl_Master_Itineraries_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CruiseBooking_Periods_Types_CruiseId",
                table: "tbl_Master_Periods_Types",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_LanguageId",
                table: "tbl_Master_Periods_Types_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_PeriodTypeId",
                table: "tbl_Master_Periods_Types_Contents",
                column: "PeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_Periods_Types_Contents_PeriodTypeId1",
                table: "tbl_Master_Periods_Types_Contents",
                column: "PeriodTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_WeekDays_Contents_LanguageId",
                table: "tbl_Master_WeekDays_Contents",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Master_WeekDays_Contents_WeekDayId",
                table: "tbl_Master_WeekDays_Contents",
                column: "WeekDayId");
        }

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
                name: "ASPStateTempApplications");

            migrationBuilder.DropTable(
                name: "ASPStateTempSessions");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Amenities_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Brands_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cabins_Amenities");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cabins_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cabins_Photos");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_OperationDates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_Rates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CabinTypes_PeriodTypes_StandardRates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cities_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Companies_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_CompanyUsers_Cruises");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Countries_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cruises_Categories_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cruises_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cruises_Photos");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Decks_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Destinations_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Dinings_Photos");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Periods_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Rates_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Seasons_Contents");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_StandardRates_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Brands_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Cabins_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_CabinStatuses_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Cruises_Facilties");

            migrationBuilder.DropTable(
                name: "tbl_Master_DiningTypes_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Facilities_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Facilties_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Itineraries_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Itineraries_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_Periods_Types_Contents");

            migrationBuilder.DropTable(
                name: "tbl_Master_WeekDays_Contents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Amenities");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cabins");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_OperationDates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Companies_Users");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Destinations");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Dinings");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Periods");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Rates");

            migrationBuilder.DropTable(
                name: "tbl_Master_CabinStatuses");

            migrationBuilder.DropTable(
                name: "tbl_Master_Facilties");

            migrationBuilder.DropTable(
                name: "tbl_Master_Languages");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Decks");

            migrationBuilder.DropTable(
                name: "tbl_Master_Cabins_Types");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Itineraries");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Countries");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Dinings_Types");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Seasons");

            migrationBuilder.DropTable(
                name: "tbl_Master_Periods_Types");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_StandardRates");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Facilities_Types");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Durations");

            migrationBuilder.DropTable(
                name: "tbl_Master_Itineraries_Types");

            migrationBuilder.DropTable(
                name: "tbl_Master_WeekDays");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cruises");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cities");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Brands");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Companies");

            migrationBuilder.DropTable(
                name: "tbl_CruiseBooking_Cruises_Categories");

            migrationBuilder.DropTable(
                name: "tbl_Master_Brands_Types");
        }
    }
}
