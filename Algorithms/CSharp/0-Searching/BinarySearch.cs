using System;

namespace Algorithms
{
    //Algorithmic Paradigm: Decrease and Conquer.

    public static class BinarySearch
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 2, 3, 4, 10, 40 };
        //    int n = arr.Length;
        //    int x = 10;

        //    //int result = RecursiveBinarySearch(arr, 0, n - 1, x);
        //    int result = IterativeBinarySearch(arr,  x);

        //    if (result == -1)
        //        Console.WriteLine("Element not present");
        //    else
        //        Console.WriteLine("Element found at index " + result);
        //}

        //O(LogN) = Time Complexity
        //O(LogN) = Space Complexity
        public static int RecursiveBinarySearch(int[] arr, int start, int end, int val)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == val) return mid;

                if (val < arr[mid])
                {
                    return RecursiveBinarySearch(arr, start, mid - 1, val);
                }

                return RecursiveBinarySearch(arr, mid + 1, end, val);

            }

            return -1;
        }

        //O(LogN) = Time Complexity
        //O(1) = Space Complexity
        public static int IterativeBinarySearch(int[] arr, int val)
        {
            int start = 0, end = arr.Length - 1;

            while (start<=end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == val) return mid;

                if (val > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
