/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrEmpty(s)) return true;

        Dictionary<char,char> dict = new Dictionary<char, char>();
        dict.Add('(',')');
        dict.Add('{','}');
        dict.Add('[',']');

        
        Stack<char> st = new Stack<char>();
        foreach(var ch in s)
        {
            if(dict.ContainsKey(ch))
            {
                st.Push(ch);
            }
            else
            {
                if(dict.ContainsValue(ch) && st.Count > 0)
                {
                    if(ch == dict[st.First()])
                    {
                    st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }                
            }                
        }

        if(st.Count == 0) return true;

        return false;
        
    }
}
// @lc code=end

