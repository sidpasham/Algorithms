using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class SingleLinkedList
    {
        public SLLNode head;

        public void InsertFront(SingleLinkedList sll, int data)
        {
            SLLNode node = new SLLNode(data);
            node.next = sll.head;
            sll.head = node;
        }

        public void InsertLast(SingleLinkedList sll, int data)
        {
            var newNode = new SLLNode(data);

            if(sll.head == null)
            {
                sll.head = newNode;
                return;
            }

            var lastNode = GetLastNode(sll);
            lastNode.next = newNode;

        }

        public SLLNode GetLastNode(SingleLinkedList sll)
        {
            var temp = sll.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void DeleteNodeByValue(SingleLinkedList sll, int data)
        {
            if(sll.head != null)
            {
                if(sll.head.data == data)
                {
                    sll.head = sll.head.next;
                }
                else
                {
                    var curr = sll.head;
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

        public void DeleteNodeByPosition(SingleLinkedList sll, int position)
        {
            if(sll.head != null)
            {
                if (position == 0)
                {
                    sll.head = null;
                }

                var temp = sll.head;

                for(int i = 0; i < position - 1 && temp!=null; i++)
                {
                    temp = temp.next;
                }

                temp.next = temp.next.next;
            }
        }

        public int Length(SingleLinkedList sll)
        {
            var temp = sll.head;
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

        public bool IsNodeExitsByValue(SingleLinkedList sll, int data)
        {
            if (sll == null) return false;
            var temp = sll.head;
            while(temp != null)
            {
                if (temp.data == data) return true;

                temp = temp.next;
            }
            return false;
        }

        public SLLNode GetNodeByPosition(SingleLinkedList sll, int position)
        {
            if(sll.head != null)
            {
                if(position == 0)
                {
                    return sll.head;
                }

                var temp = sll.head;
                for(int i = 0; i < position - 1 && temp != null; i++)
                {
                    temp = temp.next;
                }

                return temp;
            }
            return null;
        }

        public SLLNode GetNodeByValue(SingleLinkedList sll, int data)
        {
            if (sll.head != null)
            {
                var temp = sll.head;
                while(temp != null)
                {
                    if (temp.data == data) break;
                    temp = temp.next;
                }
                return temp;
            }
            return null;
        }

        public void RemoveDuplicatesSorted(SingleLinkedList sll)
        {
            if (sll.head == null) return;

            var temp = sll.head;
            
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

        public void RemoveDuplicates(SingleLinkedList sll)
        {
            if (sll.head == null) return;
            var curr = sll.head;
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

        public void Reverse(SingleLinkedList sll)
        {
            SLLNode prev = null;
            SLLNode next = null;
            SLLNode curr = sll.head;
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;
        }

        public SLLNode GetMiddleNode(SLLNode head)
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

        public SLLNode SortedMerge(SLLNode node1, SLLNode node2)
        {
            if (node1 == null) return node2;
            if (node2 == null) return node1;
            SLLNode result = null;

            if(node1.data <= node2.data)
            {
                result = node1;
                result.next = SortedMerge(node1.next, node2);
            }
            else
            {
                result = node2;
                result.next = SortedMerge(node1, node2.next);
            }

            return result;
        }

        public SLLNode MergeSort(SLLNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            SLLNode middle = GetMiddleNode(head);
            SLLNode middlenext = middle.next;

            middle.next = null;

            SLLNode left = MergeSort(head);

            SLLNode right = MergeSort(middlenext);

            SLLNode sortedlist = SortedMerge(left, right);

            return sortedlist;
        }
    }
}
