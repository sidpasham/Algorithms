using System;

namespace Algorithms
{
    class CeilinginArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 9,8, 7, 4, 5 };
        //    var index = FindCeilingUnSortedArray(arr, 0);
        //    var index1 = CeilinginUnsortedArray(arr, 0);            
        //    if (index == -1)
        //    {
        //        Console.WriteLine("Ceiling does not exists in array");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Ceiling in array =>{arr[index]}");
        //    }
        //}

        //O(n) ceiling in unsorted array
        static int CeilinginUnsortedArray(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;

            int ceil = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > x && arr[i] < ceil)
                {
                    ceil = arr[i];
                }
            }

            return ceil;
        }

        //O(logn) ceiling in sorted array Using Binary Search
        static int FindCeilingSortedArrayBinarySearch(int[] arr, int start, int end, int x)
        {
            if (arr.Length == 0) return -1;

            return -1;
        }

        //O(n) Ceiling in sorted array with linear search
        static int FindCeilingSortedArray(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;
            //if the first element is less than the value then return first element
            if (x <= arr[0]) return arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return arr[i + 1];
                if (arr[i] < x && arr[i + 1] > x) return arr[i + 1];
            }

            return -1;

        }       

        //O(nlogn) ceiling in unsorted array
        static int FindCeilingUnSortedArray(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;

            //sort the array
            Array.Sort(arr); //O(nlogn) 

            //O(n)
            return FindCeilingSortedArray(arr, x);
        }

       
        
    }
}
