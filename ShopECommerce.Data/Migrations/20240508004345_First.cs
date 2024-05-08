using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooterTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooterDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoogleMapsApi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Featurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Featurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShopTableId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_ShopTables_ShopTableId",
                        column: x => x.ShopTableId,
                        principalTable: "ShopTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedDate", "Price1", "Price2", "Status", "SubTitle", "Title", "Url", "UrlLabel" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(195), null, "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "/WebT/img/baner-1.png", false, null, "1", "50", true, "in Our Store", "Fresh Exotic Fruits", "#", "BUY" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Fruites", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8606), null, false, null, true },
                    { 2, "Vesitables", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8609), null, false, null, true }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FooterDescription", "FooterTitle", "GoogleMapsApi", "IsDeleted", "Location", "Mail", "ModifiedDate", "Phone", "SiteName", "SiteTitle", "SiteUrl", "Status" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(221), null, "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the like Aldus PageMaker including of Lorem Ipsum.", "Why People Like us!", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d387191.33750346623!2d-73.97968099999999!3d40.6974881!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew%20York%2C%20NY%2C%20USA!5e0!3m2!1sen!2sbd!4v1694259649153!5m2!1sen!2sbd", false, "1429 Netus Rd, NY 48247", "Example@gmail.com", null, "+0123 4567 8910", "Fruitables", "Fresh products", "www.fruitables.com", true });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "20%", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9987), null, "OFF", "/WebT/img/featur-1.jpg", false, null, true, "Fresh Apples" },
                    { 2, "", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9989), null, "Free delivery", "/WebT/img/featur-2.jpg", false, null, true, "Tasty Fruits" },
                    { 3, "30$", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9991), null, "Discount", "/WebT/img/featur-3.jpg", false, null, true, "Exotic Vegitable" }
                });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(166), null, "1963", "fa fa-users text-secondary", false, null, true, "SATISFIED CUSTOMERS" },
                    { 2, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(168), null, "99%", "fa fa-users text-secondary", false, null, true, "QUALITY OF SERVICE" },
                    { 3, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(170), null, "33", "fa fa-users text-secondary", false, null, true, "QUALITY CERTIFICATES" },
                    { 4, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(171), null, "789", "fa fa-users text-secondary", false, null, true, "AVAILABLE PRODUCTS" }
                });

            migrationBuilder.InsertData(
                table: "Featurs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(82), null, "Free on order over $300", "fas fa-car-side fa-3x text-white", false, null, true, "Free Shipping" },
                    { 2, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(138), null, "100% security payment", "fas fa-user-shield fa-3x text-white", false, null, true, "Security Payment" },
                    { 3, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(139), null, "30 day money guarantee", "fas fa-exchange-alt fa-3x text-white", false, null, true, "30 Day Return" },
                    { 4, new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(140), null, "Support every time fast", "fa fa-phone-alt fa-3x text-white", false, null, true, "24/7 Support" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8552), null, false, null, "Admin", true },
                    { 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8588), null, false, null, "User", true }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImageUrl1", "ImageUrl2", "IsDeleted", "Label1", "Label2", "ModifiedDate", "Status", "Title", "Url1", "Url2" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9965), null, "Organic Veggies & Fruits Foods", "/WebT/img/hero-img-1.png", "/WebT/img/hero-img-2.jpg", false, "Fruites", "Vesitables", null, true, "100% Organic Foods", "#", "#" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Cls", "CreatedDate", "DeletedDate", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9931), null, "fab fa-facebook-f", false, null, true, "Facebook", "http://www.facebook.com" },
                    { 2, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9933), null, "fab fa-youtube", false, null, true, "Youtube", "http://www.youtube.com" },
                    { 3, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9935), null, "fab fa-linkedin-in", false, null, true, "Linkedin", "http://www.linkedin.com" },
                    { 4, "btn btn-outline-secondary btn-md-square rounded-circle", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9937), null, "fab fa-twitter", false, null, true, "Twitter", "http://www.x.com" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Comment", "CreatedDate", "DeletedDate", "ImageUrl", "IsDeleted", "ModifiedDate", "Name", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9906), null, "/WebT/img/testimonial-1.jpg", false, null, "Şebnem Ferah", true, "Şef Aşçı" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9908), null, "/WebT/img/testimonial-1.jpg", false, null, "Teoman Yakupoğlu", true, "Şef Aşçı" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8635), null, false, null, true, "Grapes" },
                    { 2, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8637), null, false, null, true, "Raspberries" },
                    { 3, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8638), null, false, null, true, "Apricots" },
                    { 4, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8639), null, false, null, true, "Banana" },
                    { 5, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8640), null, false, null, true, "Oranges" },
                    { 6, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8643), null, false, null, true, "Apple" },
                    { 7, 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8644), null, false, null, true, "Patatoes" },
                    { 8, 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8645), null, false, null, true, "Persely" },
                    { 9, 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8647), null, false, null, true, "Tomato" },
                    { 10, 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8670), null, false, null, true, "Brocoli" },
                    { 11, 2, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8672), null, false, null, true, "Bell Papper" },
                    { 12, 1, new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(8673), null, false, null, true, "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "Description", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedDate", "Password", "Phone", "RoleId", "Status", "Username" },
                values: new object[] { 1, "Ankara", new DateTime(2024, 5, 8, 3, 43, 43, 513, DateTimeKind.Local).AddTicks(9845), null, "x", "admin@test.com", "Şebnem", false, "Ferah", null, "CfDJ8Lhzc99II2tHnoigxoZuezO_Stk7ns_bmZu2o_J9yFFnWUTX05419eQcu4wDglwjfDik2SYzc5sGQM3_nsbGnd05Ox62s0DmjRm-3wYfeXOQo-p86gVzqgFY2U2kAO-OvA", "0850", 1, true, "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CountryOfOrigin", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "MinWeight", "ModifiedDate", "Price", "ProductName", "ProductTitle", "Quality", "Status", "SubCategoryId", "Weight", "Сheck" },
                values: new object[,]
                {
                    { 1, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(15), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-5.jpg", false, 0.250m, null, 4.95m, "Native Grapes", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 1, 1m, "Healthy" },
                    { 2, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(23), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-2.jpg", false, 0.250m, null, 4.95m, "Native Raspberries", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 2, 1m, "Healthy" },
                    { 3, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(26), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-4.jpg", false, 0.250m, null, 4.95m, "Native Apricots", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 3, 1m, "Healthy" },
                    { 4, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(29), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-3.jpg", false, 0.250m, null, 4.95m, "Native Banana", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 4, 1m, "Healthy" },
                    { 5, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(32), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-1.jpg", false, 0.250m, null, 4.95m, "Native Oranges", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 5, 1m, "Healthy" },
                    { 6, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(36), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-1.jpg", false, 0.250m, null, 4.95m, "Native Apple", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 6, 1m, "Healthy" },
                    { 7, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(40), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-5.jpg", false, 0.250m, null, 4.95m, "Native Patatoes", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 7, 1m, "Healthy" },
                    { 8, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(42), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-6.jpg", false, 0.250m, null, 4.95m, "Native Persely", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 8, 1m, "Healthy" },
                    { 9, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(45), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-1.jpg", false, 0.250m, null, 4.95m, "Native Tomato", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 9, 1m, "Healthy" },
                    { 10, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(48), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-3.jpg", false, 0.250m, null, 4.95m, "Native Brocoli", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 10, 1m, "Healthy" },
                    { 11, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(51), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-4.jpg", false, 0.250m, null, 4.95m, "Native Bell Papper", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 11, 1m, "Healthy" },
                    { 12, "Agro Farm", new DateTime(2024, 5, 8, 3, 43, 43, 514, DateTimeKind.Local).AddTicks(54), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-2.jpg", false, 0.250m, null, 4.95m, "Native Strawberry", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 12, 1m, "Healthy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ShopTableId",
                table: "Baskets",
                column: "ShopTableId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Facts");

            migrationBuilder.DropTable(
                name: "Featurs");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "MoneyCases");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ShopTables");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
