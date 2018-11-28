using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    class Node
    {

        public string Value { get; set; }
        //Children are Nodes connected to vertex
        List<Node> Children { get; set; }
    }
}
