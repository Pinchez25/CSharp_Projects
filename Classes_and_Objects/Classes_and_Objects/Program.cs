using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //book object
            Book bk = new Book();

            bk.author = "JK Rowling";
            bk.title = "Harry Potter";
            bk.pages = 350;

            Console.WriteLine(bk.title);
            Console.WriteLine(bk.pages);
            Console.WriteLine(bk.author);

            Console.WriteLine("\n");

            // another book object
            Book bk2 = new Book();

            bk2.author = "Lord of the Rings";
            bk2.title = "Tolkein";
            bk2.pages = 700;

            Console.WriteLine(bk2.title);
            Console.WriteLine(bk2.pages);
            Console.WriteLine(bk2.author);

            Console.ReadLine();
        }
    }
}
