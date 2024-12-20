using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AverageSum
    {
        public static double FindAverage(int[] arr)
        {
            double sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }
    }
}
