//Write a method that prompts the user to hit any key to continue. Call this method from the main method 3 times.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    class Class3
    {
        public static void HitAnyKey()
            {
            Console.WriteLine("Hit Any Key to continue!");
            Console.ReadLine();
            }
        static void WasWasWasWasMain(string[] args)
        {
            HitAnyKey();
            HitAnyKey();
            HitAnyKey();
        }
    }
}
