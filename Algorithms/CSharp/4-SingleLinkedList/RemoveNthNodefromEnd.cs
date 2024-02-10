namespace Algorithms
{
    class RemoveNthNodefromEnd
    {
        //static void Main()
        //{
        //    SingleLinkedList sll = new SingleLinkedList();
        //    sll.InsertLast(1);
        //    sll.InsertLast(2);

        //    var length = sll.Length();

        //    var output = RemoveNthNodeFromEndLinkedList(sll.head, length, 2);

        //    Console.WriteLine();

        //}

        static SLLNode RemoveNthNodeFromEndLinkedList(SLLNode head, int n)
        {
            if (head == null) return null;
            var fast = head;
            var slow = head;

            while (n > 0 && fast != null)
            {
                fast = fast.next;
                n--;
            }

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow = slow.next;

            return head;
        }

        //O(n) time complexity
        //O(1) space
        static SLLNode RemoveNthNodeFromEndLinkedList(SLLNode head, int length, int n)
        {
            if (head == null) return null;
            length = length - n;

            SLLNode temp = new SLLNode(0);
            temp.next = head;

            var curr = temp;
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
