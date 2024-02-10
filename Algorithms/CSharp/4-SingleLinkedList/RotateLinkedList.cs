using System;

namespace Algorithms
{
    class RotateLinkedList
    {
        //O(n) time complexity
        //O(1) space
        static void RotateLinkedListByK(SLLNode head, int k)
        {
            if (head == null) return;

            var curr = head;
            int count = 1;

            while (count < k && curr != null)
            {
                curr = curr.next;
                count++;
            }

            if(curr == null) return;

            var kthnode = curr;

            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = head;

            head = kthnode.next;

            kthnode.next = null;
        }
    }
}
