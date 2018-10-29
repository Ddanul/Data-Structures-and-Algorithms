using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(3);
            Node n2 = new Node(5);
            Node n3 = new Node(15);
            Node n4 = new Node(2);

            BinaryTree bst = new BinaryTree(n1);
            bst.Root.Left = n2;
            bst.Root.Right = n3;
            bst.Root.Left.Left = n4;

            FizzBuzzTree(bst.Root);
        }

        static void FizzBuzzTree(Node node)
        {
            if(node == null)
            {
                Console.WriteLine("Ain't nothin here");
            }
            if(node.Left != null)
            {
                FizzBuzzTree(node.Left);
            }

            if(node.Value % 15 == 0)
            {
                Console.Write(" FizzBuzz ");
            }
            else if(node.Value % 3 == 0)
            {
                Console.Write(" Fizz ");
            }
            else if(node.Value % 5 == 0)
            {
                Console.Write(" Buzz ");
            }
            else
            {
                Console.Write($"{node.Value}");
            }

            if (node.Right != null)
            {
                FizzBuzzTree(node.Right);
            }
        }
    }
}
