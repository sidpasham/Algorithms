using System;

namespace Algorithms.Arrays
{
    class MinDiffPairsArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 5, 3, 19, 18, 25 };
        //    Console.WriteLine($"Minimum difference is {MinDiffPairsInArray(arr)}");
        //}

        //O(nLog n) time complexity
        static int MinDiffPairsInArray(int[] arr)
        {
            int diff = int.MaxValue;

            Array.Sort(arr); //O(nlogn)

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] < diff)
                {
                    diff = arr[i + 1] - arr[i];
                }
            }

            return diff;
        }
    }
}
