using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swap
    {
        public static void swap(int num1, int num2) {
            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;

            Console.Write("After reversing: " + num1 + " and " + num2); 
        }
    }
}
