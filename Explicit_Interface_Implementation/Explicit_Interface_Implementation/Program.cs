using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Explicit_Interface_Implementation
{
    interface I1 {
        void Print();
    }
    // Let's say we have 2 interfaces with similar methods and a class inherits them both.
    interface I2 {
        void Print();
    }
    // class Sample inherits from interfaces with similar methods
    // Implementing the Print() method is ambigous as to from which interface the method is implemented.
    // The program will not throw error since the method hass been implemented.
    // For this reasom we use explicit interface implementation.
    class Sample : I1,I2 {

        // NB: We dont use the access modifier for explicit implementation
        void I1.Print()
        {
            Console.WriteLine("Explicitly implemeting interface I1");
        }


        void I2.Print()
        {
            Console.WriteLine("Explicitly implemeting interface I2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            // type cast to the interface
            ((I1)s).Print();
            ((I2)s).Print();

            Console.WriteLine("\n");

            // Instead of typecasting, you can do the following
            I1 t1 = new Sample();
            I2 t2 = new Sample();
            t1.Print();
            t2.Print();

            /*
               If you want a default implementation, you can implement one of the interfaces
             * implicitly eg.
             * 
             * class Sample : I1,I2 {

       // Implicit implementation
       public void Print()
       {
           Console.WriteLine("Explicitly implemeting interface I1");
       }


       void I2.Print()
       {
           Console.WriteLine("Explicitly implemeting interface I2");
       }
   }
             * Then you can do:
             * Sample s = new Sample();
             * s.Print(); - this will call the I1 method.
             * I2 f = new Sample();
             * f.Print();
             */

            Console.ReadLine();
        }
    }
}
