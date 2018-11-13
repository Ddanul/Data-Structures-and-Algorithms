using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Key = value.ToString();
            Value = value;
        }
    }
}
