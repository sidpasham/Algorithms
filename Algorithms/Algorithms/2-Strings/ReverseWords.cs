using System.Text;

namespace Algorithms
{
    class ReverseWords
    {
        //static void Main()
        //{
        //    string str = "Hello this is Siddhanth";
        //    var output = ReverseWordsInString(str);
        //    Console.WriteLine(output);
        //}

        //O(n2) time complexity
        static string ReverseWordsInString(string str)
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
