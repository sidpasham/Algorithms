using System;
using System.Collections.Generic;

namespace Algorithms.Arrays
{
    class FirstRepeatingElement
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {7,9,6,7,6,2,3};
        //    var result = FirstRepeatingElementinArray(arr);
        //    Console.WriteLine(result);
        //}

        //O(n) time complexity with hashtable
        //O(n) space complexity
        static int FirstRepeatingElementinArray(int[] arr)
        {
            int min_idx = -1;

            HashSet<int> hs = new HashSet<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (hs.Contains(arr[i])) min_idx = i;
                else
                {
                    hs.Add(arr[i]);
                }
            }

            return min_idx;
        }
    }
}
