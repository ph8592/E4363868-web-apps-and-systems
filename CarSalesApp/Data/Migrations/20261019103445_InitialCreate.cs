using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarSalesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Fuel = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    DateAdded = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Sold = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Sold", "Year" },
                values: new object[,]
                {
                    { 1, new DateOnly(2022, 7, 10), 0, "Volkswagen", "Polo", 4795.0, true, 2013 },
                    { 2, new DateOnly(2022, 7, 13), 0, "Ford", "Fiesta", 9597.0, false, 2017 },
                    { 3, new DateOnly(2022, 7, 19), 1, "BMW", "1 Series", 11749.0, true, 2016 },
                    { 4, new DateOnly(2022, 7, 21), 2, "BMW", "2 Series", 18989.0, true, 2017 },
                    { 5, new DateOnly(2022, 7, 21), 2, "Toyota", "Prius", 13490.0, true, 2014 },
                    { 6, new DateOnly(2022, 7, 25), 1, "Ford", "Focus", 3995.0, false, 2015 },
                    { 7, new DateOnly(2022, 7, 30), 3, "Volkswagen", "Golf", 21000.0, true, 2018 },
                    { 8, new DateOnly(2022, 8, 1), 2, "Toyota", "Yaris", 18990.0, false, 2021 },
                    { 9, new DateOnly(2022, 8, 1), 3, "BMW", "i3", 14990.0, false, 2014 },
                    { 10, new DateOnly(2022, 8, 3), 2, "Toyota", "RAV4", 18495.0, true, 2018 },
                    { 11, new DateOnly(2022, 8, 7), 2, "BMW", "3 Series", 15000.0, true, 2017 },
                    { 12, new DateOnly(2022, 8, 8), 1, "Ford", "Focus", 4995.0, false, 2014 },
                    { 13, new DateOnly(2022, 8, 10), 0, "BMW", "1 Series", 17250.0, true, 2018 },
                    { 14, new DateOnly(2022, 8, 15), 0, "Ford", "Fiesta", 5400.0, true, 2015 },
                    { 15, new DateOnly(2022, 8, 20), 0, "BMW", "Z4", 8990.0, false, 2014 },
                    { 16, new DateOnly(2022, 8, 27), 1, "BMW", "4 Series", 16990.0, true, 2015 },
                    { 17, new DateOnly(2022, 9, 2), 3, "Renault", "Zoe", 8995.0, true, 2014 },
                    { 18, new DateOnly(2022, 9, 5), 0, "Ford", "Fiesta", 9380.0, false, 2016 },
                    { 19, new DateOnly(2022, 9, 7), 0, "BMW", "3 Series", 11595.0, false, 2014 },
                    { 20, new DateOnly(2022, 9, 10), 0, "Ford", "Focus", 8495.0, false, 2017 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
