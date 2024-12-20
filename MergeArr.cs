using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MergeArr
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                result[index++] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[index++] = arr2[i];
            }
            return result;
        }

    }
}
