using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree
    {
        public Node Root { get; set; }
        List<int> searchValues = new List<int>();

        public BinaryTree(Node root)
        {
            Root = root;
        }

        public List<int> PreOrder(Node node)
        {
            int value = node.Value;
            searchValues.Add(value);

            if(node.Left != null)
            {
                PreOrder(node.Left);
            }
            if(node.Right != null)
            {
                PreOrder(node.Right);
            }

            return searchValues;
        }
    }
}
