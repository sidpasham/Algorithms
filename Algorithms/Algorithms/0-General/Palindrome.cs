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
        //    Console.WriteLine(IsStringPalindrome("abba"));
        //    Console.WriteLine(IsStringPalindrome("abbccbba"));
        //    Console.WriteLine(IsStringPalindrome("geeks"));

        //    Console.WriteLine(IsNumberPalindrome(5005));
        //    Console.WriteLine(IsNumberPalindrome(5006));
        //}

        static bool IsStringPalindrome(string str)
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

        static bool IsNumberPalindrome(int num)
        {
            if (num == 0) return true;

            var temp = ReverseNumber.ReverseNumberIterative(num);

            if (temp == num) return true;

            return false;
        }
    }
}
