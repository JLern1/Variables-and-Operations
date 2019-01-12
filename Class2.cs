//Call this method twice asking the user to input their first and last name and display the user’s full name in the console window.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    class Class2
    {
        public static string input(string x)
        {
            Console.WriteLine("Please enter {0}...",x);
            string a = Console.ReadLine();
            return a;
        }
        public static void Display(string z)
        {
            Console.WriteLine("Your full name is {0}.", z);
            Console.ReadLine();
        }
        static void WasWasWasMain(string[] args)
        {
            string a = input("your first name");
            string b = input("your last name");
            string c = a + " " + b;
            Display(c);
        }
    }
}
