using System;

namespace Algorithms.Arrays
{
    class RandomiseArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[]{1,2,3,4,5,6,7,8};

        //    RandomiseNumbersinArray(arr, arr.Length);

        //    Console.WriteLine(string.Join("\t", arr));
        //}

        //O(n) time complexity
        //O(1) space
        static void RandomiseNumbersinArray(int[] arr, int n)
        {
            if(n == 0) return;
            Random r = new Random();

            for (int i = n - 1; i > 0; i--)
            {
                var j = r.Next(0,i+1);

                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
