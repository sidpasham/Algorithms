using System;
using System.Collections.Generic;

namespace Algorithms
{
    class CountDistinctPairswithDiffK
    {
        //static void Main()
        //{
        //    int[] arr = { 1, 5, 3, 4, 2 };
        //    var count = CountPairsWithDiffKOptimized(arr, 1);
        //    var count1 = CountPairsWithDiffK(arr, 1);

        //    Console.WriteLine($"Count of pairs with given diff is {count}");
        //}

        //O(n+n) time complexity with Hashtable
        //O(n) space due to hashset saving the array values
        static int CountPairsWithDiffKOptimized(int[] arr, int k)
        {
            int count = 0;

            if (arr.Length == 0) return count;

            HashSet<int> hs = new HashSet<int>();

            for(int i =0;i< arr.Length; i++)
            {
                hs.Add(arr[i]);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(hs.Contains(arr[i] + k))
                {
                    count++;
                }
            }

            return count;

        }

        //O(nLogn) time complexity due to sorting
        static int CountPairsWithDiffK(int[] arr, int k)
        {
            int count = 0;

            //sort the array first
            Array.Sort(arr); //O(nLogn)

            for (int i = 0; i < arr.Length; i++)
            {
                if (BinarySearch.RecursiveBinarySearch(arr, i +1, arr.Length - 1, arr[i] + k) != -1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
