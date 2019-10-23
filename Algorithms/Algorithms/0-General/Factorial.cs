using System;

namespace Algorithms
{
    class Factorial
    {
        //static void Main()
        //{
        //    int num = 5;
        //    Console.WriteLine($"Factorial of {num} is {FactorialIterative(5)}");
        //}

        //O(n) time complexity
        //O(1) space
        static double FactorialIterative(int n)
        {
            double fac = 1;

            for (int i = 2; i <= n; i++)
            {
                fac *= i;
            }

            return fac;
        }

        //O(n) time complexity
        //O(n) space because of recursion
        static double FactorialRecursive(int n)
        {
            if (n == 0) return 1;

            return n * FactorialRecursive(n - 1);
        }
    }
}
