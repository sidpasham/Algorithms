using System;

namespace Algorithms.Arrays
{
    class ReverseArray
    {
        //static void Main()
        //{
        //    int[] arr1 = { 1, 2, 3, 4, 5 };
        //    int[] arr2 = { 1, 2, 3, 4, 5 };
        //    //var output1 = ReverseArrayIterative(arr1);
        //    var output1 = ReverseArrayIterative2(arr1);
        //    var output2 = ReverseArrayRecursive(arr2, 0, arr2.Length - 1);
        //    Console.WriteLine(string.Join("\t", output1));
        //    Console.WriteLine(string.Join("\t", output2));
        //}

        //O(n) time complexity
        //O(1) space
        static int[] ReverseArrayIterative(int[] arr)
        {
            int len = arr.Length;
            int start = 0;
            int end = len - 1;

            while (start < end)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }

        //O(n) time complexity
        //O(n) space
        static int[] ReverseArrayIterative2(int[] arr)
        {
            var arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
            {
                arr2[i] = arr[j];
                arr2[j] = arr[i];
            }

            return arr2;
        }

        //O(n) time complexity
        //O(n) space
        static int[] ReverseArrayRecursive(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return arr;
            }

            var temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            return ReverseArrayRecursive(arr, start + 1, end - 1);
        }
    }
}
