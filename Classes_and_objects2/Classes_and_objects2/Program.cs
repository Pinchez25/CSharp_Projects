using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_objects2
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the constructor automatically
            Book bk = new Book("Peter","Pinchez",900);

            Console.WriteLine(bk.title);

            // Modify the values
            bk.title = "Hobbit";
            Console.WriteLine(bk.title);

            // This will call the second constructor
            Book bk2 = new Book();


            // Student object
            Student std = new Student("Peter", "IT", 6.7);
            Student std2 = new Student("karen", "Njeri", 2.8);

            Console.WriteLine(std.hasHonours());
            Console.WriteLine(std2.hasHonours());

            if (std2.hasHonours())
            {
                Console.WriteLine("Congratulations");
            }
            else {
                Console.WriteLine("Try harder!");
            }


            Console.ReadLine();
        }
    }
}
