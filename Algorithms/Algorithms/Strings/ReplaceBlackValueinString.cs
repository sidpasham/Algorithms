using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class ReplaceBlackValueinString
    {
        static void Main()
        {
            var str = "Mr John Smith   ";
            var output = ReplaceBlankwithValue(str.Trim());
        }

        static string ReplaceBlankwithValue(string str)
        {
            var arr = str.ToCharArray();
            var sb = new StringBuilder();
            foreach(var ch in arr)
            {                
                if(ch == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
    }
}
