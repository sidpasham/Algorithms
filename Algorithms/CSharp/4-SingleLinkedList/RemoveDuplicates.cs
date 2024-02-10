using System.Collections.Generic;

namespace Algorithms
{
    class RemoveDuplicates
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

        //    RemoveDuplicatesSorted(sll.head);

        //    Console.WriteLine();
        //}

        //O(n) time complexity
        //O(1) space
        public static void RemoveDuplicatesSorted(SLLNode head)
        {
            if (head == null) return;

            var temp = head;

            while (temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }


        //O(n) time complexity
        //O(n) space
        static void RemoveDuplicated(SLLNode head)
        {
            if (head == null) return;

            HashSet<int> hs = new HashSet<int>();

            var temp = head;
            SLLNode prev = null;

            while (temp != null)
            {
                if (hs.Contains(temp.data))
                {
                    if (prev != null) prev.next = temp.next;
                }
                else
                {
                    hs.Add(temp.data);
                    prev = temp;
                }

                temp = temp.next;
            }
        }
    }
}
