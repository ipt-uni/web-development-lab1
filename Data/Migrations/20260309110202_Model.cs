using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "MyUsers",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    TaxNumber = table.Column<string>(type: "TEXT", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyUsers", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    File = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    price = table.Column<decimal>(type: "TEXT", nullable: false),
                    CategoryFK = table.Column<int>(type: "INTEGER", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Categories_CategoryFK",
                        column: x => x.CategoryFK,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    state = table.Column<int>(type: "INTEGER", nullable: false),
                    BuyerFK = table.Column<int>(type: "INTEGER", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_MyUsers_BuyerFK",
                        column: x => x.BuyerFK,
                        principalTable: "MyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "PhotographPurchase",
                columns: table => new
                {
                    ListOfPhotosId = table.Column<int>(type: "INTEGER", nullable: false),
                    ListOfPurchasesId = table.Column<int>(type: "INTEGER", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_PhotographPurchase",
                        x => new { x.ListOfPhotosId, x.ListOfPurchasesId }
                    );
                    table.ForeignKey(
                        name: "FK_PhotographPurchase_Photos_ListOfPhotosId",
                        column: x => x.ListOfPhotosId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_PhotographPurchase_Purchases_ListOfPurchasesId",
                        column: x => x.ListOfPurchasesId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_PhotographPurchase_ListOfPurchasesId",
                table: "PhotographPurchase",
                column: "ListOfPurchasesId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CategoryFK",
                table: "Photos",
                column: "CategoryFK"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_BuyerFK",
                table: "Purchases",
                column: "BuyerFK"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "PhotographPurchase");

            migrationBuilder.DropTable(name: "Photos");

            migrationBuilder.DropTable(name: "Purchases");

            migrationBuilder.DropTable(name: "Categories");

            migrationBuilder.DropTable(name: "MyUsers");
        }
    }
}
