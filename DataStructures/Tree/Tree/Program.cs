using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Left = n4;
            tree1.Root.Left.Right = n5;

            Print(tree1.PreOrder(tree1.Root));

            tree1.searchValues.Clear();

            Print(tree1.InOrder(tree1.Root));

            tree1.searchValues.Clear();

            Print(tree1.PostOrder(tree1.Root));


            Node n6 = new Node(1);
            Node n7 = new Node(2);
            Node n8 = new Node(3);
            Node n9 = new Node(4);
            Node n10 = new Node(5);

            BinarySearchTree bst1 = new BinarySearchTree(n6);
        }

        /// <summary>
        /// Prints out values in list
        /// </summary>
        /// <param name="values">list of integers</param>
        public static void Print(List<int> values)
        {
            Console.WriteLine("=============");
            foreach(int value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
