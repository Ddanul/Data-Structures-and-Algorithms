using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }

        static void QueueWithStacks()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);

            Queue myQ = new Queue(n1);
            myQ.Enqueue(n2);
            myQ.Enqueue(n3);
            Console.WriteLine($"The last node added was: {myQ.s1.Top.Value}");

            Console.WriteLine($"Dequeued node: {myQ.Dequeue().Value}");

        }
    }
}
