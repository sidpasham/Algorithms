using System;
using System.Collections.Generic;

namespace Algorithms.Cricut
{
    class Cricut
    {
        // static void Main()
        // {

        //     var factorialremainder = FactorialRemainder(1000);
        //     Console.WriteLine(factorialremainder);

        // }

        private static int FactorialRemainder(int n){
            if (n == 0)
                return 1;
            var counter = 0;
            for(int i =1; i<=n; i++)
            {
                if (isPrime(i))
                    counter++;
            }

            return counter;
        }

        private static bool isPrime(int n)
        {
            // Corner cases
            if (n == 1)
                return true;
            if (n <= 3)
                return true;

            // Number divisible by 2
            // or 3 are not prime
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            // Iterate from 5 and keep
            // checking for prime
            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }


    }

}