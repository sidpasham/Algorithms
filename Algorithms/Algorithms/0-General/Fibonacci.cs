using System;

namespace Algorithms.General
{
    class Fibonacci
    {
        //static void Main()
        //{
        //    Console.Write("Enter the length of the Fibonacci Series: ");
        //    int length = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < length; i++)
        //    {
        //        Console.Write("{0} ", FibonacciFormula(i));
        //    }
        //    Console.WriteLine($"The Nth Fibonacci = {FibonacciFormula(length)}");
        //    Console.ReadLine();
        //}

        //Time Complexity:O(n)
        //Extra Space: O(1)
        static int NthFibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;

            if (n == 0) return a;

            for (int i = 2; i <= n; i++)
            {
                var temp = a;
                a = b;
                b = temp + b;
            }

            return b;
        }

        //Time Complexity:O(n)
        //Extra Space: O(n)
        static int NthFibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return NthFibonacciRecursive(n - 1) + NthFibonacciRecursive(n - 2);
        }

        //Time Complexity: O(1)
        //Space Complexity: O(1)
        static int FibonacciFormula(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int)Math.Round(Math.Pow(phi, n)
                                   / Math.Sqrt(5));
        }

        static int SumFibonacci(int n)
        {
            return NthFibonacciIterative(n + 2) - 1;
        }
    }
}
