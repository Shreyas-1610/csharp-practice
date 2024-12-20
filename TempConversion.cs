using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TempConversion
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double ans = (celsius * 9 / 5) + 32;
            return ans;
        }
    }
}
