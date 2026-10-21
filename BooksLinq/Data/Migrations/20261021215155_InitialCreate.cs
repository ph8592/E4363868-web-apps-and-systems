using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksLinq.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    PageCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Publisher = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    IsClassic = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "IsClassic", "PageCount", "PublishedYear", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "J.D. Salinger", "Fiction", true, 277, 1951, "Little, Brown and Company", "The Catcher in the Rye" },
                    { 2, "Leo Tolstoy", "Historical Fiction", true, 1225, 1869, "The Russian Messenger (serial)", "War and Peace" },
                    { 3, "George Orwell", "Dystopian", true, 328, 1949, "Secker & Warburg", "1984" },
                    { 4, "J.R.R. Tolkien", "Fantasy", true, 310, 1937, "George Allen & Unwin", "The Hobbit" },
                    { 5, "F. Scott Fitzgerald", "Fiction", true, 317, 1934, "Charles Scribner", "Tender Is the Night" },
                    { 6, "F. Scott Fitzgerald", "Fiction", true, 180, 1925, "Charles Scribner", "The Great Gatsby" },
                    { 7, "Harper Lee", "Fiction", true, 336, 1960, "J.B. Lippincott & Co.", "To Kill a Mockingbird" },
                    { 8, "Paulo Coelho", "Adventure", true, 208, 1988, "HarperTorch", "The Alchemist" },
                    { 9, "Aldous Huxley", "Dystopian", true, 268, 1932, "Chatto & Windus", "Brave New World" },
                    { 10, "Herman Melville", "Adventure", true, 635, 1851, "Harper & Brothers", "Moby-Dick" },
                    { 11, "Jane Austen", "Romance", true, 279, 1813, "T. Egerton, Whitehall", "Pride and Prejudice" },
                    { 12, "J.R.R. Tolkien", "Fantasy", true, 1178, 1954, "George Allen & Unwin", "The Lord of the Rings" },
                    { 13, "Michelle Obama", "Autobiography", false, 448, 2018, "Crown", "Becoming" },
                    { 14, "Yuval Harari", "Non-Fiction", false, 443, 2011, "Harper", "Sapiens: A Brief History of Humankind" },
                    { 15, "Tara Westover", "Autobiography", false, 334, 2018, "Random House", "Educated" },
                    { 16, "Daniel Kahneman", "Non-Fiction", false, 499, 2011, "Farrar, Straus and Giroux", "Thinking, Fast and Slow" },
                    { 17, "Bessel van der Kolk", "Non-Fiction", false, 464, 2014, "Viking", "The Body Keeps the Score" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
