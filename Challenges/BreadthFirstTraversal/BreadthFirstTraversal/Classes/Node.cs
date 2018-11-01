using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class Node
    {
        public object Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node Next { get; set; }

        /// <summary>
        /// Constructor for new node
        /// </summary>
        /// <param name="value">value for node</param>
        public Node(object value)
        {
            Value = value;
        }
    }
}
