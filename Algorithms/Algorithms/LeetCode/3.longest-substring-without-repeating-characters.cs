/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
using System.Collections.Generic;
using System;
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int left = 0;
        int right = 0;
        int max = 0;
        
        HashSet<char> hs = new HashSet<char>();        

        while(right < s.Length)
        {
            if(hs.Contains(s[right])){
                hs.Remove(s[left++]);                
            }
            else{
                hs.Add(s[right]);
                right++;
                max =  Math.Max(max, right - left);
            }
        }

        return max;
        
    }
}
// @lc code=end

