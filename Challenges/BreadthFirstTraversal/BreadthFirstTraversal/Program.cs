using BreadthFirstTraversal.Classes;
using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            BinaryTree bst = new BinaryTree(n1);
            bst.Root.Left = n2;
            bst.Root.Right = n3;
            bst.Root.Left.Left = n4;
            bst.Root.Left.Right = n5;
            bst.Root.Right.Left = n6;
            bst.Root.Right.Right = n7;

            BreadthFirst(bst.Root);
            Console.ReadLine();
        }

        public static void BreadthFirst(Node root)
        {
            Queue q = new Queue(root);
            while(q.Peek() != null)
            {
                var Front = q.Dequeue();
                Console.WriteLine(Front.Value);

                if(Front.Left != null)
                {
                    q.Enqueue(Front.Left);
                }
                if(Front.Right != null)
                {
                    q.Enqueue(Front.Right);
                }
            }
        }
    }
}
