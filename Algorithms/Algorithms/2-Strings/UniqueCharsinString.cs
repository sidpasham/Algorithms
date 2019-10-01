namespace Algorithms
{
    class UniqueCharsinString
    {
        //static void Main()
        //{
        //    string str = "asdfg";
        //    var output = areCharactersUnique(str);
        //}

        //O(n) with additional data structure
        static bool IsUniqueChars(string str)
        {
            var chararr = str.ToCharArray();
            var arr = new int[128];

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

        //O(n) without additional data structure using bit comparision
        static bool areCharactersUnique(string str)
        { 
            int checker = 0;

            for (int i = 0; i < str.Length; ++i)
            {
                int val = (str[i] - 'a');

                // If bit corresponding to current character is already set 
                if ((checker & (1 << val)) > 0)
                    return false;

                // set bit in checker 
                checker |= (1 << val);
            }

            return true;
        }
    }
}
