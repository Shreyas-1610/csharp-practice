using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Frequency
    {
        public static void count(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
            Console.WriteLine("Frequency of elements:");
            foreach(var entry in dic)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
