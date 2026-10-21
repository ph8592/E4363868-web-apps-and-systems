using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetsDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAcquired = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    InUse = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "DateAcquired", "InUse", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateOnly(2026, 10, 21), true, 0, "Laptop", 1200.0 },
                    { 2, new DateOnly(2026, 10, 21), false, 0, "Projector", 800.0 },
                    { 3, new DateOnly(2026, 10, 21), true, 1, "Forklift", 15000.0 },
                    { 4, new DateOnly(2026, 10, 21), false, 0, "Printer", 300.0 },
                    { 5, new DateOnly(2026, 10, 21), true, 1, "Pallet Jack", 500.0 },
                    { 6, new DateOnly(2026, 10, 21), false, 2, "Server Rack", 2000.0 },
                    { 7, new DateOnly(2026, 10, 21), true, 0, "Desktop Computer", 1000.0 },
                    { 8, new DateOnly(2026, 10, 21), false, 2, "Air Conditioner", 1500.0 },
                    { 9, new DateOnly(2026, 10, 21), true, 1, "Conveyor Belt", 7000.0 },
                    { 10, new DateOnly(2026, 10, 21), false, 0, "Whiteboard", 100.0 },
                    { 11, new DateOnly(2026, 10, 21), true, 2, "3D Printer", 2500.0 },
                    { 12, new DateOnly(2026, 10, 21), false, 1, "CCTV Camera", 400.0 },
                    { 13, new DateOnly(2026, 10, 21), true, 0, "Router", 150.0 },
                    { 14, new DateOnly(2026, 10, 21), false, 2, "UPS", 300.0 },
                    { 15, new DateOnly(2026, 10, 21), true, 1, "Barcode Scanner", 200.0 },
                    { 16, new DateOnly(2026, 10, 21), false, 0, "Smartphone", 800.0 },
                    { 17, new DateOnly(2026, 10, 21), true, 2, "Tablet", 600.0 },
                    { 18, new DateOnly(2026, 10, 21), false, 1, "Digital Camera", 500.0 },
                    { 19, new DateOnly(2026, 10, 21), true, 2, "Laser Cutter", 10000.0 },
                    { 20, new DateOnly(2026, 10, 21), false, 0, "VR Headset", 400.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
