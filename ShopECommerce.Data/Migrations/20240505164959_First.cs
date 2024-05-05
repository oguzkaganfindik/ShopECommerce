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
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonCount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
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
                    OpenDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenDaysDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "MenuTables",
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
                    table.PrimaryKey("PK_MenuTables", x => x.Id);
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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
                    MenuTableId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Baskets_MenuTables_MenuTableId",
                        column: x => x.MenuTableId,
                        principalTable: "MenuTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
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
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Fruites", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(736), null, false, null, true },
                    { 2, "Vesitables", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(739), null, false, null, true }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "20", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2028), null, "OFF", "/WebT/img/featur-1.jpg", false, null, true, "Fresh Apples" },
                    { 2, "", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2031), null, "Free delivery", "/WebT/img/featur-2.jpg", false, null, true, "Tasty Fruits" },
                    { 3, "30", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2033), null, "Discount", "/WebT/img/featur-3.jpg", false, null, true, "Exotic Vegitable" }
                });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2135), null, "1963", "fa fa-users text-secondary", false, null, true, "SATISFIED CUSTOMERS" },
                    { 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2136), null, "99%", "fa fa-users text-secondary", false, null, true, "QUALITY OF SERVICE" },
                    { 3, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2138), null, "33", "fa fa-users text-secondary", false, null, true, "QUALITY CERTIFICATES" },
                    { 4, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2139), null, "789", "fa fa-users text-secondary", false, null, true, "AVAILABLE PRODUCTS" }
                });

            migrationBuilder.InsertData(
                table: "Featurs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2106), null, "Free on order over $300", "fas fa-car-side fa-3x text-white", false, null, true, "Free Shipping" },
                    { 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2108), null, "100% security payment", "fas fa-user-shield fa-3x text-white", false, null, true, "Security Payment" },
                    { 3, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2109), null, "30 day money guarantee", "fas fa-exchange-alt fa-3x text-white", false, null, true, "30 Day Return" },
                    { 4, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2110), null, "Support every time fast", "fa fa-phone-alt fa-3x text-white", false, null, true, "24/7 Support" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(686), null, false, null, "Admin", true },
                    { 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(719), null, false, null, "User", true }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImageUrl1", "ImageUrl2", "IsDeleted", "Label1", "Label2", "ModifiedDate", "Status", "Title", "Url1", "Url2" },
                values: new object[] { 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1984), null, "Organic Veggies & Fruits Foods", "/WebT/img/hero-img-1.png", "/WebT/img/hero-img-2.jpg", false, "Fruites", "Vesitables", null, true, "100% Organic Foods", "#", "#" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Cls", "CreatedDate", "DeletedDate", "Icon", "IsDeleted", "ModifiedDate", "Status", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1950), null, "fab fa-facebook-f", false, null, true, "Facebook", "http://www.facebook.com" },
                    { 2, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1952), null, "fab fa-youtube", false, null, true, "Youtube", "http://www.youtube.com" },
                    { 3, "btn btn-outline-secondary me-2 btn-md-square rounded-circle", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1953), null, "fab fa-linkedin-in", false, null, true, "Linkedin", "http://www.linkedin.com" },
                    { 4, "btn btn-outline-secondary btn-md-square rounded-circle", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1955), null, "fab fa-twitter", false, null, true, "Twitter", "http://www.x.com" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Comment", "CreatedDate", "DeletedDate", "ImageUrl", "IsDeleted", "ModifiedDate", "Name", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1927), null, "/WebT/img/testimonial-1.jpg", false, null, "Şebnem Ferah", true, "Şef Aşçı" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1930), null, "/WebT/img/testimonial-1.jpg", false, null, "Teoman Yakupoğlu", true, "Şef Aşçı" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Status", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(766), null, false, null, true, "Grapes" },
                    { 2, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(768), null, false, null, true, "Raspberries" },
                    { 3, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(769), null, false, null, true, "Apricots" },
                    { 4, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(771), null, false, null, true, "Banana" },
                    { 5, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(772), null, false, null, true, "Oranges" },
                    { 6, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(774), null, false, null, true, "Apple" },
                    { 7, 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(776), null, false, null, true, "Patatoes" },
                    { 8, 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(777), null, false, null, true, "Persely" },
                    { 9, 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(778), null, false, null, true, "Tomato" },
                    { 10, 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(780), null, false, null, true, "Brocoli" },
                    { 11, 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(781), null, false, null, true, "Bell Papper" },
                    { 12, 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(782), null, false, null, true, "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedDate", "Password", "Phone", "RoleId", "Status", "Username" },
                values: new object[] { 1, "Ankara", new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(1870), null, "admin@test.com", "Şebnem", false, "Ferah", null, "CfDJ8Lhzc99II2tHnoigxoZuezN58D-cusRS4mlpb03hJX8qR6hCPbuZBTDsbK1sWCjZNYIdjm-6qiXzjzxgxpkqbc_JggLx5KSH7QU5bytYmmSchVvO4Sboait3inyd4WAiVA", "0850", 1, true, "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedDate", "Price", "ProductName", "Status", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2058), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-5.jpg", false, null, 4.95m, "Native Grapes", true, 1 },
                    { 2, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2062), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-2.jpg", false, null, 4.95m, "Native Raspberries", true, 2 },
                    { 3, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2064), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-4.jpg", false, null, 4.95m, "Native Apricots", true, 3 },
                    { 4, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2065), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-3.jpg", false, null, 4.95m, "Native Banana", true, 4 },
                    { 5, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2067), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/fruite-item-1.jpg", false, null, 4.95m, "Native Oranges", true, 5 },
                    { 6, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2070), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-1.jpg", false, null, 4.95m, "Native Apple", true, 6 },
                    { 7, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2071), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-5.jpg", false, null, 4.95m, "Native Patatoes", true, 7 },
                    { 8, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2072), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-6.jpg", false, null, 4.95m, "Native Persely", true, 8 },
                    { 9, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2074), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-1.jpg", false, null, 4.95m, "Native Tomato", true, 9 },
                    { 10, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2076), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-3.jpg", false, null, 4.95m, "Native Brocoli", true, 10 },
                    { 11, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2078), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/vegetable-item-4.jpg", false, null, 4.95m, "Native Bell Papper", true, 11 },
                    { 12, new DateTime(2024, 5, 5, 19, 49, 58, 447, DateTimeKind.Local).AddTicks(2080), null, "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt", "/WebT/img/featur-2.jpg", false, null, 4.95m, "Native Strawberry", true, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_MenuTableId",
                table: "Baskets",
                column: "MenuTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

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
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Bookings");

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
                name: "MenuTables");

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
