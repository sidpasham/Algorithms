using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    class ReverseLinkedList
    {
        static void Main()
        {
            SingleLinkedList sll = new SingleLinkedList();

            sll.InsertLast(1);
            sll.InsertLast(2);
            sll.InsertLast(3);

            sll.head = Reverse(sll.head);
        }

        static SLLNode Reverse(SLLNode head)
        {
            SLLNode prev = null;
            SLLNode next = null;
            SLLNode curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
