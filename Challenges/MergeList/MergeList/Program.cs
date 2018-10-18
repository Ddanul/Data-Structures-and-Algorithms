using System;
using LinkedLists.Classes;

namespace MergeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);
            //Node node6 = new Node(6);
            //Node node7 = new Node(7);

            //LList list1 = new LList(node1);
            //list1.Append(node3);
            //list1.Append(node5);
            //list1.Append(node7);

            //LList list2 = new LList(node2);
            //list2.Append(node4);
            //list2.Append(node6);
            ////list2.Append(node7);


            //Print(list1);
            //Console.WriteLine();
            //Print(list2);

            //LList newList = Merge(list1, list2);
            //Print(newList);


            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LList list1 = new LList(node1);
            list1.Append(node3);

            LList list2 = new LList(node2);
            list2.Append(node4);

            LList mergeList = Program.Merge(list1, list2);

            Console.WriteLine(Print(mergeList));
        }

        public static LList Merge(LList list1, LList list2)
        {
            list1.Current = list1.Head;
            list2.Current = list2.Head;
            Node pointer1 = list1.Current;
            Node pointer2 = list2.Current;

            while(list1.Current != null || list2.Current != null)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;

                if (pointer1 == null)
                {
                    list1.Current.Next = list2.Current;
                    return list1;
                }
                if(pointer2 == null)
                {
                    list1.Current.Next = list2.Current;
                    list2.Current.Next = pointer1;
                    return list1;
                }

                list1.Current.Next = list2.Current;
                list1.Current = pointer1;

                list2.Current.Next = pointer1;
                list2.Current = pointer2;
            }

            return list1;
        }

        public static string Print(LList list)
        {
            string returnPrint = "";
            list.Current = list.Head;
            while(list.Current.Next != null)
            {
                returnPrint += list.Current.Value+" --> ";
                list.Current = list.Current.Next;
            }
            returnPrint += list.Current.Value + " --> NULL";
            Console.WriteLine();
            return returnPrint;
        }
    }
}
