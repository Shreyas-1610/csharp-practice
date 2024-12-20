using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseString
    {
        public static string reverse(string s)
        {
            char[] ch = new char[s.Length];
            int j = 0;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                ch[j]=s[i];
                j++;
            }
            return new string(ch);
        }
    }
}
