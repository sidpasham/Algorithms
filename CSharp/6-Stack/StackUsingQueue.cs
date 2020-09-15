using System.Collections;

namespace Algorithms
{
    class StackUsingQueue
    {
        Queue q1 = new Queue();
        Queue q2 = new Queue();

        int cur_size;
        public StackUsingQueue()
        {
            cur_size = 0;
        }

        public void Push(int x)
        {
            cur_size++;

            q2.Enqueue(x);

            while(q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }

            var temp = q1;
            q1 = q2;
            q2 = temp;
        }

        public void Dequeue()
        {
            if (q1.Count == 0) return;
            var x = (int)q1.Peek();
            q1.Dequeue();
            cur_size--;
        }
    }
}
