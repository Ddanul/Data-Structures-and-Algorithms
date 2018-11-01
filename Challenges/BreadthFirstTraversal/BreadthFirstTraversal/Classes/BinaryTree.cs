using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<object> searchValues = new List<object>();

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Pre Order Traversal root, left, right
        /// </summary>
        /// <param name="node">root node</param>
        /// <returns>list of integers in order</returns>
        public List<object> PreOrder(Node node)
        {
            object value = node.Value;
            searchValues.Add(value);

            if (node.Left != null)
            {
                PreOrder(node.Left);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right);
            }

            return searchValues;
        }

        /// <summary>
        /// In order traversal of tree
        /// </summary>
        /// <param name="node">root node</param>
        /// <returns>list of integers in order</returns>
        public List<object> InOrder(Node node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }

            searchValues.Add(node.Value);

            if (node.Right != null)
            {
                InOrder(node.Right);
            }

            return searchValues;
        }

        /// <summary>
        /// Post order traversal of tree
        /// </summary>
        /// <param name="node">root node</param>
        /// <returns>list of integers in order</returns>
        public List<object> PostOrder(Node node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right);
            }

            searchValues.Add(node.Value);

            return searchValues;
        }
    }
}
