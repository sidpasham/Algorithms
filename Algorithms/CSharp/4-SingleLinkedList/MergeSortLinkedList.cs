namespace Algorithms
{
    class MergeSortLinkedList
    {
        //static void Main()
        //{
        //    SingleLinkedList ll1 = new SingleLinkedList();
        //    ll1.InsertLast(2);
        //    ll1.InsertLast(4);
        //    ll1.InsertLast(5);
        //    ll1.InsertLast(1);
        //    ll1.InsertLast(3);

        //    SingleLinkedList ll2 = new SingleLinkedList();
        //    ll2.InsertLast(6);
        //    ll2.InsertLast(9);
        //    ll2.InsertLast(8);
        //    ll2.InsertLast(7);
        //    ll2.InsertLast(10);

        //    var result = SortedMergeLinkedListRecursion(ll1.head, ll2.head);

        //    Console.WriteLine("Completed");
        //}

        //O(nLog(n)) time complexity
        //O(n) space
        public SLLNode MergeSort(SLLNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            SLLNode middle = GetMiddleNode.GetMiddleNodeLinkedList(head);
            SLLNode middlenext = middle.next;

            middle.next = null;

            SLLNode left = MergeSort(head);

            SLLNode right = MergeSort(middlenext);

            SLLNode sortedlist = SortedMergeLinkedListRecursion(left, right);

            return sortedlist;
        }

        //O(n) time complexity
        //O(n) space
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

        public static SLLNode SortedMergeLinkedListIterative(SLLNode n1, SLLNode n2)
        {
            SLLNode emptyNode = new SLLNode(0);

            SLLNode tail = emptyNode;

            while(true)
            {
                if(n1 == null)
                {
                    tail.next = n2;
                    break;
                }
                if(n2 == null)
                {
                    tail.next = n1;
                    break;
                }

                if(n1.data <= n2.data)
                {
                    tail.next = n1;
                    n1 = n1.next;
                }
                else
                {
                    tail.next = n2;
                    n2 = n2.next;
                }

                tail = tail.next;

            }

            return emptyNode.next;
        }
    }
}
