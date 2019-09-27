using System;

namespace Algorithms.LinkedList
{
    public class SortedMergeLinkedList
    {
        static void Main()
        {
            SingleLinkedList ll1 = new SingleLinkedList();
            ll1.InsertLast(2);
            ll1.InsertLast(4);
            ll1.InsertLast(5);
            ll1.InsertLast(1);
            ll1.InsertLast(3);

            SingleLinkedList ll2 = new SingleLinkedList();
            ll2.InsertLast(6);
            ll2.InsertLast(9);
            ll2.InsertLast(8);
            ll2.InsertLast(7);
            ll2.InsertLast(10);

            var result = SortedMergeLinkedListRecursion(ll1.head, ll2.head);

            Console.WriteLine("Completed");
        }

        public static SLLNode SortedMergeLinkedListRecursion(SLLNode n1, SLLNode n2)
        {
            if (n1 == null) return n2;
            if (n2 == null) return n1;

            SLLNode result = null;

            if (n1.data < n2.data)
            {
                result = n1;
                result.next = SortedMergeLinkedListRecursion(n1.next, n2);
            }
            else
            {
                result = n2;
                result.next = SortedMergeLinkedListRecursion(n1, n2.next);
            }
            return result;
        }
    }
}
