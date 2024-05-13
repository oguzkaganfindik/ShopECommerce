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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImagePath1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmCode = table.Column<int>(type: "int", nullable: true),
                    ResetCode = table.Column<int>(type: "int", nullable: true),
                    ChangeMailCode = table.Column<int>(type: "int", nullable: true),
                    NewEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImagePath", "IsDeleted", "ModifiedDate", "Price1", "Price2", "Status", "SubTitle", "Title", "Url", "UrlLabel" },
                values: new object[] { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2070), null, "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "/WebT/img/baner-1.png", false, null, "1", "50", true, "in Our Store", "Fresh Exotic Fruits", "/Shop/Index/", "BUY" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Fruites", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(539), null, false, null, true },
                    { 2, "Vesitables", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(542), null, false, null, true }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FooterDescription", "FooterTitle", "GoogleMapsApi", "IsDeleted", "Location", "Mail", "ModifiedDate", "Phone", "SiteName", "SiteTitle", "SiteUrl", "Status" },
                values: new object[] { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2093), null, "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the like Aldus PageMaker including of Lorem Ipsum.", "Why People Like us!", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d387191.33750346623!2d-73.97968099999999!3d40.6974881!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew%20York%2C%20NY%2C%20USA!5e0!3m2!1sen!2sbd!4v1694259649153!5m2!1sen!2sbd", false, "1429 Netus Rd, NY 48247", "Example@gmail.com", null, "+0123 4567 8910", "Fruitables", "Fresh products", "www.fruitables.com", true });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "Description", "ImagePath", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "20%", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1871), null, "OFF", "/WebT/img/featur-1.jpg", false, null, true, "Fresh Apples" },
                    { 2, "", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1873), null, "Free delivery", "/WebT/img/featur-2.jpg", false, null, true, "Tasty Fruits" },
                    { 3, "30$", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1875), null, "Discount", "/WebT/img/featur-3.jpg", false, null, true, "Exotic Vegitable" }
                });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2041), null, "1963", "fa fa-users text-secondary", false, null, true, "SATISFIED CUSTOMERS" },
                    { 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2043), null, "99%", "fa fa-users text-secondary", false, null, true, "QUALITY OF SERVICE" },
                    { 3, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2044), null, "33", "fa fa-users text-secondary", false, null, true, "QUALITY CERTIFICATES" },
                    { 4, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2046), null, "789", "fa fa-users text-secondary", false, null, true, "AVAILABLE PRODUCTS" }
                });

            migrationBuilder.InsertData(
                table: "Featurs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2010), null, "Free on order over $300", "fas fa-car-side fa-3x text-white", false, null, true, "Free Shipping" },
                    { 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2013), null, "100% security payment", "fas fa-user-shield fa-3x text-white", false, null, true, "Security Payment" },
                    { 3, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2014), null, "30 day money guarantee", "fas fa-exchange-alt fa-3x text-white", false, null, true, "30 Day Return" },
                    { 4, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(2016), null, "Support every time fast", "fa fa-phone-alt fa-3x text-white", false, null, true, "24/7 Support" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(418), null, false, null, "Admin", true },
                    { 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(505), null, false, null, "User", true },
                    { 3, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(522), null, false, null, "Customer", true }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImagePath1", "ImagePath2", "IsDeleted", "Label1", "Label2", "ModifiedDate", "Status", "Title", "Url1", "Url2" },
                values: new object[] { 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1848), null, "Organic Veggies & Fruits Foods", "/WebT/img/hero-img-1.png", "/WebT/img/hero-img-2.jpg", false, "Fruites", "Vesitables", null, true, "100% Organic Foods", "#", "#" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Cls", "CreatedDate", "DeletedDate", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1814), null, "fab fa-facebook-f", false, null, true, "Facebook", "http://www.facebook.com" },
                    { 2, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1817), null, "fab fa-youtube", false, null, true, "Youtube", "http://www.youtube.com" },
                    { 3, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1819), null, "fab fa-linkedin-in", false, null, true, "Linkedin", "http://www.linkedin.com" },
                    { 4, "btn btn-outline-secondary btn-md-square rounded-circle", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1820), null, "fab fa-twitter", false, null, true, "Twitter", "http://www.x.com" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Comment", "CreatedDate", "DeletedDate", "ImagePath", "IsDeleted", "ModifiedDate", "Name", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1786), null, "/WebT/img/testimonial-1.jpg", false, null, "Şebnem Ferah", true, "Şef Aşçı" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1791), null, "/WebT/img/testimonial-1.jpg", false, null, "Teoman Yakupoğlu", true, "Şef Aşçı" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(567), null, false, null, true, "Grapes" },
                    { 2, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(601), null, false, null, true, "Raspberries" },
                    { 3, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(603), null, false, null, true, "Apricots" },
                    { 4, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(604), null, false, null, true, "Banana" },
                    { 5, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(606), null, false, null, true, "Oranges" },
                    { 6, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(608), null, false, null, true, "Apple" },
                    { 7, 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(609), null, false, null, true, "Patatoes" },
                    { 8, 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(610), null, false, null, true, "Persely" },
                    { 9, 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(612), null, false, null, true, "Tomato" },
                    { 10, 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(614), null, false, null, true, "Brocoli" },
                    { 11, 2, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(615), null, false, null, true, "Bell Papper" },
                    { 12, 1, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(617), null, false, null, true, "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ChangeMailCode", "ConfirmCode", "CreatedDate", "DeletedDate", "Description", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "ModifiedDate", "NewEmail", "Password", "Phone", "ResetCode", "RoleId", "Status", "UserGuid", "Username" },
                values: new object[] { 1, "Ankara", null, null, new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1737), null, "x", "admin@test.com", false, "Şebnem", false, "Ferah", null, null, "CfDJ8Lhzc99II2tHnoigxoZuezOWTREkXTPEHXw8BcUk3E4Y38mlpBHxDVYTP3DHG393xifWbMgZnPR5pkYfSIN8NCcNL_XdYXcQElrBfb3ZHs9Rw-2hVZ4J6FeVWXYJsTrayQ", "0850", null, 1, true, new Guid("2e3b9467-2702-446b-8d13-f485292a123f"), "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CountryOfOrigin", "CreatedDate", "DeletedDate", "Description", "ImagePath", "IsDeleted", "MinWeight", "ModifiedDate", "Price", "ProductName", "ProductTitle", "Quality", "Status", "SubCategoryId", "Weight", "Сheck" },
                values: new object[,]
                {
                    { 1, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1902), null, "Yeşil üzümler de siyah üzümler gibi antioksidan içerir ve özellikle C ve K vitaminleri açısından çok zengindir. İçerdiği yüksek C ve K vitaminleri sayesinde bağışıklık sistemini güçlendirerek cilt sağlığını destekleyebilir, ayrıca K vitamini sayesinde kalp ve damar sağlığına olumlu katkıda bulunabilir. Yeşil üzümün faydaları arasında tıpkı siyah üzüm gibi damar sağlığı ve dolaşıma desteği vardır. Bunun yanı sıra siyah üzümün tersine kandaki HDL (yüksek yoğunluklu lipoprotein) ya da iyi kolesterolü arttırdığı gözlenmiştir. Kandaki yağ miktarını dengeleyen yeşil üzümün aynı zamanda karın bölgesinde oluşan ve özellikle organ yağlanmasına işaret eden göbek yağlarını da erittiği tespit edilmiştir. Siyah üzümlere kıyasla yeşil üzümlerde antosiyanin oranı daha düşük olsa da yeşil üzümler stilbenler açısından oldukça zengindir. Stilbenler, bitkinin stres yanıtına karşılık olarak ürettiği moleküler bileşenlerdir ve insan sağlığı için kritik öneme sahiplerdir. Bunlardan en önemlisi olan resveratrolün hastalıkların gelişmesini ya da ilerlemesini önlediği keşfedilmiştir. Dolayısıyla yeşil üzümün faydaları dendiğinde en önemli noktalardan biri kabuğundaki resveratrol miktardır. Bu sayede tıpkı koyu renkli üzümler gibi yeşil üzümler de vücudu enfeksiyona karşı koruyarak daha dirençli bir hale getirir. Hücresel boyutta bakıldığında üzümün içinde bulunan bileşenler hücrelerin işlevlerini desteklerken yapısal bozukluklarını önler. Bu nedenle hücre yapısının bozulmasından kaynaklanan kanser için de önleyici ve koruyucu bir etkiye sahiptir.", "/WebT/img/fruite-item-5.jpg", false, 0.250m, null, 4.95m, "Native Grapes", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 1, 1m, "Healthy" },
                    { 2, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1909), null, "Gülgiller ailesinden olan frambuaz, ülkemizde ahududu olarak bilinir (İng.raspberry). Doğada yaklaşık 200 kadar çeşidi olduğu bilinmektedir. Kırmızı/pembe renklerdeki bu meyve tam bir antioksidant deposudur.Diğer tüm minik taneli meyvelerde olduğu gibi C vitamini yönünden zengindir, antioksidant (kansere karşı koruyucu) aktivitesi yüksektir.rambuaz/ahududu ile ilgili yapılan çoğu araştırma antioksidant etkisi ve kalp damar sağlığı üzerindeki faydalarıyla ilgilidir. Bu araştırma sonuçlarına göre östrojen kaynaklı meme tümörlerinin oluşumunu engelleyici, mide ve kalın barsak (kolon) kanseri risklerini azaltıcı etkileri ortaya çıkarılmıştır. Ayrıca kan sulandırıcı/pıhtı çözücü etkisi sayesinde ateroskleroz (damar tıkanıklığı) oluşumunu azaltarak kalp damar hastalığı risklerini azaltmaktadır. Bazı araştırmalar karaciğer lezyonları üzerinde iyileştirici etkisinin olduğunu da göstermektedir. Kan sulandırıcı (antikoagülant) etkisi nedeni ile bazı ilaçların (özellikle pıhtı çözücü) aktivitelerini bozabileceği için hastaların bu meyveyi tüketirken mutlaka doktorlarına danışmaları gerekmektedir. Aynı zamanda antienflamatuar (iltihap önleyici) etkisi sayesinde iltihabi rahatsızlıkların tedavisinde bağışıklık sistemini destekleyici etkisi de vardır.", "/WebT/img/fruite-item-2.jpg", false, 0.250m, null, 4.95m, "Native Raspberries", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 2, 1m, "Healthy" },
                    { 3, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1913), null, "Lif açısından zengindir: Kuru kayısı, sindirim sistemi sağlığı için önemli olan lif açısından zengindir. Lif, kabızlığı önleyebilir ve bağırsak hareketlerini düzenleyebilir.\r\n\r\nVitamin ve mineral kaynağıdır: Kuru kayısı, C vitamini, A vitamini, potasyum ve demir gibi vitamin ve mineraller açısından zengindir. Bu vitamin ve mineraller, vücut fonksiyonlarının düzgün çalışmasını sağlayabilir ve bağışıklık sisteminin güçlenmesine yardımcı olabilir.\r\n\r\nDüşük kalorili bir atıştırmalık: Kuru kayısı, düşük kalorili bir atıştırmalık seçeneğidir. Oruçlu zamanlarda tokluk hissini artırmaya yardımcı olabilir.\r\n\r\nAncak, hurma ve kuru kayısı gibi kuruyemişler yüksek şeker içeriği nedeniyle aşırı tüketilmemelidir. Oruçlu zamanlarda ölçülü tüketmeye dikkat edin. Ayrıca, özellikle şeker hastalığı gibi bir sağlık sorununuz varsa, hurma ve kuru kayısı tüketimini doktorunuzla konuşmanız önerilir.", "/WebT/img/fruite-item-4.jpg", false, 0.250m, null, 4.95m, "Native Apricots", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 3, 1m, "Healthy" },
                    { 4, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1918), null, "Muz, dünyada en çok yetiştirilen tropik meyvelerden biridir. Bazen şeker ihtiyacımızı giderme, bazen tok tutması için yediğimiz muz, en sevilen ve en çok tüketilen meyvelerden olup; yüksek besin ögesi içeriğiyle dikkat çeker. Kolay sindirilebilen karbonhidrat içeriği ve yumuşak dokusu sayesinde tüm yaş grupları arasında yaygın olarak tercih edilir. Çocukların da severek tükettiği bu tatlı besleyici meyvenin sağlığa pek çok faydası olduğu bilinir. Sindirim sisteminden kemik sağlığına, bağırsak hastalarından kansere, kalp sağlığından beyin sağlığına kadar muz tüketiminin faydaları saymakla bitmez. Her gün muz yemek için sebep çok.\r\n\r\n\r\nPotasyumun Gücü\r\n“Muzun faydaları nelerdir?” deyince akla hemen potasyum içeriği gelir. Muzda yüksek miktarda bulunan potasyum minerali sıvı dengesinin düzenlenmesine yardım eden önemli bir elektrolittir. Potasyum, kasların kasılması ve sinir hücrelerinin yanıt vermesine yardımcı olur. Kalp atışlarını düzenler ve sodyumun kan basıncı üzerindeki etkisini dengeleyerek normal kan basıncı ve kalp fonksiyonlarının sürdürülmesi için önemlidir. Yaş ilerledikçe kemik sağlığını korurken böbrek taşı oluşma riskini de düşürmeye destek olabilir. Ancak, böbrek hastalığı olan potasyum kısıtlaması gereken bireylerde muzun zengin potasyum içeriği kan potasyum seviyelerini arttırarak kalp ritmini olumsuz etkileyebilir. Bu sebeple bu bireylerin muz tüketmeden önce diyetisyene danışmalarında fayda var.", "/WebT/img/fruite-item-3.jpg", false, 0.250m, null, 4.95m, "Native Banana", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 4, 1m, "Healthy" },
                    { 5, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1922), null, "Portakal faydaları ya da portakalın sağlık açısından katkıları dendiğinde akla gelen ilk şey, C vitaminidir. Narenciyeler genel olarak bağışıklık sistemini desteklemeye yardımcı olan, bol miktarda C vitamini içeren meyvelerdir. Ancak portakalın faydaları C vitamini ile sınırlı değildir. 3 Portakal; vitaminler, mineraller ve antioksidanlar gibi pek çok farklı besin maddelerinin yanı sıra koruyucu bitki bileşikleri açısından da zengin bir hazine olarak kabul edilir. Yapılan araştırmalar, düzenli olarak portakal tüketmenin sağlığa çeşitli şekillerde fayda sağlayabileceğini gösterir.1\r\n\r\nPortakal, flavonoidler, karotenoidler ve C vitamini gibi çeşitli biyoaktif bitki bileşikleri içerir. Hesperidin ve naringenin portakalda bulunan flavonoidler arasında yer alır. Hesperidin, portakalda yer alan ana antioksidanlardan biridir. Naringenin ise sağlık yararları ile bağlantılı olan başka bir narenciye flavonoididir. Örneğin naringenin açısından zengin portakal suyu içmek, vücuttaki antioksidan aktiviteyi güçlendirmeye yardımcı olabilir. Bu aynı zamanda taze sıkılmış portakal suyu faydaları arasında da gösterilebilir.1,4\r\n\r\nPortakala turuncu, kırmızı ve sarı rengini veren karotenoidler de bir tür antioksidandır. Yapılan bazı araştırmalar, portakal suyu faydaları arasında vücudun toplam antioksidan durumunun iyi bir göstergesi olan cilt karotenoid düzeylerini artırmaya yardımcı olduğunu gösterir.1, 5 Portakalın faydaları arasında yer alan karotenoidlerden biri olan beta kriptoksantin; hücreleri oksidatif hasara karşı korumaya yardımcı olur. Ayrıca vücut beta kriptoksantin'i A vitamininin aktif formuna dönüştürebilir. 6 Portakalda bulunan bir diğer karotenoid ise likopen adlı bileşiktir. Likopen, kırmızı renkli ve etli portakallarda yüksek miktarlarda bulunan güçlü bir antioksidandır. ", "/WebT/img/fruite-item-1.jpg", false, 0.250m, null, 4.95m, "Native Oranges", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 5, 1m, "Healthy" },
                    { 6, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1928), null, "Elmanın glisemik indeksi, protein ve yağ içeriği düşüktür. Elma, lifli bir yapısı olması nedeni ile bağırsak tembelliğine iyi gelen, bununla beraber kolesterol ve karbonhidratların emilimini düzenlemeye yardımcı çözünür bir lif olan pektin içeriği en yüksek meyvelerden biridir.\r\n\r\nElmada C, A, K, B6 ve E vitaminleri bulunur. C vitamini besinler yoluyla sağlanmalıdır. Yorgunluğu azaltmaya yardımcı olur, sinir sisteminin düzgün çalışması ve bağışıklık savunması için gereklidir, demir emilimini artırır. İçerisinde bulunan polifenoller sayesinde antioksidan özelliklere sahiptir.\r\n\r\nElma, potasyum, fosfor, kalsiyum, çinko, demir gibi mineraller içermektedir. Potasyum, normal kan basıncını ve kas fonksiyonunu korumaya yardımcı olan bir mineraldir.\r\n\r\nElmadaki vitaminden en iyi şekilde yararlanmak için elma çiğ olarak, kabuklu veya kabuğu soyulduktan hemen sonra tüketilmeli çünkü C vitamini havadaki ısı ve oksijenin etkisine karşı hassastır. Elma, enerji metabolizmasına katkıda bulunur ve hücreleri oksidatif strese karşı korur.  ", "/WebT/img/featur-1.jpg", false, 0.250m, null, 4.95m, "Native Apple", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 6, 1m, "Healthy" },
                    { 7, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1932), null, "Patates tüm tartışmalara rağmen faydalıdır. Patates faydaları düşünüldüğünde akla hemen potasyum kaynağı olması ve potasyumun kalp hastalıklarına pozitif etkisi gelir. Ancak patatesin faydaları bununla sınırlı değildir. Detaylı açıklarsak patatesin faydaları şöyle sıralanabilir:\r\n\r\nTansiyonu Dengeler: Böbrek, kalp ve beyin sağlığını riske atan yüksek tansiyon, düşük potasyum ile ilişkilendirilir. Çünkü düşük potasyum nedeniyle vücuttaki sodyum tutulur. Bu da tansiyonun yükselmesine neden olur. Patates zengin bir potasyum kaynağı olarak sodyumun dengelenmesine yardımcı olurken felç ve kalp krizi riskini de azaltmaya destektir. Patates ayrıca lifli yapısı sayesinde kolesterolü damarlardan dışarı itmekle ilişkilendirilir ve böylece kalp sağlığına katkı sağlar.\r\n\r\nAntioksidan Deposu: Serbest radikallere karşı mücadele veren antioksidanlar, bu sayede hücrelerdeki oksidatif stresin yarattığı hasarı da azaltmaya ve önlemeye yardımcı olur. Flavonoidler, karotenoidler ve fenolik asitler patatesteki antioksidanlar olarak karşımıza çıkar. Antioksidanların diyabet hastaları için de faydalı bilinir. Antioksidan zengini tatlı patatesi de anti-inflamatuar etki gösterir. Bu özellik artrit ve gut hastalığı olan kişilerin patatesi tercih etmesi için bir nedendir.\r\n\r\nBağışıklığı Güçlendirir: Güçlü bir bağışıklık grip gibi hastalıklarla ve alerjiyle savaşmak için elzemdir. Güçlü bağışıklık ise vitamin ve minerallerden zengin beslenme ile mümkündür. Patatesteki C vitamini, B6 vitamini ve potasyum güçlü bağışıklığa katkı sağlar.", "/WebT/img/vegetable-item-5.jpg", false, 0.250m, null, 4.95m, "Native Patatoes", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 7, 1m, "Healthy" },
                    { 8, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1936), null, "Maydanoz, petroselinum crispumdur adı verilen ve yaygın olarak yetiştirilen yeşil yapraklı, çiçekli bir bitkidir. Kokusu ve tadında yoğun bir aroma bulunan maydanoz ülkemizde yaygın olarak Akdeniz Bölgesi'nde yetişir. Çok faydalı bir bitki olan maydanoz salatalara ve yemeklerin üzerine süs olarak eklenmesiyle birlikte tomatolerin içerisinde de tüketilebilir.\r\n\r\nForm olarak birçok farklı şekilde kullanılabilen maydanoz, sağlık açısından sağladığı faydalarla öne çıkar. Maydanoz temel olarak antibakteriyel etkisiyle öne çıkar. Bu sayede vücudu ve özellikle karaciğeri zararlı maddelerden korur. Kalp sağlığını destekleyen, antikanser etkisi bulunan, kemikleri güçlendiren ve kanın pıhtılaşmasını sağlayan maydanoz aynı zamanda çiğ tüketildiğinde ağız kokusunun da önüne geçebilir.", "/WebT/img/vegetable-item-6.jpg", false, 0.250m, null, 4.95m, "Native Persely", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 8, 1m, "Healthy" },
                    { 9, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1941), null, "Domatesin ana vatanı Güney ve Orta Amerika kabul ediliyor. Domates, ülkemizde Ege, Akdeniz ve Marmara bölgelerinde yoğun şekilde yetiştiriliyor. Domates, hemen her tarifte kullanıldığı için Türk mutfağının temelini oluşturan sebzelerdendir.\r\n\r\nVücut için bilinen en etkili antioksidan olan likopen en fazla domateste bulunmaktadır. Domates ayrıca C, A ve K vitamininde önemli bir kaynağıdır. Yapılan çalışmalar yüksek likopen alımının kardiovasküler sağlığa olan olumlu etkilerini göstermektedir.\r\n\r\n1 kupa (yaklaşık olarak 180 gram) domates tüketildiğinde günlük C vitamini ihtiyacının % 57,3’ü, A vitamini ihtiyacının %22,4’ünü, K vitamini ihtiyacının % 17,8’ini ve lif ihtiyacının % 7,9’ü karşılanmış olacaktır. Bunun yanında domates; potasyum, niasin, B6 vitamini ve folatında iyi bir kaynağıdır. Günlük potasyum ihtiyacının %11,4’ü, niasin ihtiyacının %5,6’sını, B6 vitamini ihtiyacının % 7,0’si ve folat ihtiyacının %6,8’i karşılanmaktadır.", "/WebT/img/vegetable-item-1.jpg", false, 0.250m, null, 4.95m, "Native Tomato", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 9, 1m, "Healthy" },
                    { 10, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1949), null, "Brokoli, lahana grubu sebzeler çatısı altında yer alan bir sebzedir. Son yıllarda besleyici değerinin anlaşılması ile tüketimi artan bir besindir. İçerdiği bazı fitokimyasal ve biyoaktif bileşikler sayesinde insan sağlığında yararlı olarak kabul edilir. Vücudu toksik bileşiklerden uzaklaştırması, hücre hasarını önlemek, hastalıklara karşı koruyucu etkinliği ile bağışıklık sistemini güçlendirmeye yardımcıdır.\r\n\r\nGlukosinolat adı verilen kükürt ve şeker bileşiklerinin parçalanması sonucu oluşan sülforafan çeşitli hastalıklara karşı koruyucudur. Son yıllarda özellikle antioksidan ve antikanserojen olması sebebiyle kanser riskinin azaltılmasında etkinlik gösterdiği bilinir. Çeşitli araştırmalara konu olan brokoli, kalp ve damar hastalıkları, meme ve prostat kanseri gibi kronik hastalıkların önlenmesinde rol oynar. Brokolinin yaklaşık %30 kısmını oluşturan çiçekleri yemeklerde çoğunlukla kullanılan kısımdır. Daha az kullanılan yaprak ve sapları önemli oranda fitokimyasal kaynağıdır.", "/WebT/img/featur-3.jpg", false, 0.250m, null, 4.95m, "Native Brocoli", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 10, 1m, "Healthy" },
                    { 11, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1953), null, "Kırmızı biber, C vitamini açısından zengindir. 2 Sağlıklı bir bağışıklık sistemini desteklemedeki rolüyle bilinen ve suda çözünen bir vitamin olan C vitamini, vücudun her yerindeki dokuların büyümesi ve onarımı için gereklidir. 5 C vitamini vücudun doğal savunmasını güçlendirebilen güçlü bir antioksidandır. Antioksidanlar ise bağışıklık sistemini güçlendiren moleküller olarak açıklanabilir. Bunu hücreleri serbest radikaller adı verilen zararlı moleküllerden koruyarak yapar. Serbest radikaller vücutta biriktiğinde, birçok kronik hastalıkla bağlantılı olan oksidatif stres olarak bilinen durumu teşvik edebilir.7, 8, 9 Ek olarak kırmızı biber faydaları arasında beyaz kan hücrelerinin daha etkili çalışmasına yardımcı olmak onları serbest radikaller gibi potansiyel zararlı moleküllerden korumak da gösterilebilir. 7\r\n\r\nC vitamini eksikliği, bağışıklığın bozulmasına ve enfeksiyonlara karşı daha yüksek duyarlılığa neden olur. Enfeksiyonlar, artan inflamasyon ve metabolik gereksinimler nedeniyle C vitamini düzeyleri etkilenir. Ayrıca, C vitamini, solunum yolu ve sistemik enfeksiyonları hem önleyebildiği hem de tedaviye yardımcı olabileceği bilinir. C vitamini hem doğuştan hem de kazanılmış bağışıklık sisteminin çeşitli hücresel fonksiyonlarını destekleyerek bağışıklık savunmasına katkıda bulunur.6 C vitamini, hücre hasarıyla savaşan, bağışıklık sisteminin mikroplara karşı tepkisini artıran ve antiinflamatuar etkiye sahip güçlü bir antioksidandır. 2 Farklı bir anlatımla C vitamini, vücudun enfeksiyona karşı korunmasına yardımcı olan, lenfositler ve fagositler olarak bilinen beyaz kan hücrelerinin üretimini teşvik etmeye yardımcı olur.7, 10 Enfeksiyon bölgesine savunma mekanizmasının önemli bir parçası olan nötrofillerin yönlendirilmesinde rol oynar. Oksidan oluşumunu ve mikrobiyal öldürmeyi artırır. Bu nedenle, kişiye enfeksiyonların zarar verilmesini önlerken, bağışıklık sisteminin patojenlere karşı yeterli bir yanıt oluşturması için C vitamininin gerekli olduğu söylenebilir. 6\r\n\r\nTüm bunlara ek olarak kırmızı biberde bulunan A vitamini de vücudu hastalıklardan ve enfeksiyonlardan koruyan bağışıklık tepkisinin uyarılmasını sağlar. B ve T hücreleri de dahil olmak üzere bazı hücrelerin oluşumunda da rol oynayan A vitamini, oksidatif stresi kontrol altında tutarak, bağışıklık sistemini güçlendirebilir ve bazı hastalıklara karşı koruma sağlayarak sağlığı olumlu yönde etkiler.", "/WebT/img/vegetable-item-4.jpg", false, 0.250m, null, 4.95m, "Native Bell Papper", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 11, 1m, "Healthy" },
                    { 12, "Agro Farm", new DateTime(2024, 5, 13, 18, 45, 43, 46, DateTimeKind.Local).AddTicks(1980), null, "Vitamin ve mineralce zengin bir meyve olan çilek içeriğinde çok sayıda fitokimyasal madde bulundurur. Fitokimyasallar sebze, meyve, tahıl ve baklagillerin sağlığını koruyan ve sağlık için faydalı olan kimyasal maddelerdir. İçerisinde fitokimyasal bulunan besinleri tüketmek insan yaşamını olumsuz etkileyen kanser, kalp damar hastalıkları ve diyabet oluşmasını önlerken var olan hastalıkların tedavisinde destekleyici bir etki gösterir. Ayrıca çilek iyi bir antioksidan kaynağıdır. Antioksidanlar vücut tarafından doğal olarak üretilebilen ve besinlerle dışarıdan alınan ve vücutta hücre hasarını önleyen maddelerdir.\r\n\r\nEşsiz lezzeti ve lif, manganez, C vitamini, potasyum, folik asit gibi önemli vitamin ve mineral madde içeriği ile; taze, işlenmiş ya da dondurulmuş olarak tüketilebilen çileğin insan sağlığı açısından birden çok yararı bulunmaktadır. ", "/WebT/img/featur-2.jpg", false, 0.250m, null, 4.95m, "Native Strawberry", "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.", "Organic", true, 12, 1m, "Healthy" }
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
