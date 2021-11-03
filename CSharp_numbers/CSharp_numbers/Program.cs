using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0.3);
            Console.WriteLine(4567890);
            Console.WriteLine(-9876);

            // Doing math with numbers
            Console.WriteLine((90-3 + 4 * 6 / 3) % 11);

           

            var num = 645;
            Console.WriteLine(num);

            int num2 = 876 ;
            num2--;
            Console.WriteLine(num2);

            num2++;
            Console.WriteLine(num2);


            // Math operations
            Console.WriteLine("Absolute value: "+Math.Abs(-70));

            Console.WriteLine("Power of a number: "+Math.Pow(3,4));

            Console.WriteLine("Square root of a number: "+Math.Sqrt(81));

            Console.WriteLine("Which is bigger: "+Math.Max(3,567));

            Console.WriteLine("Smaller number: "+Math.Min(45,56));

            Console.WriteLine("Round up a number: "+Math.Round(0.4));

            Console.WriteLine("Ceiling of a number: "+Math.Ceiling(0.4));

            Console.WriteLine("Floor of a number: "+Math.Floor(4.5));

            int a, b, quotient, result;

            a = 43;
            b = 9;

            quotient = Math.DivRem(a, b, out result);

            Console.WriteLine("The quotient of "+a+" and "+b+" is "+quotient+" with a remainder of "+result);



            Console.ReadLine();
        }
    }
}
