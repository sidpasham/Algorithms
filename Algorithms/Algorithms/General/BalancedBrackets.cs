using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.General
{
    class BalancedBrackets
    {
        //static void Main()
        //{
        //    string input = "{{}}(){[]";
        //    var output = IsBracketsBalancedWithStackandDictonary(input);
        //    Console.WriteLine(output);
        //}

        public static bool IsBracketsBalancedWithStackandDictonary(string input)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>() {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
                { '<', '>' }
            };

            Stack<char> st = new Stack<char>();
            try
            {
                foreach (char c in input)
                {
                    if (dict.Keys.Contains(c))
                    {
                        st.Push(c);
                    }
                    else
                    if (dict.Values.Contains(c))
                    {
                        if (c == dict[st.First()])
                        {
                            st.Pop();
                        }
                        else
                            return false;
                    }
                    else
                        continue;
                }
            }
            catch
            {
                return false;
            }
            return !st.Any() ? true : false;
        }

        static bool IsBracketsBalancedWithStack(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                Stack<char> st = new Stack<char>();
                foreach (char c in s)
                {
                    if (c == '{') st.Push(c);
                    if (c == '[') st.Push(c);
                    if (c == '(') st.Push(c);
                    if (c == '}') st.Pop();
                    if (c == ']') st.Pop();
                    if (c == ')') st.Pop();
                }

                bool isvalid;
                if (st.Count == 0)
                {
                    isvalid = true;
                }
                else
                {
                    isvalid = false;
                }

                return isvalid;
            }
            else
            {
                return false;
            }
        }

    }
}
