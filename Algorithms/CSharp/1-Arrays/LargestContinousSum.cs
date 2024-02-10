using System;

namespace Algorithms.Arrays
{
    class LargestContinousSum
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {-2,-3,4,-1,-2,1,5,-3};
        //    var sum = LargestContinousSuminArray(arr);
        //    Console.WriteLine(sum);
        //}

        //Kadane's Algo O(n)
        static int LargestContinousSuminArray(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int max = 0;
            int max_curr = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                max_curr = max_curr + arr[i];

                if (max_curr < 0) max_curr = 0;

                if (max_curr > max) max = max_curr;
            }

            return max;
        }
    }
}
