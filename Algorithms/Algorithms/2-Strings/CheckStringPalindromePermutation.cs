using System;

namespace Algorithms
{
    class CheckStringPalindromePermutation
    {
        //static void Main()
        //{
        //    string str1 = "geeksfogeeks";

        //    var output = IsStringPalindromePermutation(str1);
        //}

        //O(n) time complexity
        //O(1) space
        static bool IsStringPalindromePermutation(string s)
        {
            if (s.Length == 0) return true;

            int[] arr = new int[256];
            int oddCount = 0;

            foreach (var ch in s)
            {
                arr[ch]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            if (oddCount > 1) return false;

            return true;
        }
    }
}
