using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    // we use the interface keyword to create an interface in c#
    // The prefix I in the interface name is just a naming convection and not a must.
    // Interfaces contain only declarations and not implementations.
    // Interface members are public by default. However you can use public access modifier
    // directly to declare interface methods.
    
    interface ICustomer {
        //Members are public by default
        //public void Print();  - causes an error

        // Declare a method
        void Print();

        // You can't implement a method in an interface, otherwise a compilation error arises.
        // eg. void Output{ Console.WriteLine("Hello World");} will cause an error.
    
       // An interface has no fields eg. int num1;
    }
    interface I2 {
        void I2Method();
    }
    // Interfaces can inherit from other interfaces.
    //A class that inherits from this interface must provide implementation for all the interface
    // members in the entire interface inheritance chain.
    interface ICustomer2 : ICustomer{
        void Print2();
    }
    // A class can inherit an interface
    // When a class inherits an interface, it has to implement all the methods of the interface

    /*
     * classes allow multiple interface inheritance 
     
     */
    class Sample : ICustomer2 {

        // Implement Print2() from interface Icustomer2
        public void Print2()
        {
            Console.WriteLine("Implement Print2() from interface Icustomer2");
        }
        // Implement Print() from the inherited interface ICustomer
        public void Print()
        {
            Console.WriteLine("Implement Print() from the inherited interface ICustomer");
        }
    }
    public class Customer : ICustomer,I2 {
        // Implementing the interface method
        public void Print() {
            Console.WriteLine("Interface Print() method.");

        
        }


        public void I2Method()
        {
            Console.WriteLine("I2 Method().");
        }
    }
    //NB: A class can implement multiple interfaces but can not inherit from multiple classes.
   /* public class Sample
    { 

    }*/
    // Example:
   /* class Prog : Customer, Sample
    { 
    
    }*/
    class Program 
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.I2Method();
            Console.WriteLine("\n");
            Sample s = new Sample();
            s.Print();
            s.Print2();
            Console.ReadLine(); 
        }
    }
}
