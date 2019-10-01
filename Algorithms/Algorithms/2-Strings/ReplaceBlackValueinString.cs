using System.Text;

namespace Algorithms
{
    class ReplaceBlackValueinString
    {
        //static void Main()
        //{
        //    var str = "Mr John Smith   ";
        //    var output = ReplaceBlankWithValue(str.Trim(),"%20");
        //}

        //O(n) time complexity
        //O(1) space
        static string ReplaceBlankWithValue(string str, string val)
        {
            var arr = str.ToCharArray();
            var sb = new StringBuilder();
            foreach(var ch in arr)
            {                
                if(ch == ' ')
                {
                    sb.Append(val);
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
