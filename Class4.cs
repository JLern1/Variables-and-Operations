//Write code to find the number of weeks and days in that total from a number of days only.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    class Class4
    {
        public static void converter(int days)
        {
            int weeks = days / 7;
            int leftOverDays = days % 7;
            Console.WriteLine("If you start with {0} days, you will have {1} weeks and {2} days.", days, weeks, leftOverDays);
            Console.ReadLine();
        }
        static void WasWasWasWasWasMain(string[] args)
        {
            int days = 23;
            converter(days);
        }
    }
}
