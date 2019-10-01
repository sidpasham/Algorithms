using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 5, 6, 8, 1, 3, 9, 4, 7 };

        //    QuickSortIterative(arr,0,arr.Length -1);

        //    Console.WriteLine(string.Join("\t",arr));
        //}

        static int partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];

            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            var temp1 = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp1;

            return i + 1;
        }

        //Worst Case - O(N^2)
        //Best and Avg Case - O(nLog(n))
        static void QuickSortRecursive(int[] arr, int start, int end)
        {
            if(start > end) return;

            int pi = partition(arr, start, end);

            QuickSortRecursive(arr,start,pi-1);

            QuickSortRecursive(arr, pi+1, end);

        }

        static void QuickSortIterative(int[] arr, int start, int end)
        {
            int[] st = new int[end - start +1];

            int top = -1;

            st[++top] = start;
            st[++top] = end;

            while (top >= 0)
            {
                end = st[top--];
                start = st[top--];

                int pi = partition(arr, start, end);

                if (pi - 1 > start)
                {
                    st[++top] = start;
                    st[++top] = pi - 1;
                }

                if (pi + 1 < end)
                {
                    st[++top] = pi + 1;
                    st[++top] = end;
                }
            }
        }
    }
}
