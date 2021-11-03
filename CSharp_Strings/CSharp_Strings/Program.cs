using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter's dog has gone missing");
            Console.WriteLine("Peter said \"My car is gone!\"");

            string phrase = "I am concatenated";
            string phrase2 = " with this.";
            Console.WriteLine(phrase + phrase2);

            Console.WriteLine("The length of the string is " + phrase.Length);
            Console.WriteLine("Uppercase string: " +phrase.ToUpper());
            Console.WriteLine("Lowercase string: "+phrase.ToLower());
            Console.WriteLine("Does the string contain the word peter? "+phrase.Contains("peter"));
            Console.WriteLine("Access xters in string "+phrase[0]+" "+phrase[7]);
            Console.WriteLine("Index of a xter: "+phrase.IndexOf("a"));
            Console.WriteLine("Index of s substring: "+phrase.IndexOf("concatenated"));
            Console.WriteLine("Negative index means not found: "+phrase.IndexOf("Peter"));
            Console.WriteLine(" "+phrase.Substring(4));
            Console.WriteLine(" "+phrase.Substring(4,3));
            
            if(phrase.StartsWith("I")){
                Console.WriteLine("Yes");
            
            }else{
                Console.WriteLine("Noooo");
            }

            if (phrase.EndsWith("Peter"))
            {
                Console.WriteLine("Yeess");
            }
            else {
                Console.WriteLine("Nooo");
            
            }

            Console.ReadLine();
        }
    }
}
