using Graphs.Classes;
using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();

            Node node = new Node { Value = "chicken" };
            Tuple<Node, int> child = new Tuple<Node, int>(node, 2);

            graph.AddEdge("flamingo", child);

            Console.WriteLine("All Nodes:");
            var allNodes = graph.GetNodes();

            foreach(var item in allNodes)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Neighbor Nodes for Cat:");
            var neighbors = graph.GetNeighbors("cat");

            foreach (var item in neighbors)
            {
                Console.WriteLine(item.Item1.Value);
            }
        }
    }
}
