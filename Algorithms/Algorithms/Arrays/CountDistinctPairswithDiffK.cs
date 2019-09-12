using System;

namespace Algorithms.Arrays
{
    class CountDistinctPairswithDiffK
    {
        //static void Main()
        //{
        //    int[] arr = { 1, 5, 3, 4, 2 };
        //    var count = countPairsWithDiffK(arr, 3);

        //    Console.WriteLine($"Count of pairs with given diff is {count}");
        //}

        static int countPairsWithDiffK(int[] arr, int k)
        {
            int count = 0;

            //sort the array first
            Array.Sort(arr);

            //remove duplicate elements


            //iterative to find the element arr[j] = arr[i] + k using Binary Search
            for (int i = 0; i < arr.Length; i++)
            {

                if (BinarySearch(arr, i +1, arr.Length - 1, arr[i] + k) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        //recursive binary search on sorted array
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
