using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzzTree
{
    public class Program
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

            List<object> values = new List<object>();

            FizzBuzzTree(bst.Root, values);

            Print(values);
        }

        public static void FizzBuzzTree(Node node, List<object> values)
        {
            if(node == null)
            {
                Console.WriteLine("Ain't nothing here");
            }
            if(node.Left != null)
            {
                FizzBuzzTree(node.Left, values);
            }

            if(node.Value % 15 == 0)
            {
                Console.Write(" FizzBuzz ");
                values.Add("FizzBuzz");
            }
            else if(node.Value % 3 == 0)
            {
                Console.Write(" Fizz ");
                values.Add("Fizz");
            }
            else if(node.Value % 5 == 0)
            {
                Console.Write(" Buzz ");
                values.Add("Buzz");
            }
            else
            {
                Console.Write($"{node.Value}");
                values.Add($"{node.Value}");
            }

            if (node.Right != null)
            {
                FizzBuzzTree(node.Right, values);
            }
        }

        static void Print(List<object> values)
        {
            Console.WriteLine();
            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
