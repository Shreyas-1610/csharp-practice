using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RandomNo
    {
        public static void RandomNumber()
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1,101));
        }
    }
}
