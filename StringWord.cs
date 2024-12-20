using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringWord
    {
        public static int CountWords(string str)
        {
            string[] words = str.Split(' ');
            return words.Length;
        }
    }
}
