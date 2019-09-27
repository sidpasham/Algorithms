using System.Collections.Generic;

namespace Algorithms.LinkedList
{
    public class SingleLinkedList
    {
        public SLLNode head;

        public void InsertFront(int data)
        {
            SLLNode node = new SLLNode(data);
            node.next = head;
            head = node;
        }

        public void InsertLast(int data)
        {
            var newNode = new SLLNode(data);

            if(head == null)
            {
                head = newNode;
                return;
            }

            var lastNode = GetLastNode();
            lastNode.next = newNode;

        }

        public SLLNode GetLastNode()
        {
            var temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void DeleteNodeByValue(int data)
        {
            if(head != null)
            {
                if(head.data == data)
                {
                    head = head.next;
                }
                else
                {
                    var curr = head;
                    while(curr.next != null)
                    {
                        if(curr.next.data == data)
                        {
                            curr.next = curr.next.next;
                            break;
                        }
                        curr = curr.next;
                    }
                }
            }
        }

        public void DeleteNodeByPosition(int position)
        {
            if(head != null)
            {
                if (position == 0)
                {
                    head = null;
                }

                var temp = head;

                for(int i = 0; i < position - 1 && temp!=null; i++)
                {
                    temp = temp.next;
                }

                temp.next = temp.next.next;
            }
        }

        public int Length()
        {
            var temp = head;
            int count = 0;
            while(temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }

        public int LengthRecursive(SLLNode node)
        {
            if(node == null)
            {
                return 0;
            }

            return 1 + LengthRecursive(node.next);
        }

        public bool IsNodeExitsByValue(int data)
        {
            if (head == null) return false;
            var temp = head;
            while(temp != null)
            {
                if (temp.data == data) return true;

                temp = temp.next;
            }
            return false;
        }

        public SLLNode GetNodeByPosition(int position)
        {
            if(head != null)
            {
                if(position == 0)
                {
                    return head;
                }

                var temp = head;
                for(int i = 0; i < position - 1 && temp != null; i++)
                {
                    temp = temp.next;
                }

                return temp;
            }
            return null;
        }

        public SLLNode GetNodeByValue(int data)
        {
            if (head != null)
            {
                var temp = head;
                while(temp != null)
                {
                    if (temp.data == data) break;
                    temp = temp.next;
                }
                return temp;
            }
            return null;
        }

        public void RemoveDuplicatesSorted()
        {
            if (head == null) return;

            var temp = head;
            
            while(temp.next!= null)
            {
                if(temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        public void RemoveDuplicates()
        {
            if (head == null) return;
            var curr = head;
            SLLNode prev = null;
            HashSet<int> hs = new HashSet<int>();
            while(curr.next != null)
            {
                int val = curr.data;
                if (hs.Contains(val))
                {
                    prev.next = curr.next;
                }
                else
                {
                    hs.Add(val);
                    prev = curr;
                }
                curr = curr.next;
            }
        }

        

        public SLLNode GetMiddleNode()
        {
            if (head == null) return head;

            SLLNode fast = head.next;
            SLLNode slow = head;

            while(fast != null)
            {
                fast = fast.next;
                if(fast != null)
                {
                    fast = fast.next;
                    slow = slow.next;
                }
            }

            return slow;
        }

        public SLLNode MergeSort(SLLNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            SLLNode middle = GetMiddleNode();
            SLLNode middlenext = middle.next;

            middle.next = null;

            SLLNode left = MergeSort(head);

            SLLNode right = MergeSort(middlenext);

            SLLNode sortedlist = SortedMergeLinkedList.SortedMergeLinkedListRecursion(left, right);

            return sortedlist;
        }
    }
}
