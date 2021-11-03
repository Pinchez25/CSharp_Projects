using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            sayHi("Jake");
            Sing();
            Console.WriteLine(Cube(3));
            Console.ReadLine();
        }
        static void sayHello() {
            Console.WriteLine("Hi Peter");
        }

        //parameterised method
        static void sayHi(string name) {
            Console.WriteLine("Hello " + name);
        }
        // default parameters
        static void Sing(string song = "Controlla") {
            Console.WriteLine("I am singing " + song);
        
        }

        // Return statements
        static int Cube(int num) {

            return num * num * num;
        
          
        }
    }
}
