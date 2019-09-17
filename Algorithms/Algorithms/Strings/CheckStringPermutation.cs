using System;

namespace Algorithms.Strings
{
    class CheckStringPermutation
    {
        //static void Main()
        //{

        //}

        //O(nlog(n))
        static bool checkstringperumations(string s1, string s2)
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

        //O(n) - Count Chars https://www.geeksforgeeks.org/check-if-two-strings-are-permutation-of-each-other/

    }
}
