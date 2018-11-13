using System;
using System.Collections.Generic;
using TreeIntersection.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node n1 = new Node(5);
            Node n2 = new Node(7);
            Node n3 = new Node(3);
            Node n4 = new Node(8);

            Node n5 = new Node(2);
            Node n6 = new Node(6);
            Node n7 = new Node(0);
            Node n8 = new Node(1);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Root.Left = n6;
            tree2.Root.Right = n7;
            tree2.Root.Right.Left = n8;

            List<int> intersections = TreeIntersection(tree1, tree2);

            Console.WriteLine("The following are intersections: ");
            foreach(int value in intersections)
            {
                Console.Write(value + " ");
            }
        }

        /// <summary>
        /// This method checks if two trees have any matching node values
        /// </summary>
        /// <param name="tree1">binary tree 1</param>
        /// <param name="tree2">binary tree to compare to tree 1</param>
        /// <returns>a list of matching node values as integers</returns>
        static List<int> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            List<int> resultList = new List<int>();
            Hashtable hash = new Hashtable();

            List<int> tree1Values = tree1.PreOrder(tree1.Root);
            List<int> tree2Values = tree2.PreOrder(tree2.Root);

            foreach (int value in tree1Values)
            {
                Node node = new Node(value);
                hash.Add(node);
            }
            foreach (int value in tree2Values)
            {
                if (hash.Contains(value.ToString()))
                {
                    resultList.Add(value);
                }
            }
            return resultList;
        }
    }
}
