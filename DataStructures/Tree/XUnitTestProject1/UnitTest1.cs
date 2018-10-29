using System;
using Xunit;
using Tree;
using Tree.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Pre Ordered Tree test 
        /// </summary>
        /// <param name="value">value for node</param>
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TreeIsPreOrdered(int value)
        {
            //Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(value);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;

            List<int> preorderedList = tree1.PreOrder(tree1.Root);
            List<int> expected = new List<int> { 1, 2, value };

            //Assert
            Assert.Equal(expected, preorderedList);
        }

        /// <summary>
        /// Tree is in order
        /// </summary>
        /// <param name="value">node values</param>
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TreeIsInOrder(int value)
        {
            //Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(value);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;

            List<int> inorderList = tree1.InOrder(tree1.Root);
            List<int> expected = new List<int> { 2, 1, value };

            //Assert
            Assert.Equal(expected, inorderList);
        }

        /// <summary>
        /// Post ordered Tree
        /// </summary>
        /// <param name="value">node values</param>
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TreeIsPostOrdered(int value)
        {
            //Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(value);

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Root.Left = n2;
            tree1.Root.Right = n3;

            List<int> postorderedList = tree1.PostOrder(tree1.Root);
            List<int> expected = new List<int> { 2, value, 1 };

            //Assert
            Assert.Equal(expected, postorderedList);
        }

        /// <summary>
        /// Binary Search Tree addition method
        /// </summary>
        [Fact]
        public void BSTAddWorks()
        {
            //Arrange
            Node n1 = new Node(50);
            Node n2 = new Node(25);
            Node n3 = new Node(100);
            Node n4 = new Node(150);

            BinarySearchTree bst1 = new BinarySearchTree(n1);
            bst1.Add(n2);
            bst1.Add(n3);
            bst1.Add(n4);

            //Assert
            Assert.Equal(n2, bst1.Root.Left);
        }

        [Fact]
        public void BSTAddWorksForGreaterThan()
        {
            //Arrange
            Node n1 = new Node(50);
            Node n2 = new Node(25);
            Node n3 = new Node(100);
            Node n4 = new Node(150);

            BinarySearchTree bst1 = new BinarySearchTree(n1);
            bst1.Add(n2);
            bst1.Add(n3);
            bst1.Add(n4);

            //Assert
            Assert.Equal(n3, bst1.Root.Right);
        }

        [Fact]
        public void BSTAddWorksForGreaterThanTwice()
        {
            //Arrange
            Node n1 = new Node(50);
            Node n2 = new Node(25);
            Node n3 = new Node(100);
            Node n4 = new Node(150);

            BinarySearchTree bst1 = new BinarySearchTree(n1);
            bst1.Add(n2);
            bst1.Add(n3);
            bst1.Add(n4);

            //Assert
            Assert.Equal(n4, bst1.Root.Right.Right);
        }

        /// <summary>
        /// Tests Search function on BST
        /// </summary>
        /// <param name="value">node values</param>
        [Theory]
        [InlineData(150)]
        [InlineData(10)]
        [InlineData(75)]
        public void BSTSearchMethodWorks(int value)
        {
            //Arrange
            Node n1 = new Node(50);
            Node n2 = new Node(25);
            Node n3 = new Node(100);
            Node n4 = new Node(value);

            BinarySearchTree bst1 = new BinarySearchTree(n1);
            bst1.Add(n2);
            bst1.Add(n3);
            bst1.Add(n4);

            Node pointer = bst1.Search(value);
            //Assert
            Assert.Equal(value, pointer.Value);
        }
    }
}
