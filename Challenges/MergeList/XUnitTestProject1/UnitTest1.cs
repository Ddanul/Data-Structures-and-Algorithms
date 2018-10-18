using System;
using Xunit;
using MergeList;
using LinkedLists.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to merge equal length lists
        /// </summary>
        [Fact]
        public void MatchMergedListOfEqualLengths()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LList list1 = new LList(node1);
            list1.Append(node3);

            LList list2 = new LList(node2);
            list2.Append(node4);

            Node node1t = new Node(1);
            Node node2t = new Node(2);
            Node node3t = new Node(3);
            Node node4t = new Node(4);

            LList testList = new LList(node1t);
            testList.Append(node2t);
            testList.Append(node3t);
            testList.Append(node4t);

            LList mergeList = Program.Merge(list1, list2);

            //Assert
            Assert.Equal("1 --> 2 --> 3 --> 4 --> NULL", Program.Print(mergeList));
        }
    }
}
