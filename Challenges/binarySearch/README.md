# Binary Search

## Challenge
Write a method called BinarySearch which takes in 2 parameters: a sorted array and the 
search key. Without utilizing any of the built-in methods available to your language, 
return the index of the array�s element that is equal to the search key, or -1 if the 
element does not exist.

## Approach & Efficiency

1. Big O Time = O(log n) // Big O Space = O(1)
	- The iterative approach to binary search comes with a logn time because the array is
	continually being divided in half after every comparison. Since no other space is being analyzed
	or used, it stays at O(1).


## Solution

![binarysearch](https://user-images.githubusercontent.com/25948479/46777692-37b48080-ccc5-11e8-97fb-07d7cea60a5c.jpg)