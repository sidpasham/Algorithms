using System;
using System.Collections.Generic;

namespace Algorithms.Tesla
{
    class Tesla
    {
        //static void Main()
        //{
        //    string S = "ccaaffddecee";
        //    var output = UniqueOccurences(S);

        //    string S1 = "011100";
        //    var output1 = StepsValuetoZero(S1);
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
                        if (hs.Contains(count[i] - 1))
                        {
                            max = max + count[i];
                        }
                        else
                        {
                            hs.Add(count[i] - 1);
                            max = max + 1;
                        }
                    }
                }
            }

            return max;
        }

        static int StepsValuetoZero(string S)
        {
            if (string.IsNullOrEmpty(S)) return 0;

            //var value = Convert.ToInt32(S, 2);
            var value = ConvertBinaryStringToInt(S);
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

        static int ConvertBinaryStringToInt(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int dec = 0;
            int base2 = 1;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1') dec = dec + base2;
                base2 = base2 * 2;
            }

            return dec;
        }
    }
}
