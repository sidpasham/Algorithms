using System;
using System.Collections.Generic;

namespace Algorithms
{
    class FirstNonUniqueChar
    {
        //static void Main()
        //{
        //    string s = "loveleetcode";
        //    var result = GetFirstNonUniqueCharinString(s);
        //    Console.WriteLine();
        //}

        //O(n) time complexity
        //O(n) space due to storing elements in Dictionary
        static int GetFirstNonUniqueCharinString(string s)
        {
            var arr = s.ToCharArray();
            var hs = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.ContainsKey(arr[i]))
                {
                    hs[arr[i]]++;
                }
                else
                {
                    hs.Add(arr[i], 1);
                }
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (hs[arr[j]] == 1)
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
