using System;
using LinkedLists.Classes;

namespace ReverseLinkList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            LList list1 = new LList(node1);
            list1.Append(node2);
            list1.Append(node3);
            list1.Append(node4);
            list1.Append(node5);
            list1.Append(node6);
            list1.Append(node7);

            Console.WriteLine(Print(list1));
            Console.WriteLine(Print(Reverse(list1)));
            
        }

        /// <summary>
        /// returns a string conatining the values of the nodes in the linked list
        /// </summary>
        /// <param name="list">linked list</param>
        /// <returns>string of values in linked list</returns>
        public static string Print(LList list)
        {
            string returnPrint = "";
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                returnPrint += list.Current.Value + " --> ";
                list.Current = list.Current.Next;
            }
            returnPrint += list.Current.Value + " --> NULL";
            Console.WriteLine();
            return returnPrint;
        }

        /// <summary>
        /// Reverses the linked list that is entered.
        /// </summary>
        /// <param name="list">linked list</param>
        /// <returns>reversed linked list</returns>
        public static LList Reverse(LList list)
        {
            list.Current = list.Head.Next;
            Node pointer = list.Head;
            Node tail = list.Head.Next;

            while (tail.Next != null)
            {
                tail = tail.Next;
                pointer = pointer.Next;
            }
            tail.Next = pointer;

            while (pointer != list.Head)
            {
                if (list.Current.Next == pointer)
                {
                    list.Current.Next = null;
                    pointer.Next = list.Current;
                    pointer = pointer.Next;
                    list.Current = list.Head;
                }
                else
                {
                    list.Current = list.Current.Next;
                }
            }
            list.Head = tail;

            return list;
        }

        public static bool IsPalindrome(LList list)
        {

        }
    }
}
