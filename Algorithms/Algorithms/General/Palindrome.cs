using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.General
{
    class Palindrome
    {
        //static void Main()
        //{
        //    Console.WriteLine(IsPalindrome("abba"));
        //    Console.WriteLine(IsPalindrome("abbccbba"));
        //    Console.WriteLine(IsPalindrome("geeks"));
        //}

        static bool IsPalindrome(string str)
        {
            for(int i =0, j= str.Length - 1; i < str.Length / 2; i++,j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
}
