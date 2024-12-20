using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SecondLargest
    {
        public static int Second(int[] arr)
        {
            int large = int.MinValue;
            int secondLarge = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    secondLarge = large;
                    large = arr[i];
                }
                else if (arr[i] > secondLarge && arr[i] != large)
                {
                    secondLarge = arr[i];
                }
            }

            return secondLarge;
        }

    }
}
