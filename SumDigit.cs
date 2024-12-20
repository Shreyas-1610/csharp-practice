using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SumDigit
    {
        public static int TotalSum(int num)
        {
            int total = 0, temp = num;
            while (temp > 0)
            {
                int rem = temp % 10;
                total += rem;
                temp /= 10;
            } 
            return total;
        }
    }
}
