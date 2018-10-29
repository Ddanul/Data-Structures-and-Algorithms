using System;
using System.Collections.Generic;
using Tree.Classes;
using Xunit;
using FizzBuzzTree;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(30, "FizzBuzz")]
        public void TreeTurnsFizzToBuzz(int value, string expected)
        {
            //Arrange
            Node n1 = new Node(3);
            Node n2 = new Node(5);
            Node n3 = new Node(value);
            Node n4 = new Node(2);

            BinaryTree bst = new BinaryTree(n1);
            bst.Root.Left = n2;
            bst.Root.Right = n3;
            bst.Root.Left.Left = n4;

            List<object> values = new List<object>();

            Program.FizzBuzzTree(bst.Root, values);

            //Assert
            Assert.Equal(expected, values[3]);
        }
    }
}
