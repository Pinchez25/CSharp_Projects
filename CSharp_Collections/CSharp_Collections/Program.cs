using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code
            Console.WriteLine("\n===================  ArrayLists ===================\n");
            // Array lists are basically resizable arrays
            // They can hold elements of multiple data types
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            // add an object array
            aList2.AddRange(new object[] {"Mike","Sally","Egg" });

            // add another array list - merge 2 array lists
            aList.AddRange(aList2);

            //loop through an array
            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }

            // sort the array - 
            aList2.Sort();// only works if the array has elements of the same data type
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array");
            Console.WriteLine("=========================");
            foreach (var item in aList2)
            {
                
                Console.WriteLine(item);
            }

            // Reverse the elements
            aList.Reverse();
            //Console.WriteLine(aList);
            Console.WriteLine("Reversed Array");
            Console.WriteLine("=========================");
            foreach (var item in aList)
            {

                Console.WriteLine(item);
            }

            //Insert data at a specific location
            aList2.Insert(1, "Turkey");

            Console.WriteLine("\n===========================");
            ArrayList range = aList2.GetRange(0, 2);
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            // Remove an item
            //aList2.RemoveAt(0);

            // Remove many items at once
            //aList2.RemoveRange(0, 2);

            // Search an item
            Console.WriteLine("Turkey Index: {0}",aList2.IndexOf("Turkey",0));

            // Convert an arrayList into a string array
            string[] myArray = (string[])aList2.ToArray(typeof(string));

            // convert a string array to an array list
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList cust = new ArrayList();
            cust.AddRange(customers);
            Console.WriteLine("\n");
            foreach (var item in cust)
            {
                Console.WriteLine(item);
                
            }
            #endregion

            #region Dictionaries Code
            Console.WriteLine("\n====================Dictionaries in C#======================\n");
            // Dictionaries store key value pairs
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            // Add key,value pairs to the dictionary
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");
            superheroes.Add("Tony Stark", "Iron Man");
            superheroes.Add("Peter Parker", "Spider Man");
            superheroes.Add("King T'Chaka", "Black Panther");


            // Remove an item
            superheroes.Remove("Barry West");

            // number of keys
            Console.WriteLine("Count: {0}", superheroes.Count);

            // Check if a key is present
            Console.WriteLine("Clark Kent: {0}",superheroes.ContainsKey("Clark Kent"));

            // get value for the key and store in a string
            string test;
            superheroes.TryGetValue("Clark Kent",out test);

            Console.WriteLine("Clark Kent: "+test);

            // Loop thro' the key value pairs
            foreach (var item in superheroes)
            {
                Console.WriteLine(item);
                Console.WriteLine("Key: "+item.Key+" Value: "+item.Value);
                Console.WriteLine("\n");
                // Console.WriteLine(item.Value);
            }
            // Delete every item
            superheroes.Clear();

            #endregion

            #region Queues Code
            Console.WriteLine("\n========================= Queues in c# ======================\n");
            Queue qu = new Queue();

            //add items to the queue
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            // loop
            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }
            // check if an item is in the queue
            Console.WriteLine("\nRemove 1: " + qu.Contains(1));

            // Dequeue() removes the 1st element of the queue
            Console.WriteLine("\n1 in Queue: " + qu.Dequeue());

            // Check the first element of the queue
            Console.WriteLine("\nPeek 1: " + qu.Peek());

            // copy a queue to an array
            object[] numArray = qu.ToArray();
            Console.WriteLine(string.Join(", ",numArray));

            // clear the array
            qu.Clear();
            #endregion
            

            #region Stacks Code
            Console.WriteLine("\n======================= Stacks in c# =====================\n");
            // Similar to a queue but uses LIFO
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine("Peek: " + st.Peek());



            foreach (var item in st)
            {
                Console.WriteLine("Stack: " + item);
            }
            //Pop an item
            st.Pop();
            Console.WriteLine("Count: "+st.Count);

            // Check if it contains an element
            Console.WriteLine("Contains 3: " + st.Contains(3));
            
            // Copy to an object array
            object[] numArray2 = st.ToArray();
            Console.WriteLine(string.Join(">",numArray2));

            //clear the stack
            st.Clear(); 

            #endregion

            Console.ReadLine();


        }
    }
}
