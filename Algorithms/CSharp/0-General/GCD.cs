namespace Algorithms
{
    class GCD
    {
        //static void Main()
        //{
        //    int a = 98, b = 56;
        //    Console.WriteLine($"GCDSimple of {a} and {b} is {GCDSimpleRecursive(a, b)}");
        //    Console.WriteLine($"GCDEuclidean of {a} and {b} is {GCDEuclideanRecursive(a, b)}");
        //}

        //O(Log min(a, b)) time complexity
        //O(n) space
        static double GCDEuclideanRecursive(int a, int b)
        {
            if (a == 0) return b;
            return GCDEuclideanRecursive(b % a, a);
        }

        //O(n) time complexity
        //O(n) space
        static double GCDSimpleRecursive(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            //base case
            if (a == b) return a;

            if (a > b) return GCDSimpleRecursive(a - b, b);

            return GCDSimpleRecursive(a, b - a);

        }
    }
}
