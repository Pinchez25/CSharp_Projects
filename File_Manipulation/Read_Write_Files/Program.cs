using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Read_Write_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] customers = {
                                     "Bob Smith",
                                     "Peter Thua",
                                     "Karen Njeri" 
                                 };

            string textFilePath = @"C:\Users\JOSIAH MWANGI\Desktop\react.txt";

            // Write to a text file
            File.WriteAllLines(textFilePath, customers);

            //Read from the text file
            foreach (var cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(cust);
                
            }
            Console.ReadLine();
        }
    }
}
