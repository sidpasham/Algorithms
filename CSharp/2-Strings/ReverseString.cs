using System;

namespace Algorithms
{
    class ReverseString
    {
        //static void Main()
        //{
        //    string str = "Helloq";
        //    var output = ReverseStringIterative(str);
        //    Console.WriteLine(output);
        //}

        //O(Log(n)) time complexity
        //O(1) space
        static string ReverseStringIterative(string str)
        {
            var arr1 = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                arr1[i] = str[j];
                arr1[j] = str[i];
            }

            return new string(arr1);
        }

        //O(n) time complexity
        //O(1) space
        static string ReverseStringIterative2(string str)
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
        
    }
}
