using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Common
    {
        public static int[] CommonElements(int[] num1, int[] num2) { 
            HashSet<int> set = new HashSet<int>(num1);
            List<int> result = new List<int>();
            foreach (int i in num2)
            {
                if (set.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
