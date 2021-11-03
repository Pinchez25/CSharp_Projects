using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_objects2
{
    class Student
    {
        public string name, major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }
        // class method
        public bool hasHonours() {
            if (gpa >= 3.5) {
                return true; 
            }
            return false;
        }
    }
}
