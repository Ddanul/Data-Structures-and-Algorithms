using System;
using Xunit;
using LinkedLists.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        public void AddMethodUpdatesHeadValue(int value1, int expected)
        {
            //Arrange

            Node node1 = new Node(1);
            Node node2 = new Node(value1);

            LList list1 = new LList(node1);
            list1.Add(node2);

            //Assert
            Assert.Equal(expected, list1.Head.Value);
        }


        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        public void AppendMethodReturnsExpectedValue(int value1, int expected)
        {
            //Arrange

            Node node1 = new Node(1);
            Node node2 = new Node(value1);

            LList list1 = new LList(node1);
            list1.Append(node2);

            //Assert
            Assert.Equal(expected, list1.Head.Next.Value);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        public void AddBeforeMethodReturnsExpectedValue(int value1, int expected)
        {
            //Arrange

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(value1);

            LList list1 = new LList(node1);
            list1.Append(node2);
            list1.AddBefore(node3, node2);

            //Assert
            Assert.Equal(expected, list1.Head.Next.Value);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        public void AddAfterMethodReturnsExpectedValue(int value1, int expected)
        {
            //Arrange

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(value1);

            LList list1 = new LList(node1);
            list1.Append(node2);
            list1.AddAfter(node3, node2);

            //Assert
            Assert.Equal(expected, list1.Head.Next.Next.Value);
        }
    }
}
