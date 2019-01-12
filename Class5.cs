//Create a program that asks the user to enter 2 numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    class Class5
    {
        public static double input(string x)
        {
            Console.WriteLine("Please enter {0}...", x);
            string a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            return b;
        }
        public static void display(double c)
        {
            Console.WriteLine("The smaller of your two numbers is {0}", c);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double a = input("a number");
            double b = input("another number");
            double c = Math.Min(a, b);
            display(c);
        }
    }
}
