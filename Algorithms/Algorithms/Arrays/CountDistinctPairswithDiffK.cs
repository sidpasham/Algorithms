using Algorithms.Searching;
using System;
using System.Collections.Generic;

namespace Algorithms.Arrays
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

        //O(n) with Hashtable
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

        //O(nLogn)
        static int CountPairsWithDiffK(int[] arr, int k)
        {
            int count = 0;

            //sort the array first
            Array.Sort(arr); //O(nLogn)

            for (int i = 0; i < arr.Length; i++)
            {
                if (BinarySearch(arr, i +1, arr.Length - 1, arr[i] + k) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        //O(Logn)
        static int BinarySearch(int[] arr, int start, int end, int x)
        {
            if (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }

                if (x > arr[mid])
                {
                    return BinarySearch(arr, mid + 1, end, x);
                }
                else
                {
                    return BinarySearch(arr, start, mid - 1,x);
                }
            }
            return -1;
        }
    }
}
