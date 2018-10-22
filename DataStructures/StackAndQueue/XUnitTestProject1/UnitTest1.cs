using System;
using Xunit;
using StackAndQueue.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to check node is pushed onto stack
        /// </summary>
        [Fact]
        public void CanPushNodeToStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            //Assert
            Assert.Equal(2, myStack.Peek().Value);
        }

        /// <summary>
        /// Test to pop node off stack
        /// </summary>
        [Fact]
        public void CanPopNodeOffStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            myStack.Push(node3);

            //Assert
            Assert.Equal(3, myStack.Pop().Value);
        }


        /// <summary>
        /// Can peek at the top node from the stack
        /// </summary>
        [Fact]
        public void CanPeekNodeFromStack()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            myStack.Push(node3);

            //Assert
            Assert.Equal(3, myStack.Peek().Value);
        }


        /// <summary>
        /// Test to cehck node can be enqueued to queue
        /// </summary>
        [Fact]
        public void CanEnqueueNodeOntoQueue()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue myQ = new Queue(node1);
            myQ.Enqueue(node2);

            //Assert
            Assert.Equal(1, myQ.Peek().Value);
        }

        /// <summary>
        /// Can Dequeue from queue
        /// </summary>
        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue myQ = new Queue(node1);
            myQ.Enqueue(node2);
            myQ.Enqueue(node3);

            //Assert
            Assert.Equal(1, myQ.Dequeue().Value);
        }

        /// <summary>
        /// Test to peek at front node
        /// </summary>
        [Fact]
        public void CanPeekAtNodeFromQueue()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue myQ = new Queue(node1);
            myQ.Enqueue(node2);
            myQ.Enqueue(node3);

            //Assert
            Assert.Equal(1, myQ.Peek().Value);
        }
    }
}
