using BooksLinq;
using System.ComponentModel.DataAnnotations;

static void DisplayBookList(List<Book> bookList)
{
    foreach (var book in bookList)
    {
        Console.WriteLine(book);
    }
}

Console.WriteLine("Book List LINQ\n");

#region adding books to a list

List<Book> books = AddBooks();

AddMoreBooks(books);
#endregion

DisplayBookList(books);

Console.WriteLine("\nTolkien Books");
var tolkienBooks = books.Where(b => b.Author == "J.R.R. Tolkien").ToList();
DisplayBookList(tolkienBooks);

Console.WriteLine("\nTolkien Or Coelho Books");
var tolkienOrCoelhoBooks = books.Where(b => b.Author == "J.R.R. Tolkien" || b.Author == "Paulo Coelho").ToList();
DisplayBookList(tolkienOrCoelhoBooks);

Console.WriteLine("\nBooks with IS in the title");
var isBooks = books.Where(b => b.Title.Contains("is", StringComparison.CurrentCultureIgnoreCase)).ToList();
DisplayBookList(isBooks);

Console.WriteLine("\nBooks with a page count between 450 and 1000 (inclusive)");
var mediumSizeBooks = books.Where(b => b.PageCount >= 450 && b.PageCount <= 1000).ToList();
DisplayBookList(mediumSizeBooks);

Console.WriteLine("\nBooks in the Autobiography and Romance Genres");
var genreFilterList = new List<string> { "Autobiography", "Romance" };
var genreFilteredBooks = books.Where(b => genreFilterList.Contains(b.Genre)).ToList();
DisplayBookList(genreFilteredBooks);

Console.WriteLine("\nBooks sorted by Genre");
var booksSortedByGenre = books.OrderBy(b => b.Genre).ToList();
DisplayBookList(booksSortedByGenre);

Console.WriteLine("\nBooks sorted by Genre and Title");
var booksSortedByGenreAndTitle = books.OrderBy(b => b.Genre).ThenBy(b => b.Title).ToList();
DisplayBookList(booksSortedByGenreAndTitle);

Console.WriteLine("\nBooks sorted by Year Published (latest first) and Title");
var booksSortedByYearAndTitle = books.OrderByDescending(b => b.PublishedYear).ThenBy(b => b.Title).ToList();
DisplayBookList(booksSortedByYearAndTitle);

Console.WriteLine("\nOldest and newest book - Year Published");
var oldestBookYear = books.Select(b => b.PublishedYear).Min(); // extract years and then find minimum
Console.WriteLine($"Oldest Year Published: {oldestBookYear}");
var newestBookYear = books.Max(b => b.PublishedYear); // extract year as part of max
Console.WriteLine($"Most Recent Year Published: {newestBookYear}");

Console.WriteLine("\nJ.R.R. Tolkien earliest-published book");
var tolkienFirstBook = books.Where(b => b.Author == "J.R.R. Tolkien") // Filter by author
.OrderBy(b => b.PublishedYear) // sort by year published
.FirstOrDefault(); // get first book from list
Console.WriteLine(tolkienFirstBook);

DisplayBookCountByGenre(books);

Console.WriteLine("\nClassic books which have more than 300 pages");
var classicBooks = books.Where(b => b.IsClassic && b.PageCount > 300).ToList();
DisplayBookList(classicBooks);

Console.WriteLine("\nBooks which are not classics and were published after 1950");
var nonClassicBooks = books.Where(b => !b.IsClassic && b.PublishedYear > 1950).ToList();
DisplayBookList(nonClassicBooks);

Console.WriteLine("\nBooks published by George Allen & Unwin, ordered by page count");
var booksByPublisher = books.Where(b => b.Publisher == "George Allen & Unwin")
    .OrderBy(b => b.PageCount)
    .ToList();
DisplayBookList(booksByPublisher);

Console.WriteLine("\nBooks which are either classics or have a page count more than 500 pages");
var classicOrLargeBooks = books.Where(b => b.IsClassic || b.PageCount > 500).ToList();
DisplayBookList(classicOrLargeBooks);

Console.WriteLine("\nCheck if there are any non-classic books with a page count more than 500 pages");
var anyNonClassicLargeBooks = books.Where(b => !b.IsClassic && b.PageCount > 500).ToList();
DisplayBookList(anyNonClassicLargeBooks); // There isn't

