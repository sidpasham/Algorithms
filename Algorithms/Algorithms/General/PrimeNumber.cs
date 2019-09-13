using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.General
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
    }
}
