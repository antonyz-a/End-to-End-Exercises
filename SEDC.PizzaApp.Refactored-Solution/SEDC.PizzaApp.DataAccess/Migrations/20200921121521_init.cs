﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    PizzaSize = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PizzaOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PizzaOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaOrder_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Image", "Name", "PizzaSize", "Price" },
                values: new object[,]
                {
                    { 1, "Kapri.png", "Kapri", 1, 7.0 },
                    { 2, "Kapri.png", "Kapri", 2, 7.0 },
                    { 3, "Kapri.png", "Kapri", 3, 7.0 },
                    { 4, "Peperoni.png", "Peperoni", 1, 9.0 },
                    { 5, "Peperoni.png", "Peperoni", 2, 8.0 },
                    { 6, "Peperoni.png", "Peperoni", 3, 8.0 },
                    { 7, "Margarita.png", "Margarita", 1, 10.5 },
                    { 8, "Margarita.png", "Margarita", 2, 10.5 },
                    { 9, "Margarita.png", "Margarita", 3, 10.5 },
                    { 10, "Siciliana.png", "Siciliana", 1, 6.5 },
                    { 11, "Siciliana.png", "Siciliana", 2, 9.5 },
                    { 12, "Siciliana.png", "Siciliana", 3, 9.5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Bob street", "Bob", "Bobski", 3565645546567L },
                    { 2, "Jill street", "Jill", "Wayne", 3565645546123L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "PizzaOrder",
                columns: new[] { "Id", "OrderId", "PizzaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 3, 2, 1 },
                    { 4, 2, 5 },
                    { 5, 2, 7 },
                    { 6, 3, 5 },
                    { 7, 3, 9 },
                    { 8, 3, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaOrder_OrderId",
                table: "PizzaOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaOrder_PizzaId",
                table: "PizzaOrder",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaOrder");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
