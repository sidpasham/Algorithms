using System;

namespace Algorithms.General
{
    class GCD
    {
        //static void Main()
        //{
        //    int a = 98, b = 56;
        //    Console.WriteLine($"GCDSimple of {a} and {b} is {GCDSimpleRecursive(a, b)}");
        //    Console.WriteLine($"GCDEuclidean of {a} and {b} is {GCDEuclideanRecursive(a, b)}");
        //}

        static double GCDSimpleRecursive(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            //base case
            if (a == b) return a;

            if (a > b) return GCDSimpleRecursive(a - b, b);

            return GCDSimpleRecursive(a, b - a);

        }

        //Time Complexity: O(Log min(a, b))
        static double GCDEuclideanRecursive(int a, int b)
        {
            if (b == 0) return a;
            return GCDEuclideanRecursive(b, a % b);
        }
    }
}
