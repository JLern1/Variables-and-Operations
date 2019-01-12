//Create a display method that sends in a string, an integer, and a double to the method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    public class Class1
    {
        public static void display(int x, double y, string z)
        {
            Console.WriteLine("{0}, {1}, {2}", x, y, z);
            Console.ReadLine();
        }
        static void WasWasMain(string[] args)
        {
            display(2, 3.4, "haha");
        }
    }
}
