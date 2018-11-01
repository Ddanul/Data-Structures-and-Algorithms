## Breadth First Traversal

This method traverses a binary tree using the breadth first approach.  This means that as it hits a node, it uses a queue to keep track of the children in the height level at any given time.  As it continues to travers to a lower level node, it dequeues the previous nodes.

## Visual
![breadthfirsttraversal](https://user-images.githubusercontent.com/25948479/47833583-d8441080-dd58-11e8-8678-6dd0fc405112.jpg)


## Approach and Efficiency
* Time: O(n) since it traverses through each node <br/>
* Space: O(w) since a depends on the width of the tree at any given level

## Challenge
Write a breadth first traversal method which takes a Binary Tree's root as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach; print every visited node’s value.