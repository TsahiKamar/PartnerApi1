using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMRApi.Migrations
{
    public partial class MyBaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customerId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    updateDate = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customerId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    interestPercents = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateDate = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    customerId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    houseNum = table.Column<int>(type: "int", nullable: false),
                    pob = table.Column<int>(type: "int", nullable: false),
                    zip = table.Column<int>(type: "int", nullable: false),
                    Customersid = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.customerId);
                    table.ForeignKey(
                        name: "FK_Address_Customers_Customersid",
                        column: x => x.Customersid,
                        principalTable: "Customers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    customerId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Customersid = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.customerId);
                    table.ForeignKey(
                        name: "FK_Phone_Customers_Customersid",
                        column: x => x.Customersid,
                        principalTable: "Customers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    customerId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    interestPercents = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customersid = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.customerId);
                    table.ForeignKey(
                        name: "FK_Product_Customers_Customersid",
                        column: x => x.Customersid,
                        principalTable: "Customers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Customersid",
                table: "Address",
                column: "Customersid");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_Customersid",
                table: "Phone",
                column: "Customersid");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Customersid",
                table: "Product",
                column: "Customersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
