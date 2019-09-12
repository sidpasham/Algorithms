using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class MinDiffinArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 5, 3, 19, 18, 25 };
        //    Console.WriteLine($"Minimum difference is {MinDiffPairsArray(arr)}");
        //}

        static int MinDiffPairsArray(int[] arr)
        {
            //iniatize difference to max
            int diff = int.MaxValue;

            //sort the arr
            Array.Sort(arr);

            //iterate to track min diff
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] < diff)
                {
                    diff = arr[i + 1] - arr[i];
                }
            }

            return diff;
        }
    }
}
