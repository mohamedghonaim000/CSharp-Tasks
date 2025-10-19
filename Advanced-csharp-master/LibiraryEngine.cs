using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__assigment
{
    delegate bool BookFuncition (Book book);    
    internal class LibiraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookFuncition fptr) {
            foreach (Book book in books) { 
                Console.WriteLine(fptr(book));
            }
        }
        public static void ProcessBooks2(List<Book> books, Func<Book, bool> predicate)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(predicate(book));
            }
        }
    }
}
