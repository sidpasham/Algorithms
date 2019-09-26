using System;

namespace Algorithms.Arrays
{
    class FloorinArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {1,2,3,4,5,6 };
        //    var floor = Floor(arr, 6);
        //    if(floor != -1)
        //    {
        //        Console.WriteLine(arr[floor]);
        //    }
            
        //}

        static int Floor(int[] arr, int x)
        {
            Array.Sort(arr);

            for(int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == x) return i - 1;
                if (x > arr[i] && x <= arr[i+1]) return i - 1;
            }

            return -1;
        }
    }
}
