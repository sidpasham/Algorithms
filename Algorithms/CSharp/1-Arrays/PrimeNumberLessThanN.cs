namespace Algorithms.Arrays
{
    class PrimeNumberLessThanN
    {
        public bool isPrime(int val)
        {
            if (val <= 1)
            {
                return false;
            }

            for(int i = 2; i<val; i++)
            {
                if(val % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintPrimeNumbers(int n)
        {
            if(n<1)
            {
                return;
            }

            for(int i = 1; i <n; i++)
            {
                if(isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
