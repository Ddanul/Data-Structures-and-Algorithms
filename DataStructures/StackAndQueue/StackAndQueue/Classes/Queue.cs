using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Peeks at the front node in the Queue
        /// </summary>
        /// <returns>front node</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds new node to the end of the queue
        /// </summary>
        /// <param name="node">new node</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes node from the front of the queue
        /// </summary>
        /// <returns>removed node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }
    }
}
