using System;

namespace Algorithms.Arrays
{
    class KthLargestOrSmallest
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

        //    var output = KthLargestElement(arr, 3);

        //    Console.WriteLine(output);

        //}

        //O(nlogn)
        static int KthLargestElement(int[] arr, int k)
        {
            Array.Sort(arr); //O(nlogn)
            Array.Reverse(arr);

            return arr[k - 1];

        }

        //O(n) solution by optimizing the quick sort
        //https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array-set-3-worst-case-linear-time/
    }
}
