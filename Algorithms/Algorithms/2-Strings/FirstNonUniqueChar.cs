using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class FirstNonUniqueChar
    {
        //static void Main()
        //{
        //    string s = "loveleetcode";
        //    var result = GetFirstNonUniqueCharinString(s);
        //    Console.WriteLine();
        //}

        static int GetFirstNonUniqueCharinString(string s)
        {
            var arr = s.ToCharArray();
            Dictionary<char, int> hs = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.ContainsKey(arr[i]))
                {
                    hs[arr[i]] = hs[arr[i]]+1;
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
