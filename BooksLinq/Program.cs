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
    new Book(1, "To Kill a Mockingbird", "Harper Lee", 281, "J.B. Lippincott & Co.", 1960, "Fiction", true),
    new Book(2, "1984", "George Orwell", 328, "Secker & Warburg", 1949, "Dystopian", true),
    new Book(3, "The Great Gatsby", "F. Scott Fitzgerald", 180, "Charles Scribner's Sons", 1925, "Fiction", true),
    new Book(4, "The Catcher in the Rye", "J.D. Salinger", 214, "Little, Brown and Company", 1951, "Fiction", true),
    new Book(5, "Pride and Prejudice", "Jane Austen", 279, "T. Egerton, Whitehall", 1813, "Romance", true),
    new Book(6, "The Hobbit", "J.R.R. Tolkien", 310, "George Allen & Unwin", 1937, "Fantasy", true),
    new Book(7, "Moby-Dick", "Herman Melville", 635, "Harper & Brothers", 1851, "Adventure", true),
    new Book(8, "War and Peace", "Leo Tolstoy", 1225, "The Russian Messenger", 1869, "Historical Fiction", true),
    new Book(9, "The Odyssey", "Homer", 541, "Ancient Greece", -800, "Epic Poetry", true),
    new Book(10, "The Divine Comedy", "Dante Alighieri", 798, "Italy", 1320, "Epic Poetry", true)
};

DisplayBookList(books);

