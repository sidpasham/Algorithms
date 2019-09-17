using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.General
{
    public class ReverseNumber
    {
        //static void Main()
        //{
        //    int x = 5006;
        //    var output = ReverseNumberIterative(x);
        //}

        public static int ReverseNumberIterative(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + (num % 10);
                num = num / 10;
            }

            return rev_num;
        }

        public int ReverseNumberRecursive(int num, int temp)
        {
            if (num == 0) return temp;

            temp = temp * 10 + (num % 10);

            return ReverseNumberRecursive(num / 10, temp);
        }
    }
}
