namespace Algorithms.Strings
{
    class UniqueCharsinString
    {
        //static void Main()
        //{
        //    string str = "asdas";
        //    var output = IsUniqueChars(str);
        //}

        static bool IsUniqueChars(string str)
        {
            var chararr = str.ToCharArray();
            var arr = new int[256];

            foreach (var ch in chararr)
            {
                arr[ch]++;
                if (arr[ch] > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
