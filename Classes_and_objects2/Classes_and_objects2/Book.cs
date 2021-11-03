using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_objects2
{
    class Book
    {
        public string author, title;
        public int pages;

        // Constructor - it is called when we create a class object.
        public Book(string aTitle, string aAuthor, int aPages) {

            Console.WriteLine("Creating book");
            // same as bk.title = ""; in the class object.
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }

        // You can have multiple constructors
        public Book() {
            Console.WriteLine("You can have multiple constructors");
        }
    }
}
