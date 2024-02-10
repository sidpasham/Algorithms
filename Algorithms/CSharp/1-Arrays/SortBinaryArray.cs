using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class SortBinaryArray
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {0,0,1,1,1,0,1,0,1,1,1,0,0 };

        //    var output = SortArrayinBinaryOrder(arr);

        //    Console.WriteLine(string.Join("\t", output));
        //}

        static int[] SortArrayinBinaryOrder(int[] arr)
        {
            var sum = arr.Sum();

            for(int i = 0; i< arr.Length - sum; i++)
            {
                arr[i] = 0;
            }
            for(int i= arr.Length - sum; i < arr.Length; i++)
            {
                arr[i] = 1;
            }

            return arr;
        }
    }
}
