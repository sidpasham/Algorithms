using System;
using Algorithms.General;

namespace Algorithms
{
    class AmstrongNumber
    {
        //static void Main()
        //{
        //    var num = 1634;
        //    var result = IsAmstrongNumber2(num);
        //    Console.WriteLine(result);
        //}

        private static bool IsAmstrongNumber1(int n)
        {
            string str = n.ToString();
            var length = str.Length;
            double sum = 0;

            foreach (var ch in str)
            {
                double num1 = 0;
                if (double.TryParse(ch.ToString(), out double result))
                {
                    num1 = Math.Pow(result, length);
                }

                sum += num1;
            }

            return sum == n;
        }

        private static bool IsAmstrongNumber2(int x)
        {
            var n = OrderofNumber.Order(x);
            int temp = x;
            double sum = 0;
            while (temp != 0)
            {
                int r = temp % 10;
                sum += PowerofNumber.Power(r, n);
                temp = temp / 10;
            }

            return sum == x;
        }
    }
}
