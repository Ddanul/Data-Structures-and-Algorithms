## Trees

Binary Trees are trees that only contain nodes who’s value are numeric types. There is not a specific sorting order for a binary tree. When adding a node to a binary tree, you are not restricted on the node’s location. A binary search tree, however, is a type of tree that does have structure attached to it. In a binary search tree, the tree is organized in a manner where all numbers that are smaller than the root are placed to the left, and all numbers that are larger than the root are placed to the right.

## Visual
<img width="469" alt="tree01" src="https://user-images.githubusercontent.com/25948479/47671891-d2d6a280-db6d-11e8-846d-ad3b0149cfd4.PNG">


## Challenge
* Create a BinaryTree class and define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which takes in a root node, and returns an array of the nodes.

* Create a BinarySearchTree class and define a method named add that adds a new node in the correct location in the binary search tree as well as a method named search that brings in a value of node, and returns the node with the desired value.

## Examples of Use
1. Binary trees can be used for sorting and for mapping.

## Approach and Efficiency

* Pre-, Post-, and In- Traversal all have Time O(n) and Space of O(h) since all traverse Depth first.

* Binary Search Tree for insertion and search is O(log n) since we are only looking at one side of the tree at a time.