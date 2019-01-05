using System;
using System.Collections.Generic;

namespace queue_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolejka");
            //odczytywanie elementów z kolejki jest mozliwe od pierwszego wrzuconego elementu (dostępny jest wierzchni element)

            Queue<int> queueCollection = new Queue<int>();
            queueCollection.Enqueue(1);
            queueCollection.Enqueue(2);
            queueCollection.Enqueue(3);

            Console.WriteLine(queueCollection.Peek());

            Console.WriteLine(queueCollection.Dequeue());
            Console.WriteLine(queueCollection.Dequeue());
            Console.WriteLine(queueCollection.Dequeue());

            Console.WriteLine("stos");
            //działa odwrotnie, do kolejki, to co bylo wrzucone to od ostatniego elementu mozna zaczac odczytywac (dostępny jest spodni element)

            Stack<int> stackCollection = new Stack<int>();
            stackCollection.Push(1);
            stackCollection.Push(2);
            stackCollection.Push(3);

            Console.WriteLine(stackCollection.Peek());

            Console.WriteLine(stackCollection.Pop());
            Console.WriteLine(stackCollection.Pop());
            Console.WriteLine(stackCollection.Pop());

            Console.ReadKey();
        }
    }
}
