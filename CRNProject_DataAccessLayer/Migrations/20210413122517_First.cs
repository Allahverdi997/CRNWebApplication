using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRNProject_DataAccessLayer.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AltIndustryImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltIndustrImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltIndustryImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPoliticies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPoliticies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstantValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CookiesPolitics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookiesPolitics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPageInformationTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPageInformationTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityPolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abouts_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sliders_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProitId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainIndustries_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainIndustries_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MainProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsProductMainActive = table.Column<bool>(type: "bit", nullable: false),
                    IsApplicationMainActive = table.Column<bool>(type: "bit", nullable: false),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCopyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainProducts_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AltIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    MainProductId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltIndustries_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AltIndustries_MainProducts_MainProductId",
                        column: x => x.MainProductId,
                        principalTable: "MainProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    LangTableId = table.Column<int>(type: "int", nullable: true),
                    MainProductId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltProducts_LangTables_LangTableId",
                        column: x => x.LangTableId,
                        principalTable: "LangTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AltProducts_MainProducts_MainProductId",
                        column: x => x.MainProductId,
                        principalTable: "MainProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltIndustryId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyProperty_AltIndustries_AltIndustryId",
                        column: x => x.AltIndustryId,
                        principalTable: "AltIndustries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltProductFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltProductId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltProductFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltProductFiles_AltProducts_AltProductId",
                        column: x => x.AltProductId,
                        principalTable: "AltProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageVideoAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltProductId = table.Column<int>(type: "int", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltProductImages_AltProducts_AltProductId",
                        column: x => x.AltProductId,
                        principalTable: "AltProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_LangTableId",
                table: "Abouts",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_AltIndustries_LangTableId",
                table: "AltIndustries",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_AltIndustries_MainProductId",
                table: "AltIndustries",
                column: "MainProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AltProductFiles_AltProductId",
                table: "AltProductFiles",
                column: "AltProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AltProductImages_AltProductId",
                table: "AltProductImages",
                column: "AltProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AltProducts_LangTableId",
                table: "AltProducts",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_AltProducts_MainProductId",
                table: "AltProducts",
                column: "MainProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LangTableId",
                table: "Categories",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MenuId",
                table: "Categories",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MainIndustries_CategoryId",
                table: "MainIndustries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MainIndustries_LangTableId",
                table: "MainIndustries",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_MainProducts_CategoryId",
                table: "MainProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MainProducts_LangTableId",
                table: "MainProducts",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_LangTableId",
                table: "Menus",
                column: "LangTableId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_AltIndustryId",
                table: "MyProperty",
                column: "AltIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_LangTableId",
                table: "Sliders",
                column: "LangTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AltIndustryImages");

            migrationBuilder.DropTable(
                name: "AltProductFiles");

            migrationBuilder.DropTable(
                name: "AltProductImages");

            migrationBuilder.DropTable(
                name: "CompanyPoliticies");

            migrationBuilder.DropTable(
                name: "ConstantValues");

            migrationBuilder.DropTable(
                name: "ContactMails");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CookiesPolitics");

            migrationBuilder.DropTable(
                name: "MainIndustries");

            migrationBuilder.DropTable(
                name: "MainPageInformationTitles");

            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropTable(
                name: "SecurityPolicies");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "AltProducts");

            migrationBuilder.DropTable(
                name: "AltIndustries");

            migrationBuilder.DropTable(
                name: "MainProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "LangTables");
        }
    }
}
