//returns the quotient of those integers to be displayed rounded to two decimal places
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_And_Operations
{
    class Variables_And_Operations
    {
        public static double QuotientMethod(int x, int y)
        {
            double result = (double)x / y;
            return Math.Round(result, 2);
        }
        static void wasMain(string[] args)
        {
            double b = QuotientMethod(200, 3);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
