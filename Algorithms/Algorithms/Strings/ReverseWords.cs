using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class ReverseWords
    {
        //static void Main()
        //{
        //    string str = "Hello this is Siddhanth";
        //    var output = ReverseWordsinString(str);
        //    Console.WriteLine(output);
        //}

        static string ReverseWordsinString(string str)
        {
            int i;
            int start = str.Length - 1;
            int end = str.Length - 1;

            StringBuilder sb = new StringBuilder();

            while (start > 0)
            {
                if (str[start] == ' ')
                {
                    i = start + 1;

                    for (int j = i; j <= end; j++)
                    {
                        sb.Append(str[j]);
                    }
                    sb.Append(' ');
                    end = start - 1;
                }

                start--;
            }

            for (i = 0; i <= end; i++)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
