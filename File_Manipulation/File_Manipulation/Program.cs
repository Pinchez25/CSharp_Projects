using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;


namespace File_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // current directory
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());

            Console.WriteLine(di.GetType());

            Console.WriteLine("Current Directory: "+di);

            //Specific directory - Desktop
            DirectoryInfo d2 = new DirectoryInfo(@"C:\Users\JOSIAH MWANGI\Desktop");

            // The fullname of the directory ie. The absolute Path to the directory
            Console.WriteLine(d2.FullName);

            // The name of the directory ie. Desktop
            Console.WriteLine(d2.Name);

            // Parent of the directory ie. JOSIAH MWANGI
            Console.WriteLine(d2.Parent);

            // Attributes of the dir ie. ReadOnly, Directory
            Console.WriteLine(d2.Attributes);

            // When the directory was created: date and time
            Console.WriteLine(d2.CreationTime);


          
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\JOSIAH MWANGI\Desktop\Csharp");
            
            //Check if the dir exists
            Console.WriteLine(dataDir.Exists);

            // Delete a directory
            try
            {
                Directory.Delete(@"C:\Users\JOSIAH MWANGI\Desktop\Csharp");
            }
            catch (DirectoryNotFoundException e) {
                Console.WriteLine("No such directory");
            
            }
            //Create a directory
            Directory.CreateDirectory(@"C:\Users\JOSIAH MWANGI\Desktop\Music");

         

            Console.ReadLine();
        }
    }
}
