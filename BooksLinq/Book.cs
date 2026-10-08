using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLinq
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public int PublishedYear { get; set; }
        public string Genre { get; set; }
        public bool IsClassic { get; set; }

        // Default constructor
        public Book()
        {
            Id = 0;
            Title = "Unknown";
            Author = "Unknown";
            PageCount = 0;
            Publisher = "Unknown";
            PublishedYear = 0;
            Genre = "Unknown";
            IsClassic = false;
        }

        // Parameterised constructor
        public Book(int id, string title, string author, int pageCount, string publisher, int publishedYear, string genre, bool isClassic)
        {
            Id = id;
            Title = title;
            Author = author;
            PageCount = pageCount;
            Publisher = publisher;
            PublishedYear = publishedYear;
            Genre = genre;
            IsClassic = isClassic;
        }

        public override string ToString()
        {
            return $"{Id}: {Author} ({PublishedYear}). {Title}. {Publisher}." + $"\n Pages: {PageCount}, Genre: {Genre}, Classic: {IsClassic}";
        }
    }
}
