using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You divided by zero");

            }
            catch (FormatException) { Console.WriteLine("Error in format"); }

            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            finally {
                Console.WriteLine("This is a division program");
            }
            

            Console.ReadLine();

        }
    }
}
