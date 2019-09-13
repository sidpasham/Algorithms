using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class CheckStringPermutation
    {
        //static void Main()
        //{

        //}

        static bool checkstringperumations(string s1, string s2)
        {
            var char1 = s1.ToLower().ToCharArray();
            var char2 = s2.ToLower().ToCharArray();

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
