using System;
using System.Collections.Generic;

namespace Algorithms.Tesla
{
    class Tesla
    {
        //static void Main()
        //{
        //    string S = "example";
        //    var output = UniqueOccurences(S);

        //    //string S = "011100";
        //    //var output1 = StepsValuetoZero(S);
        //    Console.WriteLine();
        //}

        static int UniqueOccurences(string S)
        {
            if (string.IsNullOrEmpty(S)) return 0;

            int n = S.Length;

            HashSet<int> hs = new HashSet<int>();

            int max = 0;

            int[] count = new int[128];

            for (int i = 0; i < n; i++)
            {
                count[S[i]]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    if (!hs.Contains(count[i]))
                    {
                        hs.Add(count[i]);
                    }
                    else
                    {
                        for(int j = 1; j <= count[i]; j++)
                        {
                            if(hs.Contains(count[i] - j))
                            {
                                max = max + count[i];
                                break;
                            }
                            else
                            {
                                hs.Add(count[i] - j);
                                max = max + j;
                                break;
                            }
                        }
                    }
                }
            }

            return max;
        }

        static int StepsValuetoZero(string S)
        {
            if (string.IsNullOrEmpty(S)) return 0;

            var value = Convert.ToInt32(S, 2);
            int count = 0;

            while (value > 0)
            {
                if (value % 2 == 0)
                {
                    value = value / 2;
                }
                else
                {
                    value = value - 1;
                }

                count++;
            }
            return count;
        }
    }
}
