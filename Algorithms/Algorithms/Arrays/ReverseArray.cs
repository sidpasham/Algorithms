using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class ReverseArray
    {
        //static void Main()
        //{
        //    int[] arr1 = {1, 2, 3, 4, 5};
        //    int[] arr2 = { 1, 2, 3, 4, 5 };
        //    var output1 = ReverseArrayIterative(arr1);
        //    var output2 = ReverseArrayRecursive(arr2, 0, arr2.Length -1);
        //    Console.WriteLine(string.Join("\t",output1));
        //    Console.WriteLine(string.Join("\t", output2));
        //}

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
