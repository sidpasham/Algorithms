using System;
using System.Collections.Generic;
using System.Globalization;

namespace Algorithms.LeetCode
{
    public class LongestSubstring
    {
        //public static void Main()
        //{
        //    string s = "pwwkee";
        //    var output = FindLengthofLongestSubString(s);
        //    Console.WriteLine();
        //}

        //O(n) time complexity
        //O(1) space
        public static int FindLengthofLongestSubString(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int[] cache = new int[128];
            int max = 0;
            int result = 0;

            for(int i = 0; i < s.Length; i++)
            {
                max = Math.Max(max, cache[s[i]]);
                cache[s[i]] = i + 1;

                result = Math.Max(result, i - max + 1);
            }

            return result;
        }

        //O(n) time complexity
        //O(1) space
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int left = 0;
            int right = 0;
            int max = 0;

            HashSet<char> hs = new HashSet<char>();

            while (right < s.Length)
            {
                if (hs.Contains(s[right]))
                {
                    hs.Remove(s[left++]);
                }
                else
                {
                    hs.Add(s[right]);
                    right++;
                    max = Math.Max(max, right - left);
                }
            }

            return max;

        }
    }
}

