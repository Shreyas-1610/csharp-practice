using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Largest
    {
        public static void largest(int first, int second, int third) {
            if (first > second && first > third)
            {
                Console.WriteLine("First number is greatest");
            }
            else if (second > third && second > first)
            {
                Console.WriteLine("Second is the highest");
            }
            else
            {
                Console.WriteLine("Third is the highest");
            }
        }
    }
}
