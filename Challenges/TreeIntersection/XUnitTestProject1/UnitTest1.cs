using System;
using System.Collections.Generic;
using TreeIntersection;
using TreeIntersection.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void CanDetect5And3AsIntersections()
        {
            //Arrange
            Node n1 = new Node(5);
            Node n2 = new Node(7);
            Node n3 = new Node(3);
            Node n4 = new Node(8);

            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(0);
            Node n8 = new Node(3);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Root.Left = n6;
            tree2.Root.Right = n7;
            tree2.Root.Right.Left = n8;

            List<int> expected = new List<int> { 5, 3 };

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanDetectAllAsIntersections()
        {
            //Arrange
            Node n1 = new Node(5);
            Node n2 = new Node(7);
            Node n3 = new Node(3);
            Node n4 = new Node(8);

            Node n5 = new Node(5);
            Node n6 = new Node(7);
            Node n7 = new Node(3);
            Node n8 = new Node(8);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Root.Left = n6;
            tree2.Root.Right = n7;
            tree2.Root.Right.Left = n8;

            List<int> expected = new List<int> { 5, 7, 3, 8 };

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanDetectNoIntersections()
        {
            //Arrange
            Node n1 = new Node(5);
            Node n2 = new Node(7);
            Node n3 = new Node(3);
            Node n4 = new Node(8);

            Node n5 = new Node(6);
            Node n6 = new Node(4);
            Node n7 = new Node(2);
            Node n8 = new Node(1);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;
            tree1.Root.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Root.Left = n6;
            tree2.Root.Right = n7;
            tree2.Root.Right.Left = n8;

            List<int> expected = new List<int>();

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }
    }
}
