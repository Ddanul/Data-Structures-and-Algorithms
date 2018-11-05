using System;
using Tree.Classes;
using Xunit;
using FindMaxValue;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(300, 570)]
        [InlineData(1000, 1000)]
        [InlineData(30, 570)]
        public void FindsMaxValue(int value, int expected)
        {
            //Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(570);
            Node n3 = new Node(value);
            BinaryTree tree = new BinaryTree(n1);
            tree.Root.Left = n2;
            tree.Root.Right = n3;

            //Assert
            Assert.Equal(expected, Program.FindMaximumValue(tree));
        }
    }
}
