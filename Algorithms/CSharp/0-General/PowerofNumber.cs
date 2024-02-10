using System;
namespace Algorithms
{
    public class PowerofNumber
    {
        //static void Main()
        //{
        //    var result = Power(5, 3);
        //    Console.WriteLine(result);
        //}

        //O(n) time complexity
        //O(n) space due to recursion
        public static double Power(int a, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return a;
            if (n % 2 == 0)
            {
                return Power(a, n / 2) * Power(a, n / 2);
            }
            else
            {
                return a * Power(a, n / 2) * Power(a, n / 2);
            }
        }
    }

}
