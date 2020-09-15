using System.Collections.Generic;

namespace Algorithms
{
    class LRUCache
    {
        public int Size;
        public int Capacity;

        public DLLNode DummyHead;
        public DLLNode DummyTail;

        public Dictionary<int, DLLNode> map;

        public LRUCache(int capacity)
        {
            Size = 0;
            Capacity = capacity;

            DummyHead = new DLLNode(0,0);
            DummyTail = new DLLNode(0, 0);

            DummyTail.prev = DummyHead;
            DummyHead.next = DummyTail;

            map = new Dictionary<int, DLLNode>();
        }

        public void AddFront(DLLNode node)
        {
            node.next = DummyTail;
            node.prev = DummyTail.prev;

            DummyTail.prev.next = node;
            DummyTail.prev = node;
        }

        public void RemoveLast(DLLNode node)
        {
            node.next.prev = node.prev;
            node.prev.next = node.next;
        }

        public int GetValue(int key)
        {
            if (!map.ContainsKey(key))
            {
                return -1;
            }

            DLLNode node = map[key];
            RemoveLast(node);
            AddFront(node);

            return node.val;
        }

        public void SetValue(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                DLLNode node = map[key];
                node.val = value;
                RemoveLast(node);
                AddFront(node);
            }
            else
            {
                if (Size == Capacity)
                {
                    map.Remove(DummyHead.next.key);
                    RemoveLast(DummyHead.next);
                    Size--;
                }

                DLLNode node = new DLLNode(key,value);
                map.Add(key,node);
                AddFront(node);
                Size++;
            }
        }
    }
}
