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

        //O(n) time complexity
        //O(1) space
        static SLLNode RemoveNthNodeFromEndLinkedList(SLLNode head,int length, int n)
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
