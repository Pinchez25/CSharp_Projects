using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getter_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Josh Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            
            // This code causes an error coz the rating variable is private.
            //shrek.rating = "PG-19";
            Console.WriteLine(avengers.Rating);//NR

            shrek.Rating = "Cat";
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}
