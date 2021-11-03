using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // string datatype - declared using double quotes.
            string phrase = "My name is Peter";

            // char datatype - declared using a single quote.
            char grade = 'A';

            // char also takes unicode
            char ch1 = '\u0042';

            // or hexadecimal
            char ch2 = '\x0072';

            // cast from integer
            char ch4 = (char) 234;

            Console.WriteLine(ch4);

            // integer - 32 bit ranging from -231 to 231-1;
            int age = 45;

            //boolean
            bool isDead = true;

            // float - requires an F suffix
            float probability = 0.56F;

            // double - used in most use cases.
            double probs = 0.56;// or 0.56D;

            // decimal - more precise useful for like money
            // has an M suffix. Best for monetary calculations.
            decimal cash = 45.98M;

            // Signed integral - hold integer values (+ve and -ve) from -128 to 127. ie 8 bytes.
            sbyte level = 23;

            // short  -  16 bit integer ranging from -32768 to 32767
            short level2 = 23445;


            // long  - 64 bit has an L suffix
            long range = -76328943L;


            // unsigned integral (byte,ushort,uint,ulong)
            // These datatypes hold values equal to or greater than 0.
            // Used when we are use we wont have negative values
            byte age3 = 65;//8 bit

            ushort value3 = 23232;//16bit

            uint score = 23456754;//32 bit

            ulong score2 = 45789087655L;//64 bit


           



            Console.ReadLine();
        }
    }
}
