using System;

namespace Algorithms
{
    class PrimeNumber
    {
        //static void Main()
        //{
        //    if (IsPrime(21))
        //        Console.Write(" true");

        //    else
        //        Console.Write(" false");
        //}

        //O(n) time complexity
        //O(1) space
        static bool IsPrime(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) k++;
            }

            if (k == 2) return true;

            return false;
        }

        //check prime number by School method -- O(Sqrt(n)) time complexity
        static bool IsPrime2(int n)
        {
            // Corner cases 
            if (n <= 1) return false;
            if (n <= 3) return true;

            // This is checked so that we can skip middle five numbers in below loop 
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }


        //check prime number by Fermats theorem -- O(nLog(n)) time complexity
        //https://www.geeksforgeeks.org/primality-test-set-2-fermet-method/
    }
}
