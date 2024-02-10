using System.Collections;

namespace Algorithms
{
    class QueueUsingStack
    {
        System.Collections.Stack s1 = new System.Collections.Stack();
        System.Collections.Stack s2 = new System.Collections.Stack();
        
        public void Enqueue(int x)
        {
            while(s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            s1.Push(x);

            while(s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public int Dequeue()
        {
            var x = (int)s1.Peek();
            s1.Pop();
            return x;
        }
    }
}
