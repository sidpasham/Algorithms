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
        //        Console.Write("{0} ", FibonacciIterative(i));
        //    }
        //    Console.ReadKey();
        //}

        //Time Complexity:O(n)
        //Extra Space: O(1)
        static int FibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                var temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        //Time Complexity:O(n)
        //Extra Space: O(n)
        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        //Time Complexity: O(1)
        //Space Complexity: O(1)
        static int FibonacciFormula(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int)Math.Round(Math.Pow(phi, n)
                                   / Math.Sqrt(5));
        }
    }
}
