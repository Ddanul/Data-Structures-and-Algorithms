using Hashtables.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to check that node can be added to hash table
        /// </summary>
        [Fact]
        public void CanAddNodeIntoHashTable()
        {
            //Arrange
            Node n1 = new Node("South Lake Union", "98109");
            Node n2 = new Node("Madrona", "98110");
            Node n3 = new Node("Magnolia", "98199");
            Node n4 = new Node("Greenlake", "98103");
            Node n5 = new Node("Redmond", "98052");
            Node n6 = new Node("edRmond", "98058");

            Hashtable hashtable = new Hashtable();

            hashtable.Add(n1);
            hashtable.Add(n2);
            hashtable.Add(n3);
            hashtable.Add(n4);
            hashtable.Add(n5);
            hashtable.Add(n6);

            //Assert
            Assert.Equal("98199", hashtable.Find("Magnolia"));
        }

        /// <summary>
        /// Test to check that hash table contains a node
        /// </summary>
        [Fact]
        public void CanUseContainToFindNodeInHashTable()
        {
            //Arrange
            Node n1 = new Node("South Lake Union", "98109");
            Node n2 = new Node("Madrona", "98110");
            Node n3 = new Node("Magnolia", "98199");
            Node n4 = new Node("Greenlake", "98103");
            Node n5 = new Node("Redmond", "98052");
            Node n6 = new Node("edRmond", "98058");

            Hashtable hashtable = new Hashtable();

            hashtable.Add(n1);
            hashtable.Add(n2);
            hashtable.Add(n3);
            hashtable.Add(n4);
            hashtable.Add(n5);
            hashtable.Add(n6);

            //Assert
            Assert.True(hashtable.Contains("edRmond"));
        }

        /// <summary>
        /// Test to check that hash table can handle collisions
        /// </summary>
        [Theory]
        [InlineData("toto", "00000", "toot", "11111")]
        [InlineData("binary", "00000", "brainy", "11111")]
        public void CanAddWithCollisionItonHashTable(string key1, string val1, string key2, string val2)
        {
            //Arrange
            Node n1 = new Node("South Lake Union", "98109");
            Node n2 = new Node("Madrona", "98110");
            Node n3 = new Node(key1, val1);
            Node n4 = new Node("Greenlake", "98103");
            Node n5 = new Node("Redmond", "98052");
            Node n6 = new Node(key2, val2);

            Hashtable hashtable = new Hashtable();

            hashtable.Add(n1);
            hashtable.Add(n2);
            hashtable.Add(n3);
            hashtable.Add(n4);
            hashtable.Add(n5);
            hashtable.Add(n6);

            //Assert
            Assert.Equal(val2, hashtable.Find(key2));
        }
    }
}
