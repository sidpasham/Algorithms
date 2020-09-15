using System;

namespace Algorithms
{
    public class ReverseNumber
    {
        //static void Main()
        //{
        //    int x = 5006;
        //    var output = ReverseNumberIterative(x);
        //}

        //O(log(n)) to base 10 -- time complexity
        //O(1) space
        public static int ReverseNumberIterative(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + (num % 10);
                num = num / 10;
            }

            return rev;
        }

        //O(log(n)) to base 10 -- time complexity
        //O(n) space
        public int ReverseNumberRecursive(int num, int rev)
        {
            if (num == 0) return rev;

            rev = rev * 10 + (num % 10);

            return ReverseNumberRecursive(num / 10, rev);
        }
    }
}
