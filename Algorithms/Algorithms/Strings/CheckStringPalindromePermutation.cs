using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class CheckStringPalindromePermutation
    {
        //static void Main()
        //{
        //    string str1 = "geeksfogeeks";

        //    var output = IsStringPalindromePermutation(str1);
        //}

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
