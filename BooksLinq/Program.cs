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

var books = new List<Book>
{
    new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277,
    "Little, Brown and Company", 1951, "Fiction", true),
    new Book(2, "War and Peace", "Leo Tolstoy", 1225,
    "The Russian Messenger (serial)", 1869, "Historical Fiction", true),
    new Book(3, "1984", "George Orwell", 328,
    "Secker & Warburg", 1949, "Dystopian", true)
};

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

DisplayBookList(books);

Console.WriteLine("\nTolkien Books");
var tolkienBooks = books.Where(b => b.Author == "J.R.R. Tolkien").ToList();
DisplayBookList(tolkienBooks);

// up to step 14 pg 10

