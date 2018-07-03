using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p06_Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var title = input[0];
                var author = input[1];
                var publisher = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd'.'MM'.'yyyy", null);
                var number = input[4];
                var price = decimal.Parse(input[5]);
                books.Add(new Book(title, author, publisher, releaseDate, number, price));
            }
            var date = DateTime.ParseExact(Console.ReadLine(), "dd'.'MM'.'yyyy", null);
            var library = new Library("Library", books);
            var information = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                if (!information.ContainsKey(book.Title))
                {
                    information.Add(book.Title, book.ReleaseDate);
                }
                else
                {
                    information[book.Title] = book.ReleaseDate;
                }
            }

            foreach (var pair in information.Where(x => x.Value > date).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:dd'.'MM'.'yyyy}");
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
        public Book(string title, string author, string publisher, DateTime releaseDate, string number, decimal price)
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
        public DateTime ReleaseDate { get; set; }
        public string Number { get; set; }
        public decimal Price { get; set; }
    }
}