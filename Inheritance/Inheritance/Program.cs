using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef cf = new Chef();
            cf.makeChicken();

            ItalianChef ic = new ItalianChef();
            ic.makeChicken();
            ic.makePasta();
            ic.makeSpecialDish();
            Console.ReadLine();
        }
    }
}
