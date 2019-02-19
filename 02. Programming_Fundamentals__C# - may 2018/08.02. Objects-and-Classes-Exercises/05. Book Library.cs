using System.Globalization;

namespace _5.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public class Book
        {
            public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                ReleaseDate = releaseDate;
                Isbn = isbn;
                Price = price;
            }

            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime ReleaseDate { get; set; }

            public string Isbn { get; set; }

            public decimal Price { get; set; }

        }
        public class Lybrary
        {
            public string Name { get; set; }

            public new List<Book> Books { get; set; }
        }




        public static void Main()
        {
            var library = new Lybrary()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };
            var booksCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < booksCount; i++)
            {
                // {title} {author} {publisher} {release date} {ISBN} {price}.
                var info = Console.ReadLine().Split(' ');
                var title = info[0];
                var author = info[1];
                var publisher = info[2];
                var releaseDate = DateTime.ParseExact(info[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = info[4];
                var price = Convert.ToDecimal(info[5]);

                var book = new Book(title, author, publisher, releaseDate, isbn, price);
                library.Books.Add(book);
            }

            var sortedLybrary = library
                .Books
                .Select(a => a.Author)
                .Distinct()
                .Select(a => new
                {
                    Author = a,
                    Sales = library.Books.Where(book => book.Author == a).Sum(p => p.Price)
                })
                .OrderByDescending(authorInfo => authorInfo.Sales)
                .ThenBy(a => a.Author)
                .ToList();

            foreach (var item in sortedLybrary)
            {
                Console.WriteLine($"{item.Author} -> {item.Sales:f2}");
            }
        }
    }
}