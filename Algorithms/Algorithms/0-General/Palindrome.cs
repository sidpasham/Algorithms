using  System;

namespace Algorithms
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

        //O(Log(n)) to base 2 time complexity
        //O(1) space
        static bool IsStringPalindrome(string str)
        {
            for(int i =0, j= str.Length - 1; i < str.Length / 2; i++,j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }

        //O(Log(n)) to base 2 time complexity
        //O(1) space
        static bool IsNumberPalindrome(int num)
        {
            if (num == 0) return true;

            var temp = ReverseNumber.ReverseNumberIterative(num);

            if (temp == num) return true;

            return false;
        }
    }
}
