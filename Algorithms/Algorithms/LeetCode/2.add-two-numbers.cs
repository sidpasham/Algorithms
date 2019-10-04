/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        if(l1 == null && l2 == null) return null;

        ListNode head = l1;
        int carry = 0;

        while(l1 != null)
        {
            l1.val = l1.val + carry;
            if(l2 != null) l1.val = l1.val + l2.val;

            carry = l1.val / 10;
            l1.val = l1.val % 10;

            if(l1.next == null && l2 != null)
            {
                l1.next = l2.next;
                l2 = null;
            }

            if(l1.next == null && carry == 1)
            {
                l1.next = new ListNode(carry);
                l1 = l1.next;
            }
            l1 = l1.next;
            if(l2 != null){
                l2 = l2.next;
            }
        }

        return head;
        
    }
}
// @lc code=end

