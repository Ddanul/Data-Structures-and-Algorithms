using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FindMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(1);
            Node n2 = new Node(570);
            Node n3 = new Node(5);
            BinaryTree tree = new BinaryTree(n1);
            tree.Root.Left = n2;
            tree.Root.Right = n3;

            Console.WriteLine(FindMaximumValue(tree));
        }

        public static int FindMaximumValue(BinaryTree tree)
        {
            List<int> listOfNodes = tree.PreOrder(tree.Root);
            int temp = tree.Root.Value;
            foreach(var value in listOfNodes)
            {
                if (temp < value)
                {
                    temp = value;
                }
            }
            return temp;
        }

    }
}
