/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {

        if( x <0) return false;
        return x == ReverseNumber(x);

        
    }

    public int ReverseNumber(int x){
        int rev= 0;

        while(x >0){
            rev = rev * 10 + (x % 10);
            x = x/ 10;
        }

        return rev;
    }
}
// @lc code=end

