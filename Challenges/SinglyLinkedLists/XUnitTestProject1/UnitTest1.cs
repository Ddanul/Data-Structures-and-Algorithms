using System;
using Xunit;
using LinkedLists.Classes;
using SinglyLinkedLists;

namespace XUnitTestProject1
{
    /// <summary>
    /// Testing to ensure proper value is returned from method.
    /// </summary>
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, "Manolo")]
        [InlineData(3, 172)]
        [InlineData(0, "Donut")]
        [InlineData(-1, "Invalid k value")]
        public void LLKthFromTheEndReturnsProperValue(int value, object expectation)
        {
            //Arrange
            Node node1 = new Node("Manolo");
            Node node2 = new Node(172);
            Node node3 = new Node("Brooke");
            Node node4 = new Node(98);
            Node node5 = new Node("Donut");

            LList llist = new LList(node1);
            llist.Append(node2);
            llist.Append(node3);
            llist.Append(node4);
            llist.Append(node5);

            //Assert
            Assert.Equal(expectation, Program.LLKthFromEnd(value, llist));
        }
    }
}
