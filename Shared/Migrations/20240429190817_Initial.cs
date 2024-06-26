﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shared.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Savings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Savings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Savings",
                columns: new[] { "Id", "Amount", "Category", "Date", "Name" },
                values: new object[,]
                {
                    { 1, 590m, 0, new DateTime(2024, 4, 29, 21, 8, 16, 815, DateTimeKind.Local).AddTicks(9460), "Salary 1" },
                    { 2, 640m, 0, new DateTime(2024, 5, 29, 21, 8, 16, 815, DateTimeKind.Local).AddTicks(9510), "Salary 2" },
                    { 3, 20.00m, 1, new DateTime(2024, 4, 29, 22, 8, 16, 815, DateTimeKind.Local).AddTicks(9520), "Saving 1" },
                    { 4, 35.00m, 1, new DateTime(2024, 5, 30, 21, 8, 16, 815, DateTimeKind.Local).AddTicks(9520), "Saving 2" },
                    { 5, 62.00m, 2, new DateTime(2024, 4, 29, 23, 8, 16, 815, DateTimeKind.Local).AddTicks(9530), "Books" },
                    { 6, 93.00m, 2, new DateTime(2024, 5, 31, 21, 8, 16, 815, DateTimeKind.Local).AddTicks(9530), "Toys" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Savings");
        }
    }
}
