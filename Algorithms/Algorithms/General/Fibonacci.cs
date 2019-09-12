using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static int FibonacciRecursive(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
