namespace Algorithms
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

        //O(Log(n)) time complexity
        //O(1) space
        static bool IsPalindrome(SLLNode head)
        {
            var middle = GetMiddleNode.GetMiddleNodeLinkedList(head);

            var half1 = head;
            var half2 = ReverseLinkedList.Reverse(middle);

            while(half1 != null && half2 != null)
            {
                if(half1.data != half2.data)
                {
                    return false;
                }

                half1 = half1.next;
                half2 = half2.next;
            }

            return true;
        }
    }
}
