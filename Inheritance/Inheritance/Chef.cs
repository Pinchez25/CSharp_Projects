using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Chef
    {
        public void makeChicken() {
            Console.WriteLine("The chef makes chicken");
        
        }
        public void makeSalad() {
            Console.WriteLine("The chef makes salad");
        }
        // the virtual keyword makes it possible for a method to be overriden in any of the sub-classes
        public virtual void makeSpecialDish() {
            Console.WriteLine("The chef makes bbq ribs");
        }

    }
}
