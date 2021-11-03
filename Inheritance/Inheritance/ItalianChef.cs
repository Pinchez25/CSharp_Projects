using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public void makePasta() {
            Console.WriteLine("Makes pasta");
        }
        //override a method - the method has to be virtual in the parent class
        public override void makeSpecialDish() {
            Console.WriteLine("The chef makes chicken parm");
        
        
        }
    }
}
