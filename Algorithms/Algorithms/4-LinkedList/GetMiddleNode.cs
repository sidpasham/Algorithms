using System;

namespace Algorithms
{
    class GetMiddleNode
    {
        //static void Main()
        //{
        //    SingleLinkedList sll = new SingleLinkedList();
        //    sll.InsertLast(1);
        //    sll.InsertLast(1);
        //    sll.InsertLast(2);
        //    sll.InsertLast(2);
        //    sll.InsertLast(3);
        //    sll.InsertLast(4);
        //    sll.InsertLast(5);

        //    var middle  = GetMiddleNodeLinkedList(sll.head);

        //    Console.WriteLine();
        //}

        //O(n) time complexity
        //O(1) space
        public static SLLNode GetMiddleNodeLinkedList(SLLNode head)
        {
            if (head == null) return null;

            var fast = head.next;
            var slow = head;

            while (fast != null)
            {
                fast = fast.next;
                if (fast != null)
                {
                    fast = fast.next;
                    slow = slow.next;
                }
            }

            return slow;
        }
    }
}
