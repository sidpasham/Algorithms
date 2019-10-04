using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class BribeinArray
    {
        //static void Main()
        //{
        //    int[] q = new int[] { 1, 2 ,5, 3, 7, 8 ,6 ,4 };

        //    minimumBribes(q);
        //}
        static void minimumBribes(int[] q)
        {

            int[] sortedq = new int[q.Length];

            for (int i = 0; i < q.Length; i++)
            {
                sortedq[i] = q[i];
            }

            Array.Sort(sortedq);

            List<int> bribes = new List<int>();

            for (int i = 0; i < q.Length; i++)
            {
                if (Math.Abs(q[i] - sortedq[i]) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else
                {
                    if (!bribes.Contains(Math.Abs(q[i] - sortedq[i])))
                    {
                        bribes.Add(Math.Abs(q[i] - sortedq[i]));
                    }
                }
            }
            Console.WriteLine(bribes.Sum());
        }
    }
}
