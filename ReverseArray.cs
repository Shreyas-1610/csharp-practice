using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseArray
    {
        public static void ReverseArr(int[] arr)
        {
            int n = arr.Length;
            int i = 0, j = n - 1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
