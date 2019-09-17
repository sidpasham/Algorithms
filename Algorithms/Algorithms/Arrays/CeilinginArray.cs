using System;

namespace Algorithms.Arrays
{
    class CeilinginArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 8, 7, 4,5 };
        //    //var index = FindCeilinginArray(arr, 0, arr.Length - 1, 11);
        //    var index = CeilingMethod2(arr,  7);
        //    if (index == -1)
        //    {
        //        Console.WriteLine("Ceiling does not exists in array");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Ceiling in array =>{arr[index]}");
        //    }
        //}

        //O(n)
        static int FindCeilinginArray(int[] arr, int start, int end, int x)
        {
            //if the first element is less than the value then return first element
            if (x <= arr[start]) return start;

            for (int i = start; i < end; i++)
            {
                if (arr[i] == x) return i;
                if (arr[i] < x && arr[i + 1] >= x) return i + 1;
            }

            return -1;

        }

        //O(nlogn) 
        static int CeilingMethod2(int[] arr, int x)
        {
            //sort the array
            Array.Sort(arr); //O(nlogn) 

            //O(n)
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i + 1;
                if (x > arr[i] &&  x <= arr[i+1]) return i + 1;
            }

            return -1;
        }

        //O(logn) Using Binary Search
    }
}
