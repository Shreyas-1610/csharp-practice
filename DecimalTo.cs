using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DecimalTo
    {
        public static void DecimalConvert()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int remainder = 0;
            string res = string.Empty;
            while (num > 0) {
                remainder = num % 2;
                num /= 2;
                res = remainder.ToString()+ res;
            }
            Console.WriteLine($"Binary: {res}");
        }
    }
}
