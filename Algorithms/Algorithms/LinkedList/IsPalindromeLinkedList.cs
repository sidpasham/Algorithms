using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    class IsPalindromeLinkedList
    {
        //static void Main()
        //{
        //    SingleLinkedList sll = new SingleLinkedList();
        //    sll.InsertLast(0);
        //    sll.InsertLast(0);

        //    var ispalind = IsPalindrome(sll.head);

        //    Console.WriteLine();
        //}

        static bool IsPalindrome(SLLNode head)
        {
            var fast = head;
            var slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if(fast != null)
            {
                slow = slow.next;
            }

            slow = ReverseLinkedList.Reverse(slow);
            fast = head;

            while(slow != null)
            {
                if(fast.data != slow.data)
                {
                    return false;
                }

                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }
    }
}
