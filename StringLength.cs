using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringLength
    {
        public static int length(string s)
        {
            int cnt = 0;
            string str = s.Trim();
            foreach (char c in str)
            {
                cnt++;
            }
            return cnt;
        }
    }
}
