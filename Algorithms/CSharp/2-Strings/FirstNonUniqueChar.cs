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

        static int FirstUniqueCharacterinString(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return -1;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i =0; i< s.Length; i++)
            {
                if(map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map.Add(s[i], 1);
                }
            }

            for(int j = 0; j< s.Length; j++)
            {
                if(map[s[j]] == 1)
                {
                    return j;
                }
            }

            return -1;
        }
    }
}
