## Find Maximum Value

This method traverses a binary tree using the Pre Order Traversal.  The method returns the values of each node in the form of a list.  The list is then iterated through in order to find the maximum value.

## Visual
![findmaxvalue](https://user-images.githubusercontent.com/25948479/47977271-fd43c680-e06b-11e8-8a0f-1b8b9670c1e4.jpg)


## Approach and Efficiency
* Time: O(n) since it traverses through each node <br/>
* Space: O(h) since a depends on the height of the tree at any given level

## Challenge
Write a function called find-maximum-value which takes binary tree as its only input. Return the maximum value stored in the tree. Assume that the values stored in the Binary Tree will be numeric.