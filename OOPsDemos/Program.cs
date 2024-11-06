using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiction b1 = new Fiction();
            b1.AuthorID = 101;
            b1.BookName = "Liliput";
            b1.Price = 1000;
            b1.BookType = "Fiction";

            Novels b2 = new Novels();
            b2.AuthorID = 102;
            b2.Price = 1900;
            b2.BookName = "Novels1";
            b2.BookType = "Novel";

            Console.WriteLine($"Authorid= {b1.AuthorID}, BookName={b1.BookName}, Price= {b1.Price} , Type={b1.BookType}");
            Console.WriteLine($"Authorid= {b2.AuthorID}, BookName={b2.BookName}, Price= {b1.Price} , Type={b1.BookType}");
            Console.Read();



        }
    }
}
