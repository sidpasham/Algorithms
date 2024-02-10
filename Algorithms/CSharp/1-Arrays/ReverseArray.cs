using System;

namespace Algorithms
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

        //O(Log(n)) time complexity
        //O(n) space
        static int[] ReverseArrayIterative(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
            {
                arr[i] = arr[j];
                arr[j] = arr[i];
            }

            return arr;
        }

        //O(n) time complexity
        //O(1) space
        public static int[] ReverseArrayIterative2(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

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
