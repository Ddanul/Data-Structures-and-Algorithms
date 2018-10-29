using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Adds node in proper location inside BST
        /// </summary>
        /// <param name="addNode">new node to add</param>
        public void Add(Node addNode)
        {
            Node thisNode = Root;

            while (thisNode != null)
            {
                if (addNode.Value < thisNode.Value)
                {
                    if (thisNode.Left != null)
                    {
                        thisNode = thisNode.Left;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (addNode.Value > thisNode.Value)
                {
                    if (thisNode.Right != null)
                    {
                        thisNode = thisNode.Right;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (addNode.Value > thisNode.Value)
            {
                thisNode.Right = addNode;
            }
            else
            {
                thisNode.Left = addNode;
            }
        }

        public Node Search(int value)
        {
            Node pointer = Root;
            while (pointer != null)
            {
                if (value == pointer.Value)
                {
                    return pointer;
                }
                else if (value > pointer.Value)
                {
                    pointer = pointer.Right;
                }
                else if (value < pointer.Value)
                {
                    pointer = pointer.Left;
                }
            }
            return null;
        }
    }
}
