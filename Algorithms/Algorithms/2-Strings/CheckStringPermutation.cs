using System;

namespace Algorithms
{
    class CheckStringPermutation
    {
        //static void Main()
        //{
        //    string s1 = "abcd";
        //    string s2 = "dbca";

        //    var output = CheckStringPermuationOptimized(s1, s2);
        //}

        //O(n) count the chars in string;
        static bool CheckStringPermuationOptimized(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            int[] count = new int[128];

            for(int i = 0; i< s1.Length; i++)
            {
                count[s1[i]]++;
            }

            for(int j = 0; j < s2.Length; j++)
            {
                count[s2[j]]--;

                if (count[s2[j]] < 0) return false;
            }

            return true;

        }

        //O(nlog(n)) time complexity
        //O(n) space
        static bool CheckStringPermuation(string s1, string s2)
        {
            var char1 = s1.ToLower().ToCharArray();
            var char2 = s2.ToLower().ToCharArray();

            //O(nlog(n))
            Array.Sort(char1);
            Array.Sort(char2);

            var newstring1 = new string(char1);
            var newstring2 = new string(char2);

            if(newstring1 == newstring2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
