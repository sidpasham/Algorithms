namespace Algorithms
{
    public class DLLNode
    {
        public DLLNode prev;
        public DLLNode next;
        public int key;
        public int val;
        

        public DLLNode(int k, int v)
        {
            prev = null;
            next = null;
            key = k;
            val = v;
        }
    }
}
