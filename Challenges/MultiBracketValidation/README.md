## Multi-Bracket Validation

This method utilizes the properties of a stack.  Since the patter is *First In Last Out*, it works nicely since we need to keep track of order of the brackets within the string.

## Visual
![multibracketvalidation](https://user-images.githubusercontent.com/25948479/47475019-a2d67a80-d7ce-11e8-91cd-d406f2e8eff3.jpg)


## Approach and Efficiency
* Time: O(n) since it iterates the length of the string. <br/>
* Space: O(n) since a new Stack was created to store brackets.

## Challenge
Create a new method that takes in a string as its only argument, and returns a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

Round Brackets : ( ) <br/>
Square Brackets : [ ]<br/>
Curly Brackets : { }