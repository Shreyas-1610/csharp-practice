using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gcd
    {
        public static int gcd(int x, int y)
        {
            int result = Math.Min(x, y);
            while (result > 0)
            {
                if (x % result == 0 && y % result == 0)
                {
                    break;
                }
                result--;
            }
            return result;
        }
    }
}
