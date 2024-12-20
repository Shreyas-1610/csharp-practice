using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lcm
    {
        public static int GetLcm(int num1, int num2)
        {
            int greater = Math.Max(num1, num2);
            while (true)
            {
                if (greater % num1 == 0 && greater % num2 == 0)
                    return greater;
                greater++;
            }
        }
    }
}
