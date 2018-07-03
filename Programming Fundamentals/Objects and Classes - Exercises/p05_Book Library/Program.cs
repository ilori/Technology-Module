using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p05_Book_Library
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var books = new List<Book>();


            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var releaseDate = tokens[3];
                var number = tokens[4];
                var price = decimal.Parse(tokens[5]);
                var currentBook = new Book(title, author, publisher, releaseDate, number, price);
                books.Add(currentBook);
            }

            var library = new Library("Library", books);

            var authorPriceInformation = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (!authorPriceInformation.ContainsKey(book.Author))
                {
                    authorPriceInformation[book.Author] = 0;
                }
                authorPriceInformation[book.Author] += book.Price;
            }
            foreach (var author in authorPriceInformation.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }

    public class Library
    {
        public Library(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }

        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public Book(string title, string author, string publisher, string releaseDate, string number, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Number = number;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Number { get; set; }
        public decimal Price { get; set; }
    }
}