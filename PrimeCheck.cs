using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrimeCheck
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;  
            if (n == 2) return true;   
            if (n % 2 == 0) return false; 

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

    }
}