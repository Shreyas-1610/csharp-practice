using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SumNatural
    {
        public static int NaturalNumbers(int n)
        {
            int ans = (n * (n + 1)) / 2;
            return ans;
        }
    }
}
