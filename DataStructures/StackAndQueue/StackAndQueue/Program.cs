using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            Console.WriteLine($"Top: {myStack.Peek().Value}, Pop: {myStack.Pop().Value}, NewTop: {myStack.Peek().Value}");

            Queue myQ = new Queue(node4);
            myQ.Enqueue(node5);
            Console.WriteLine($"Front: {myQ.Peek().Value}, Rear: {myQ.Rear.Value}");
        }
    }
}
