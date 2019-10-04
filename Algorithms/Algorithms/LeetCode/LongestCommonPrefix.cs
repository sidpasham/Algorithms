namespace Algorithms.LeetCode
{
    class LongestCommonPrefix
    {
        //static void Main()
        //{
        //    var str = new string[] { "flower", "flow", "flight" };
        //    var lcp = GetLongestCommonPrefix(str);
        //    Console.WriteLine(lcp);
        //}

        static string GetLongestCommonPrefix(string[] str)
        {
            if (str.Length == 0) return "";

            var prefix = str[0];

            for (int i = 0; i < str.Length; i++)
            {
                while (str[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }

                if (string.IsNullOrEmpty(prefix)) return "";
            }
            return prefix;
        }

    }
}
