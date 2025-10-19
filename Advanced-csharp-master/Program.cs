using System;
using System.Collections.Generic;

namespace c__assigment
{
    internal class Program
    {
        static bool fun(Book book) {
            return book.Price > 5000;
        }
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>() {
                new Book("fjvn", "frrkg", new string[] { "fjgnd" }, new DateTime(2025, 2, 22), 7000m),
                new Book("fjvn", "frrkg", new string[] { "fjgnd" }, new DateTime(2025, 2, 22), 4000m),
                new Book("fjvn", "frrkg", new string[] { "fjgnd" }, new DateTime(2025, 2, 22), 10000m),
                new Book("fjvn", "frrkg", new string[] { "fjgnd" }, new DateTime(2025, 2, 22), 2000m),
            };
            LibiraryEngine.ProcessBooks(list , fun );
            LibiraryEngine.ProcessBooks2(list , fun );
        }
    }
}
