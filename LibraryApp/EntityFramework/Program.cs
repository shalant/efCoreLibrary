using BookLibrary;
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EntityFramework
{
    class Program
    {
        static IEnumerable<Author> CreateFakeData()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    Name = "Jane Austen", Books = new List<Book>
                    {
                        new Book { Title = "Emma", YearOfPublication = 1835},
                        new Book { Title = "Emma", YearOfPublication = 1835},
                        new Book { Title = "Emma", YearOfPublication = 1835 }
                    }
                },
                new Author
                {
                    Name = "Ian Fleming", Books = new List<Book>
                    {
                        new Book { Title = "Dr. No", YearOfPublication = 1835},
                        new Book { Title = "Goldfinger", YearOfPublication = 1835 },
                        new Book { Title = "From Russia with Love", YearOfPublication = 1835 }
                    }
                }
            };

            return authors;
        }

        static void Main()
        {
            var options = new DbContextOptionsBuilder<BooksContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;

            using var db = new BooksContext(options);

            db.Database.EnsureCreated();

            //var authors = CreateFakeData();

            //foreach(var author in authors)
            //{
            //    Console.WriteLine($"{author} wrote...");

            //    foreach (var book in author.Books)
            //        Console.WriteLine($"  {book}");

            //        Console.WriteLine();
            //}
        }
    }
}