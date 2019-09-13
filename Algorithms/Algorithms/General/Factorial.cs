using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.General
{
    class Factorial
    {
        //static void Main()
        //{
        //    int num = 5;
        //    Console.WriteLine($"Factorial of {num} is {FactorialIterative(5)}");
        //}

        static double FactorialRecursive(int n)
        {
            if (n == 0) return 1;

            return n * FactorialRecursive(n - 1);
        }

        static double FactorialIterative(int n)
        {
            int fac = 1, i;

            for (i = 2; i <= n; i++)
            {
                fac *= i;
            }

            return fac;
        }
    }
}
