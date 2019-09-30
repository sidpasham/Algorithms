using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    class RemoveNthNodefromEnd
    {
        //static void Main()
        //{
        //    SingleLinkedList sll = new SingleLinkedList();
        //    sll.InsertLast(1);
        //    sll.InsertLast(2);

        //    var output = RemoveNthNodeFromEndLinkedList(sll.head, 2);

        //    Console.WriteLine();

        //}

        static SLLNode RemoveNthNodeFromEndLinkedList(SLLNode head, int n)
        {
            if (head == null) return null;
            SLLNode temp = new SLLNode(0);
            temp.next = head;
            int length = 0;
            var curr = head;
            while (curr != null)
            {
                length++;
                curr = curr.next;
            }

            length = length - n;
            curr = temp;
            while (length > 0)
            {
                length--;
                curr = curr.next;
            }
            curr.next = curr.next.next;

            return temp.next;
        }
    }
}
