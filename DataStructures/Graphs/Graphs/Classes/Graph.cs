using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacencyList { get; set; }
        public int Count { get; set; }

        public Graph()
        {
            AdjacencyList = new LinkedList<LinkedList<Tuple<Node, int>>>();
            BuildGraph();
        }

        /// <summary>
        /// builds the graph with new nodes and linked lists and weights
        /// </summary>
        public void BuildGraph()
        {
            LinkedList<Tuple<Node, int>> NodeA = new LinkedList<Tuple<Node, int>>();
            LinkedList<Tuple<Node, int>> NodeB = new LinkedList<Tuple<Node, int>>();
            LinkedList<Tuple<Node, int>> NodeC = new LinkedList<Tuple<Node, int>>();


            NodeA.AddFirst(new Tuple<Node, int>(new Node { Value = "cat" }, 10));
            NodeA.AddLast(new Tuple<Node, int>(new Node { Value = "pup" }, 5));

            NodeB.AddFirst(new Tuple<Node, int>(new Node { Value = "flamingo" }, 7));
            NodeB.AddLast(new Tuple<Node, int>(new Node { Value = "penguin" }, 3));
            NodeB.AddLast(new Tuple<Node, int>(new Node { Value = "owl" }, 5));

            NodeC.AddFirst(new Tuple<Node, int>(new Node { Value = "dolphin" }, 2));


            AdjacencyList.AddFirst(NodeA);
            Count++;
            AdjacencyList.AddLast(NodeB);
            Count++;
            AdjacencyList.AddLast(NodeC);
            Count++;
        }

        /// <summary>
        /// Adds edge to parent node
        /// </summary>
        /// <param name="parent">Parent node</param>
        /// <param name="child">child node to add</param>
        public void AddEdge(string parentValue, Tuple< Node, int> child)
        {
            foreach (var item in AdjacencyList)
            {
                var node = item.First.Value.Item1;
                var weight = item.First.Value.Item2;

                if(node.Value == parentValue)
                {
                    item.AddLast(child);
                    Count++;
                }
            }
        }

        /// <summary>
        /// Gets a list of all nodes in graph
        /// </summary>
        /// <returns>list of nodes</returns>
        public List<Node> GetNodes()
        {
            List<Node> result = new List<Node>();

            foreach(var item in AdjacencyList)
            {
                foreach(var node in item)
                {
                    result.Add(node.Item1);
                }
            }

            return result;
        }

        /// <summary>
        /// gets list of neighbors of given node
        /// </summary>
        /// <param name="node">Node with neighbors</param>
        /// <returns>list of tuples of nodes and their respective weight</returns>
        public List<Tuple<Node,int>> GetNeighbors(string nodeValue)
        {
            List<Tuple<Node,int>> result = new List<Tuple<Node,int>>();

            foreach(var item in AdjacencyList)
            {
                if(item.First.Value.Item1.Value == nodeValue)
                {
                    foreach(var neighbor in item)
                    {
                        result.Add(neighbor);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// returns the number of nodes in graph
        /// </summary>
        /// <returns>number of nodes</returns>
        public int Size()
        {
            return Count;
        }
    }
}
