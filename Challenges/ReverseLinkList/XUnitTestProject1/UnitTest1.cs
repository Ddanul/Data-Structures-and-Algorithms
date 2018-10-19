using System;
using Xunit;
using ReverseLinkList;
using LinkedLists.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to make sure method returns reversed list
        /// </summary>
        [Fact]
        public void ReturnsReversedList()
        {
            //Arrange

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LList list1 = new LList(node1);
            list1.Append(node2);
            list1.Append(node3);
            list1.Append(node4);

            //Assert
            Assert.Equal("4 --> 3 --> 2 --> 1 --> NULL", Program.Print(Program.Reverse(list1)));
            
        }

        /// <summary>
        /// Test to make sure method works with texts
        /// </summary>
        [Fact]
        public void ReturnsReversedStringVals()
        {
            //Arrange

            Node node1 = new Node("p");
            Node node2 = new Node("a");
            Node node3 = new Node("r");
            Node node4 = new Node("k");

            LList list1 = new LList(node1);
            list1.Append(node2);
            list1.Append(node3);
            list1.Append(node4);

            //Assert
            Assert.Equal("k --> r --> a --> p --> NULL", Program.Print(Program.Reverse(list1)));

        }
    }
}
