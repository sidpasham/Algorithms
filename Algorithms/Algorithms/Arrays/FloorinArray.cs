using System;

namespace Algorithms.Arrays
{
    class FloorinArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        //    var floor = FloorinUnSortedArray(arr, 1);
        //    var floor1 = FloorinUnSortedArray(arr, 1);
        //    if (floor != -1)
        //    {
        //        Console.WriteLine(arr[floor]);
        //    }

        //}


        //O(n) with hashtable
        static int FloorInUnSortedArrayOptimized(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;
            if (x < arr[0]) return -1;
            int floor = int.MinValue;

            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] < x && arr[i] > floor)
                {
                    floor = arr[i];
                }
            }
            return floor;
        }

        //O(nlog(n)) due to sorting
        static int FloorinUnSortedArray(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;

            Array.Sort(arr);

            return FloorInSortedArray(arr, x);
        }

        static int FloorInSortedArray(int[] arr, int x)
        {
            if (arr.Length == 0) return -1;

            if (x <= arr[0]) return -1;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == x) return arr[i - 1];
                if (x > arr[i] && x <= arr[i + 1]) return arr[i - 1];
            }

            return -1;
        }
    }
}
