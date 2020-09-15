using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class Median
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {1,2,3,4,5,6};
        //    var median = FindMedian(arr);
        //    Console.WriteLine(median);
        //}

        //O(n)
        static double FindMedian(int[] arr)
        {
            var n = arr.Length;

            if (n % 2 == 0)
            {
                return (arr[(n - 1) / 2] + arr[n / 2])/2.0;
            }
            else
            {
                return (double)arr[n / 2];
            }
        }
    }
}
