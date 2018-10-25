using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object input)
        {
            Value = input;
        }
    }
}
