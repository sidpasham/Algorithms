using System;
using System.ComponentModel;

namespace Algorithms
{
    class GetAllPermuationofString
    {
        //static void Main()
        //{
        //    string s = "abc";
        //    PrintAllPermuationsOfString(s);
        //    ;
        //    Console.WriteLine();
        //}

        static void PrintAllPermuationsOfString(string s)
        {
            var arr = s.ToCharArray();
            int start = 0;
            int end = arr.Length - 1;

            Permutate(arr,start,end);
            
        }

        static void Permutate(char[] arr, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(new string(arr));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(arr, start, i);
                    Permutate(arr,start + 1, end);
                    Swap(arr, start, i);
                }
            }
        }

        static void Swap(char[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[i] = temp;
        }
    }
}
