using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Peeks at the node at the top of the stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Removed the top node from the stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Adds new node to the top of the stack
        /// </summary>
        /// <param name="node">new node</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
