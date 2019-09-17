using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        //static void Main()
        //{
        //    int[] arr = new int[]{5,6,8,1,3,9,4,7};

        //    //BubbleSortRecursive(arr, arr.Length);
        //    BubbleSortIterative(arr,arr.Length);

        //    Console.WriteLine(string.Join("\t" , arr));
        //}

        //Worst Case - O(n^2)
        static void BubbleSortRecursive(int[] arr, int n)
        {
            //base case
            if(n == 1) return;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            BubbleSortRecursive(arr, n -1);
        }

        //Worst Case - O(n^2)
        //Best Case - O(n)
        //Space - O(1)
        static void BubbleSortIterative(int[] arr, int n)
        {
            bool swaped = false;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaped = true;
                    }
                }

                if(swaped == false) break;
            }
        }
    }
}
