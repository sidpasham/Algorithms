using System;

namespace Algorithms
{
    public class OrderofNumber
    {
        //static void Main()
        //{
        //    double num = -123456789.2365;
        //    var result = Order(num);
        //    Console.WriteLine(result);
        //}

        //O(log(n)) to base 10 time complexity
        //O(1) space
        public static int Order(double n)
        {
            int order = 0;
            double temp = n;
            while (Math.Abs(temp) > 1)
            {
                order++;
                temp = temp / 10;
            }

            return order;
        }
    }
}
