using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Classes
{
    /*
     *  We use the abstract keyword to define abstract classes.
     *  
     * abstract classes are incomplete ie. have abstract members
     */
    public abstract class Customer {
        // abstract method
        // abstract methods have no implementations coz it is an incomplete method.
        public abstract void Print();

        // However an abstract class can have non-abstract members which are implemented
        public void Print2() {
            Console.WriteLine("A non-abstract member of an abstract class.");
        }

        // You can't create an instance of an abstract class.
        // They can only be used as base classes for other classes.

    }
    // If a class that inherits from an abstract class doesn't provide the implementation, 
    // you can mark it as an abstract class. Otherwise there will be an error.

    /*
        Basically if a class inherits from an abstract class it has 2 options:
     *    1. Provide implementation for all the abstract members inherited from the base
     *       abstract class.
     *    
     *    2. If the class doesn't wish to provide the implementation for all the abstract members
     *       inherited from the abstract class,then the class has to be marked as abstract.
     *       
     
     */
    // Inherits from the abstract class but doesn't provide implementation
    // so we make it abstract
    public abstract class Sample : Customer {

    
    }
    // The class is not abstract, so has to provide the implemetation of all members
    // of the abstract class it's inheriting from.
    public class Program : Customer
    {

        static void Main(string[] args)
        {
            // call the implemented method
            Program p = new Program();
            p.Print();

            //OR: An abstract class reference variable can point to the derived class object
            //NB: We can't createan instance of the abstract class itself.

            Customer c = new Program();
            c.Print();
            c.Print2();

            Console.ReadLine();


        }

        // implementation
        public override void Print()
        {
            Console.WriteLine("Abstract method implemeted");
        }
    }
}
