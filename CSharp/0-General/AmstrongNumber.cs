using System;

namespace Algorithms
{
    class AmstrongNumber
    {
        //A positive integer of n digits is called an Armstrong number of order n (order is number of digits) if
        //abcd... = pow(a, n) + pow(b, n) + pow(c, n) + pow(d, n) + .... 

        //Example:
        //Input : 153
        //Output : Yes
        //153 is an Armstrong number.
        //1*1*1 + 5*5*5 + 3*3*3 = 153

        //static void Main()
        //{
        //    var num = 1634;
        //    var result = IsAmstrongNumber2(num);
        //    Console.WriteLine(result);
        //}

        //O(n) time complexity
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

        //O(n) time complexity with string changes
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
    }
}
