using System;

namespace Algorithms.Strings
{
    class ReverseString
    {
        //static void Main()
        //{
        //    string str = "Hello";
        //    var output = ReverseString2(str);
        //    Console.WriteLine(output);
        //}

        static string ReverseString1(string str)
        {
            var arr = str.ToCharArray();

            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return new string(arr);
        }

        static string ReverseString2(string str)
        {
            var arr1 = str.ToCharArray();
            for(int i = 0, j = str.Length - 1; i < str.Length/2; i++,j--)
            {
                arr1[i] = str[j];
                arr1[j] = str[i];
            }

            return new string(arr1);
        }
    }
}
