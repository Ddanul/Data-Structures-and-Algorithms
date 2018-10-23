using System;
using Xunit;
using QueueWithStacks.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to make sure nodes are enqueued
        /// </summary>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void NodesAreEnqueued(int value, int expected)
        {
            //Arrange
            Node n1 = new Node(5);
            Node n2 = new Node(6);
            Node n3 = new Node(value);

            Queue myQ = new Queue(n1);
            myQ.Enqueue(n2);
            myQ.Enqueue(n3);

            //Arrange
            Assert.Equal(expected, myQ.s1.Top.Value);
        }

        /// <summary>
        /// Test to check front node is being dequeued
        /// </summary>
        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 5)]
        [InlineData(3, 5)]
        public void NodesAreDequeued(int value, int expected)
        {
            //Arrange
            Node n1 = new Node(5);
            Node n2 = new Node(6);
            Node n3 = new Node(value);

            Queue myQ = new Queue(n1);
            myQ.Enqueue(n2);
            myQ.Enqueue(n3);

            //Arrange
            Assert.Equal(expected, myQ.Dequeue().Value);
        }
    }
}
