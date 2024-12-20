using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Duplicate
    {
        public static int[] RemoveDuplicate(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int num in arr)
            {
                if (!list.Contains(num))
                {
                    list.Add(num);
                }
            }
            return list.ToArray();
        }
    }
}