Console.WriteLine("\nAverage page count of books in each genre");
var averagePageCountByGenre = books.GroupBy(b => b.Genre)
    .Select(g => new
    {
        Genre = g.Key,
        AveragePageCount = g.Average(b => b.PageCount)
    })
    .ToList();
foreach (var genre in averagePageCountByGenre)
{
    Console.WriteLine($"{genre.Genre}: {genre.AveragePageCount:F1} pages");
}

Console.WriteLine("\nLongest book in each genre");
var longestBookByGenre = books.GroupBy(b => b.Genre)
    .Select(g => new
    {
        Genre = g.Key,
        LongestBook = g.OrderByDescending(b => b.PageCount).FirstOrDefault()
    })
    .ToList();
foreach (var genre in longestBookByGenre)
{
    Console.WriteLine($"{genre.Genre}: {genre.LongestBook.Title} ({genre.LongestBook.PageCount} pages)");
}

#region book adding methods
static List<Book> AddBooks()
{
    return new List<Book>
{
    new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277,
    "Little, Brown and Company", 1951, "Fiction", true),
    new Book(2, "War and Peace", "Leo Tolstoy", 1225,
    "The Russian Messenger (serial)", 1869, "Historical Fiction", true),
    new Book(3, "1984", "George Orwell", 328,
    "Secker & Warburg", 1949, "Dystopian", true)
};
}

static void AddMoreBooks(List<Book> books)
{
    books.AddRange(new List<Book>
    {
        new Book(4, "The Hobbit", "J.R.R. Tolkien", 310,
        "George Allen & Unwin", 1937, "Fantasy", true),
        new Book(5, "Tender Is the Night", "F. Scott Fitzgerald", 317,
        "Charles Scribner", 1934, "Fiction", true),
        new Book(6, "The Great Gatsby", "F. Scott Fitzgerald", 180,
        "Charles Scribner", 1925, "Fiction", true),
        new Book(7, "To Kill a Mockingbird", "Harper Lee", 336,
        "J.B. Lippincott & Co.", 1960, "Fiction", true),
        new Book(8, "The Alchemist", "Paulo Coelho", 208,
        "HarperTorch", 1988, "Adventure", true),
        new Book(9, "Brave New World", "Aldous Huxley", 268,
        "Chatto & Windus", 1932, "Dystopian", true),
        new Book(10, "Moby-Dick", "Herman Melville", 635,
        "Harper & Brothers", 1851, "Adventure", true),
        new Book(11, "Pride and Prejudice", "Jane Austen", 279,
        "T. Egerton, Whitehall", 1813, "Romance", true),
        new Book(12, "The Lord of the Rings", "J.R.R. Tolkien", 1178,
        "George Allen & Unwin", 1954, "Fantasy", true),
        new Book(13, "Becoming", "Michelle Obama", 448,
        "Crown", 2018, "Autobiography", false),
        new Book(14, "Sapiens: A Brief History of Humankind", "Yuval Harari", 443,
        "Harper", 2011, "Non-Fiction", false),
        new Book(15, "Educated", "Tara Westover", 334,
        "Random House", 2018, "Autobiography", false),
        new Book(16, "Thinking, Fast and Slow", "Daniel Kahneman", 499,
        "Farrar, Straus and Giroux", 2011, "Non-Fiction", false),
        new Book(17, "The Body Keeps the Score", "Bessel van der Kolk", 464,
        "Viking", 2014, "Non-Fiction", false)
    }
    );
}

static void DisplayBookCountByGenre(List<Book> books)
{
    Console.WriteLine("\nBook Count for each Genre");
    var genreCounts = books.GroupBy(b => b.Genre) // Create a subset of records for each genre
    .OrderBy(g => g.Key) // Optional: Sort by genre [key]
    .Select(g => new
    { // Create an anonymous record with:
        Genre = g.Key, // - Genre [the group key]
        Count = g.Count() // - A count of the subset of Genre records
    }).ToList();
    foreach (var gc in genreCounts)
    {
        Console.WriteLine($"{gc.Genre}: {gc.Count}");
    }
}

#endregion

// up to students list pg 21

