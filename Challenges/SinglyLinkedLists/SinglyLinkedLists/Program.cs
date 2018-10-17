using System;
using LinkedLists.Classes;

namespace SinglyLinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            llist.Print();

            Console.WriteLine(LLKthFromEnd(0, llist));
        }

        /// <summary>
        /// Returns the value from the end depending on the k value entered
        /// </summary>
        /// <param name="value">k value to count from the end</param>
        /// <param name="llist">list for which to count from</param>
        /// <returns>value from desired node</returns>
        public static object LLKthFromEnd(int value, LList llist)
        {
            if (value < 0)
            {
                return "Invalid k value";
            }

            int counter = 0;

            llist.Current = llist.Head;
            while (llist.Current.Next != null)
            {
                counter++;
                llist.Current = llist.Current.Next;
            }

            if(value > counter)
            {
                return "There aren't that many nodes in the list.";
            }

            llist.Current = llist.Head;

            while (counter > value)
            {
                llist.Current = llist.Current.Next;
                counter--;
            }
            return llist.Current.Value;
        }
    }
}
