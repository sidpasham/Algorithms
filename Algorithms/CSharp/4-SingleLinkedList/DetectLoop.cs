using System.Collections.Generic;

namespace Algorithms
{
    class DetectLoop
    {
        //static void Main()
        //{
        //    SingleLinkedList sll = new SingleLinkedList();

        //    sll.InsertLast(1);
        //    sll.InsertLast(2);
        //    sll.InsertLast(3);
        //    sll.InsertLast(4);
        //    sll.InsertLast(5);

        //    var output = DetectLoopLinkedList(sll.head);

        //    var output1 = DetectLoopFloydsCycle(sll.head);

        //    Console.WriteLine(output);
        //}

        //O(n) time complexity
        //O(1) space due to hashset
        static bool DetectLoopFloydsCycle(SLLNode head)
        {
            if (head == null) return false;

            SLLNode slow = head;
            SLLNode fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

        //O(n) time complexity
        //O(n) space due to hashset
        static bool DetectLoopLinkedList(SLLNode head)
        {
            if (head == null) return false;
            HashSet<SLLNode> hs = new HashSet<SLLNode>();
            var curr = head;
            while(curr != null)
            {
                if (hs.Contains(curr))
                {
                    return true;
                }

                hs.Add(curr);
                curr = curr.next;
            }
            return false;
        }
        
    }
}
