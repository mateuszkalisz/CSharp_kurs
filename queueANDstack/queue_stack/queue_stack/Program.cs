using System;
using System.Collections.Generic;

namespace queue_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueCollection = new Queue<int>();
            queueCollection.Enqueue(1);
            queueCollection.Enqueue(2);
            queueCollection.Enqueue(3);

            Console.WriteLine(queueCollection.Peek());
            Console.WriteLine(queueCollection.Dequeue());
            Console.WriteLine(queueCollection.Dequeue());


            Console.ReadKey();        }
    }
}
