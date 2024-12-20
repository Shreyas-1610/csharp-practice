using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Table
    {
        public static void Multiply(int num)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(("{0} X {1} = {2}", num, i, num * i));
            }
        }
    }
}
