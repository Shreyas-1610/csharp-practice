using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vowels
    {
        public static int vowel(string s)
        {
            int cnt = 0;
            string str = s.ToLower();
            char[] chars = str.ToCharArray();
            for (int ch = 0; ch < chars.Length; ch++)
            {
                if (chars[ch] == 'a' || chars[ch] == 'e' || chars[ch] == 'i' || chars[ch] == 'o' || chars[ch] == 'u')
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
