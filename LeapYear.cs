using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LeapYear
    {
        public static void CheckLeap(int year)
        {
            if(((year%4==0) && (year % 100!= 0))|| (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year",year);
            }
        }
    }
}
