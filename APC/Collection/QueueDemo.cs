using System;
using System.Collections;

namespace Collection
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            while(q.Count > 0){
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
