namespace Algorithms
{
    public class SingleLinkedList
    {
        public SLLNode head;

        //O(1) time complexity
        //O(1) space
        public void InsertFront(int data)
        {
            SLLNode node = new SLLNode(data);
            node.next = head;
            head = node;
        }

        //O(n) time complexity
        //O(1) space
        public void InsertLast(int data)
        {
            SLLNode newNode = new SLLNode(data);

            if(head == null)
            {
                head = newNode;
                return;
            }

            var lastNode = GetLastNode();
            lastNode.next = newNode;

        }

        //O(n) time complexity
        //O(1) space
        public SLLNode GetLastNode()
        {
            var temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        //O(n) time complexity
        //O(1) space
        public void DeleteNodeByValue(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.data == value)
            {
                head = head.next;
            }
            else
            {
                var curr = head;
                while(curr.next != null)
                {
                    if(curr.next.data == value)
                    {
                        curr.next = curr.next.next;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }

        //O(n) time complexity where n is the position
        //O(1) space
        public void DeleteNodeByPosition(int position)
        {
            if (head == null)
            {
                return;
            }

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

        //O(n) time complexity
        //O(1) space
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

        //O(n) time complexity
        //O(n) space
        public int LengthRecursive(SLLNode node)
        {
            if(node == null)
            {
                return 0;
            }

            return 1 + LengthRecursive(node.next);
        }

        //O(n) time complexity
        //O(1) space
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

        //O(n) time complexity where n is the position
        //O(1) space
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

        //O(n) time complexity
        //O(1) space
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
    }
}
